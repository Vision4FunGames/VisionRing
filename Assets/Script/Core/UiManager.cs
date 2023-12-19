using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DG.Tweening;
using MoreMountains.Tools;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [Header("Player Button")] public Button JumpBtn;
    public ButtonType[] ButtonType;
    public static UiManager instance;
    [Header("UI Objects")]
    public GameObject gamePlay, inventory,currentItems,blacksmithPanel,shopPanel,equipmentPanel,magicianPanel,armorFilter,gunFilter,deadPanel,skillPanel;

    [Header("Skill Buttons")] public Button[] skillButtons;
    private InventoryUI inventoryUi;
    private ShopUI shopUI;
    public GameObject inventoryObject;
    [HideInInspector] public float dashCoolDownLast, rotateFireLast, earthquickLast, flameTLastQuick;
    
    public MMProgressBar playerProgressBar;
    public FixedJoystick attackJoystick;
    public Sprite[] itemlevelSprites;
    public Sprite[] itemDescriptionSprites;
    public Sprite[] skillBGSprites;
    public Sprite emptySprite = null;
    public Material skillMaterial;

    [Header("Economy ")] public TextMeshProUGUI diamondText, gemText, goldText;
    //Chest Scroll
    public GameObject caseScroll;
    public GameObject chestPanel;
    public GameObject selectedPouch;
    public List<GameObject> UiPanels = new List<GameObject>();
    public GameObject collectBtn;
    public GameObject upgradeWheel;
    
    public GameObject inventoryBtnPanel,shopBtnPanel;

    [SerializeField]private SkillUpgrade skillUpgrade;
    //Economy
    public TextMeshProUGUI contentText;
    private ShopSlot[] shopSlots;
    
    public delegate void OnEconomyChanged();
    public OnEconomyChanged onEconomyChangedCallBack;
    private void Awake()
    {
        instance = this;
        
    }

    private void Start()
    {
        inventoryUi = InventoryUI.instance;
        shopUI = global::ShopUI.instance;
        inventory.SetActive(false);
        gamePlay.SetActive(true);
        shopSlots = GetComponents<ShopSlot>();
        onEconomyChangedCallBack += EconomyUI;
       
    }

    public void DisableButton()
    {
        for (int i = 0; i < ButtonType.Length; i++)
        {
            ButtonType[i].skillButton.enabled = false;
        }
    }

    public void EnableButton()
    {
        for (int i = 0; i < ButtonType.Length; i++)
        {
            ButtonType[i].skillButton.enabled = true;
        }
    }
    private void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            EconomyManager.instance.SetGold(5000);
        }
    }

    public void ShopUI()
    {
        CloseAllUI();
        shopPanel.gameObject.SetActive(true);
        equipmentPanel.gameObject.SetActive(true);
        inventory.gameObject.SetActive(true);
        inventoryObject.SetActive(true);
        inventoryUi.UpdateUI();
        shopUI.UpdateShop();
        onEconomyChangedCallBack.Invoke();
        contentText.text = "SHOP";
    }
    
    public void ShowInventory()
    {
        CloseAllUI();
        inventory.SetActive(true);
        inventoryObject.SetActive(true);
        equipmentPanel.gameObject.SetActive(true);
        currentItems.gameObject.SetActive(true);
        Inventory.instance.InventoryTypeChange(InventoryType.Equip);
        inventoryUi.ShowSelected("All");
        inventoryUi.UpdateUI();
        onEconomyChangedCallBack.Invoke();
        
    }

    public void BlackSmithUI()
    {
        CloseAllUI();
        inventory.gameObject.SetActive(true);
        blacksmithPanel.gameObject.SetActive(true);
        equipmentPanel.gameObject.SetActive(true);
        inventoryObject.gameObject.SetActive(true);
        Inventory.instance.InventoryTypeChange(InventoryType.Upgrade);
        inventoryUi.UpdateUI();
        contentText.text = "BLACKSMITH";

    }

    public void MagicianUI()
    {
        CloseAllUI();
        inventory.gameObject.SetActive(true);
        magicianPanel.gameObject.SetActive(true);
        contentText.text = "MAGICIAN";
        Inventory.instance.onItemChangedCallback?.Invoke();
        skillUpgrade.onSkillShopChangeCallBack?.Invoke();
        
        //skillUpgrade.BringCurrentSkills();

    }

    public void SkillUI()
    {
        CloseAllUI();
        inventory.gameObject.SetActive(true);
        skillPanel.gameObject.SetActive(true);
        contentText.text = "SKILLS";
        SkillPanel.instance.onSkillUseChangeCallBack.Invoke();
       
    }

    public void CloseAllUI()
    {
        for (int i = 0; i < UiPanels.Count; i++)
        {
            UiPanels[i].gameObject.SetActive(false);
        }
    }
    // public void UpdatePlayerHealthBar(float health)
    // {
    //     playerProgressBar.UpdateBar(health, 0, 100);
    // }

    public void GamePlayUI()
    {
        EquipmentManager.instance.SaveUpgradeItems();
        CloseAllUI();
        gamePlay.gameObject.SetActive(true);
    }

    public void ChestPanelUI()
    {
        CloseAllUI();
        inventory.gameObject.SetActive(true);
        chestPanel.gameObject.SetActive(true);
    }

    public void CollectButtonOpen()
    {
        collectBtn.gameObject.SetActive(true);
    }

    public void EconomyUI()
    {
        goldText.text = EconomyManager.instance.GetGold().ToString();
        diamondText.text = EconomyManager.instance.GetDiamond().ToString();
        gemText.text = EconomyManager.instance.GetGem().ToString();
    }

    public void InventoryFilter(String type)
    {
        if (type == "Gun")
        {
            armorFilter.gameObject.SetActive(false);
            gunFilter.gameObject.SetActive(true);
        }
        else if (type == "Armor")
        {
            armorFilter.gameObject.SetActive(true);
            gunFilter.gameObject.SetActive(false);
        }
        else
        {
            armorFilter.gameObject.SetActive(false);
            gunFilter.gameObject.SetActive(false);
        }
    }

    public void DeadUI()
    {
        deadPanel.gameObject.SetActive(true);
        deadPanel.GetComponent<Image>().DOFade(1f, 4f);
    }
}

[Serializable]
public class ButtonType
{
    public SkillType mySkillType;
    public Button skillButton;
    
}


