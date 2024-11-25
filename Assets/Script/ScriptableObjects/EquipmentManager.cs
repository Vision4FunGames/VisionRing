using System.Collections.Generic;
using DG.Tweening;
using GameAnalyticsSDK;
using Lofelt.NiceVibrations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class EquipmentManager : MonoBehaviour
{
    #region Singleton

    public static EquipmentManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<EquipmentManager>();
            }

            return _instance;
        }
    }

    static EquipmentManager _instance;
    public GameObject currentWeapon, currentInventoryWeapon;

    public delegate void OnItemAdded();

    public OnItemAdded onItemAddedCallback;

    void Awake()
    {
        _instance = this;
    }

    #endregion

    public List<Equipment> ItemDatabase;
    public Equipment[] defaultWear;
    public Equipment[] currentEquipment;
    private Equipment[] saveEquipment;
    SkinnedMeshRenderer[] currentMeshes;
    private SkinnedMeshRenderer[] currentInventoryMeshes;
    public SkinnedMeshRenderer targetMesh;
    public SkinnedMeshRenderer targetEnvanterMesh;
    public GameObject currentItemInventoryParent;
    private Player _player;
    private PlayerAttack _playerAttack;

    public Animator inventoryPlayerAnim;

    // Callback for when an item is equipped
    public delegate void OnEquipmentChanged(Equipment newItem, Equipment oldItem);

    public event OnEquipmentChanged onEquipmentChanged;

    Inventory inventory;

    //private EquippedInventory equippedInventory;
    public GameObject rightHand, leftHand;
    public GameObject inventoryHand, inventoryLeftHand;
    public Equipment[] upgradeEquipment;
    public InventorySlot[] upgradeSlots;
    public Item[] chestItems, upgradeItems, dropUsableItems;

    public Equipment selectedChestItem;
    private PlayerStats playerStats;

    void Start()
    {
        playerStats = FindObjectOfType<PlayerStats>();
        if (onEquipmentChanged == null)
        {
            onEquipmentChanged += playerStats.OnEquipmentChanged;
        }

        _player = FindObjectOfType<Player>();
        _playerAttack = FindObjectOfType<PlayerAttack>();
        ResetObjects();
        inventory = Inventory.instance;
        //equippedInventory = EquippedInventory.instance;
        int numSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        currentEquipment = new Equipment[numSlots];
        currentMeshes = new SkinnedMeshRenderer[numSlots];
        currentInventoryMeshes = new SkinnedMeshRenderer[numSlots];
        saveEquipment = new Equipment[numSlots];
        LoadEquipment();
        EquipAllDefault();
        onItemAddedCallback += UpdateUpgradeSlots;
    }

    public void LoadEquipment()
    {
        saveEquipment = ES3.Load("currentItems", currentEquipment);

        inventory.items.Clear();
        inventory.items = ES3.Load("inventory", inventory.items);
        inventory.itemsCount.Clear();
        inventory.itemsCount = ES3.Load("InvItemCount", inventory.itemsCount);
        inventory.usableItems = ES3.Load("UsableItems", inventory.usableItems);
        inventory.usableItemsCount = ES3.Load("UsableItemsCount", inventory.usableItemsCount);
        EconomyManager.instance.itemCount = ES3.Load("itemCount", EconomyManager.instance.itemCount);

        for (int i = 0; i < defaultWear.Length; i++)
        {
            defaultWear[i].icon = Resources.Load<Sprite>("ItemSprite/" + defaultWear[i].name);
        }

        EquipmentInitialize();
    }

    public void EquipmentInitialize()
    {
        for (int i = 0; i < saveEquipment.Length; i++)
        {
            if (saveEquipment[i] != null)
            {
                var s = saveEquipment[i].equipSlot.ToString();
                if (saveEquipment[i].equipSlot == EquipmentSlot.Weapon)
                {
                    saveEquipment[i].prefab = Resources.Load<GameObject>(s + "/" + saveEquipment[i].name);
                    saveEquipment[i].icon = Resources.Load<Sprite>("ItemSprite/" + saveEquipment[i].name);
                }
                else
                {
                    saveEquipment[i].mesh = Resources.Load<SkinnedMeshRenderer>(s + "/" + saveEquipment[i].name);
                }
            }
        }

        for (int i = 0; i < inventory.items.Count; i++)
        {
            inventory.items[i].icon ??= Resources.Load<Sprite>("ItemSprite/" + inventory.items[i].name);
        }
    }

    public void ResetObjects()
    {
        for (int i = 0; i < ItemDatabase.Count; i++)
        {
            ItemDatabase[i].showInInventory = false;
        }
    }

    void Update()
    {
    }


    public Equipment GetEquipment(EquipmentSlot slot)
    {
        return currentEquipment[(int)slot];
    }

    // Equip a new item

    #region Equip

    public void Equip(Equipment newItem)
    {
        Equipment oldItem = null;
        ParticleManager.instance.playerEnvanterParticleSystem.Play();
        // Find out what slot the item fits in
        // and put it there.

        int slotIndex = (int)newItem.equipSlot;


        // If there was already an item in the slot
        // make sure to put it back in the inventory
        if (currentEquipment[slotIndex] != null)
        {
            Debug.Log("Item var olan ile degisti");
            oldItem = currentEquipment[slotIndex];
            inventory.Add(oldItem);
            oldItem.showInInventory = false;
        }

        // An item has been equipped so we trigger the callback
        currentEquipment[slotIndex] = newItem;
        //equippedInventory.Add(newItem);

        newItem.showInInventory = true;
        if (newItem.mesh)
        {
            AttachToMesh(newItem.mesh, slotIndex);
            if (newItem.equipSlot == EquipmentSlot.Body)
            {
                inventoryPlayerAnim.SetTrigger("Armor");
            }
        }
        else if (newItem.prefab)
        {
            if (currentWeapon != null)
            {
                Destroy(currentWeapon);
                Destroy(currentInventoryWeapon);
            }

            currentWeapon = Instantiate(newItem.prefab,
                new Vector3(rightHand.transform.position.x, rightHand.transform.position.y,
                    rightHand.transform.position.z),
                Quaternion.identity);
            if (currentWeapon.GetComponentInChildren<GunType>().myGunType is CurrentGunType.sword
                or CurrentGunType.spear)
            {
                currentWeapon.transform.parent = rightHand.transform;
                currentWeapon.transform.localPosition = new Vector3(0, 0.0028f, 0);
                currentWeapon.transform.localEulerAngles = new Vector3(-31.375f, -43.925f, -97.642f);
                _playerAttack.ChangeGunType(currentWeapon.GetComponentInChildren<GunType>().myGunType);

                currentInventoryWeapon = Instantiate(newItem.prefab,
                    new Vector3(inventoryHand.transform.position.x, inventoryHand.transform.position.y,
                        inventoryHand.transform.position.z),
                    Quaternion.identity);
                currentInventoryWeapon.transform.parent = inventoryHand.transform;
                currentInventoryWeapon.transform.localPosition = new Vector3(0, 0.0028f, 0);
                currentInventoryWeapon.transform.localEulerAngles = new Vector3(-31.375f, -43.925f, -97.642f);
                if (currentWeapon.GetComponentInChildren<GunType>().myGunType == CurrentGunType.sword)
                {
                    inventoryPlayerAnim.SetTrigger("Sword");
                }
                else
                {
                    inventoryPlayerAnim.SetTrigger("Spear");
                }
            }

            else if (currentWeapon.GetComponentInChildren<GunType>().myGunType == CurrentGunType.arrow)
            {
                currentWeapon.transform.parent = leftHand.transform;
                currentWeapon.transform.localPosition = new Vector3(0, 0.0028f, 0);
                currentWeapon.transform.localEulerAngles = new Vector3(-31.375f, -43.925f, -97.642f);
                _playerAttack.ChangeGunType(currentWeapon.GetComponentInChildren<GunType>().myGunType);
                _playerAttack.myCurrentArrowType = currentWeapon.GetComponentInChildren<GunType>().MyArrowType;
                _player._baseCurrentArrowType = currentWeapon.GetComponentInChildren<GunType>().MyArrowType;
                currentInventoryWeapon = Instantiate(newItem.prefab,
                    new Vector3(inventoryHand.transform.position.x, inventoryHand.transform.position.y,
                        inventoryHand.transform.position.z),
                    Quaternion.identity);
                currentInventoryWeapon.transform.parent = inventoryLeftHand.transform;
                currentInventoryWeapon.transform.localPosition = new Vector3(0, 0.0028f, 0);
                currentInventoryWeapon.transform.localEulerAngles = new Vector3(-31.375f, -43.925f, -97.642f);
                inventoryPlayerAnim.SetTrigger("Bow");
            }
        }

        if (onEquipmentChanged != null)
            onEquipmentChanged.Invoke(newItem, oldItem);
        CheckItemSet();
        //equippedItems [itemIndex] = newMesh.gameObject;
    }

    public void Unequip(int slotIndex)
    {
        if (currentEquipment[slotIndex] != null)
        {
            Equipment oldItem = currentEquipment[slotIndex];
            inventory.Add(oldItem);
            oldItem.showInInventory = false;
            //equippedInventory.Remove(oldItem);	
            currentEquipment[slotIndex] = null;
            if (currentMeshes[slotIndex] != null)
            {
                Destroy(currentMeshes[slotIndex].gameObject);
                Destroy(currentInventoryMeshes[slotIndex].gameObject);
            }
            else if (slotIndex == 2 && currentWeapon != null)
            {
                Destroy(currentWeapon);
                Destroy(currentInventoryWeapon);
            }

            //equippedInventory.Remove(oldItem);
            InventoryUI.instance.currentItemsParent.transform.GetChild(slotIndex)
                .GetComponent<InventorySlot>().ClearSlot();
            // Equipment has been removed so we trigger the callback
            if (onEquipmentChanged != null)
                onEquipmentChanged.Invoke(null, oldItem);
            if (inventory.onItemChangedCallback != null)
                inventory.onItemChangedCallback.Invoke();
        }

        CheckItemSet();
        ES3.Save("currentItems", currentEquipment);
        ES3.Save("inventory", inventory.items);
        Debug.Log("Saved");
    }

    void UnequipAll()
    {
        for (int i = 0; i < currentEquipment.Length; i++)
        {
            Unequip(i);
        }

        EquipAllDefault();
    }

    void EquipAllDefault()
    {
        // foreach (Equipment e in saveEquipment) {
        // 	if (e != null)
        // 	{
        // 		Equip (e);
        // 	}
        // }

        for (int i = 0; i < saveEquipment.Length; i++)
        {
            if (saveEquipment[i] != null)
            {
                Equip(saveEquipment[i]);
            }
            else
            {
                Equip(defaultWear[i]);
            }
        }
    }

    void AttachToMesh(SkinnedMeshRenderer mesh, int slotIndex)
    {
        if (currentMeshes[slotIndex] != null && slotIndex != 2)
        {
            Destroy(currentMeshes[slotIndex].gameObject);
            Destroy(currentInventoryMeshes[slotIndex].gameObject);
        }

        SkinnedMeshRenderer newMesh = Instantiate(mesh) as SkinnedMeshRenderer;
        newMesh.bones = targetMesh.bones;
        newMesh.rootBone = targetMesh.rootBone;
        currentMeshes[slotIndex] = newMesh;
        //Inventory Player
        SkinnedMeshRenderer newMesh2 = Instantiate(mesh) as SkinnedMeshRenderer;
        newMesh2.bones = targetEnvanterMesh.bones;
        newMesh2.rootBone = targetEnvanterMesh.rootBone;
        currentInventoryMeshes[slotIndex] = newMesh2;
    }

    void CheckItemSet()
    {
        for (int i = 0; i < currentEquipment.Length; i++)
        {
            if (currentEquipment[i] == null)
            {
                return;
            }
        }

        InventorySlot[] currentSlots = InventoryUI.instance.currentItemsParent.GetComponentsInChildren<InventorySlot>();
        if (currentEquipment[0].itemSet == currentEquipment[1].itemSet &&
            currentEquipment[0].itemSet == currentEquipment[3].itemSet && currentEquipment[0].itemSet != 0)
        {
            for (int i = 0; i < currentSlots.Length; i++)
            {
                if (i == 2)
                {
                    i++;
                }

                currentSlots[i].backGImage.material = UiManager.instance.skillMaterial;
            }
        }
        else
        {
            for (int i = 0; i < currentSlots.Length; i++)
            {
                currentSlots[i].backGImage.material = null;
            }
        }
    }

    #endregion

    #region Upgrade

    public void UpgradeEquip(Equipment newItem)
    {
        Debug.Log("A1");
        for (int i = 0; i < upgradeEquipment.Length; i++)
        {
            if (upgradeEquipment[i] == null)
            {
                upgradeEquipment[i] = newItem;
                newItem.RemoveFromInventory();
                UpdateStatsText(newItem);


                if (onItemAddedCallback != null)
                {
                    onItemAddedCallback.Invoke();
                }

                return;
            }
        }
    }

    public void UpdateStatsText(Equipment newItem)
    {
        if ((newItem.damageModifier * playerStats.damage.GetValue() > 0))
        {
            float damage = newItem.damageModifier * playerStats.damage.GetValue();
            float newItemDamage = (newItem.damageModifier + 1) * playerStats.damage.GetValue();
            UiManager.instance.upGradeTxt1.text =
                damage + " " + $"+ <color=green>{(newItemDamage - damage)}</color>";
            newItem.damageModifier += 1;
        }


        if (newItem.armorModifier * playerStats.armor.GetValue() > 0)
            UiManager.instance.upGradeTxt2.text =
                (newItem.armorModifier * playerStats.armor.GetValue()).ToString();

        if (newItem.armorModifier * playerStats.armor.GetValue() > 0)
            UiManager.instance.upGradeTxt3.text =
                (newItem.hpModifier * playerStats.health.GetValue()).ToString();
    }

    private void UpdateUpgradeSlots()
    {
        Debug.Log("A2");
        for (int i = 0; i < upgradeSlots.Length; i++)
        {
            if (upgradeEquipment[i] != null)
            {
                upgradeSlots[i].AddItem(upgradeEquipment[i]);
            }
            else
            {
                upgradeSlots[i].ClearSlot();
            }
        }
    }

    public void UpgradeItem()
    {
        Debug.Log("A3");
        for (int i = 0; i < upgradeEquipment.Length; i++)
        {
            if (upgradeEquipment[i] == null)
            {
                return;
            }
        }

        Equipment eq = new Equipment();
        eq.Fill(upgradeEquipment[0]);
        eq.itemLevel = upgradeEquipment[0].itemLevel + 1;
        eq.name = upgradeEquipment[0].name;
        eq.showInInventory = true;
        inventory.Add(eq);
        if (inventory.onItemChangedCallback != null)
        {
            inventory.onItemChangedCallback.Invoke();
        }

        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "BlackSmith", eq.name);
        ClearUpgradeSlots();

        inventory.SaveAllItems();

        if (FindObjectOfType<MeetBuckley>())
        {
            UiManager.instance.GamePlayUI();
            FindObjectOfType<TaskPrefab>().isCompleted = true;
            Inventory.instance.InventoryTypeChange(InventoryType.Inventory);
            InventoryUI.instance.ShowSelected("All");
            InventoryUI.instance.UpdateUI();
            FindObjectOfType<InventoryUI>().itemsParent.GetChild(0).GetComponent<InventorySlot>().UseItem();
            Destroy(FindObjectOfType<TaskPrefab>().gameObject, 1);
        }
    }

    private void ClearUpgradeSlots()
    {
        for (int i = 0; i < upgradeEquipment.Length; i++)
        {
            upgradeEquipment[i] = null;
        }

        if (onItemAddedCallback != null)
        {
            onItemAddedCallback.Invoke();
        }
    }

    public void SaveUpgradeItems()
    {
        for (int i = 0; i < upgradeEquipment.Length; i++)
        {
            if (upgradeEquipment[i] != null)
            {
                if (inventory.items.Contains(upgradeEquipment[i]))
                {
                    int index = inventory.items.FindIndex(r => r.name.Contains(upgradeEquipment[i].name));
                    inventory.itemsCount[index]++;
                }
                else
                {
                    inventory.items.Add(upgradeEquipment[i]);
                    inventory.itemsCount.Add(1);
                }
                //inventory.items.Add(upgradeEquipment[i]);
            }
        }

        ClearUpgradeSlots();
        inventory.SaveAllItems();
    }

    #endregion

    #region EarnItem

    public void EarnItem(Equipment equipment)
    {
        if (Inventory.instance.items.Contains(equipment))
        {
            int index = Inventory.instance.items.FindIndex(r => r.name.Contains(equipment.name));
            Inventory.instance.itemsCount[index]++;
        }
        else
        {
            Inventory.instance.items.Add(equipment);
            Inventory.instance.itemsCount.Add(1);
        }

        //Inventory.instance.items.Add(this);
        Inventory.instance.onItemChangedCallback.Invoke();
        PlayerManager.instance.earnItemParticle.Play();
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.Warning);
        Player.instance.playerSound.audioSource.clip = Player.instance.playerSound.earnItemSound;
        Player.instance.playerSound.audioSource.Play();
    }

    #endregion'
}