using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

/* An Item that can be equipped to increase armor/damage. */

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Equipment")]
public class Equipment : Item {

    public EquipmentSlot equipSlot;		// What slot to equip it in
    public int armorModifier;
    public int damageModifier;
    public SkinnedMeshRenderer mesh;
   
    [ES3NonSerializable]public GameObject prefab;

    public int price = 0;

   
    //public bool isEquipped = false;

    [ContextMenu("Save")]
    public void Save()
    {
        AssetDatabase.SaveAssets();
    }
  
    
    public override void Use (InventoryType type)
    {
        // Called when pressed in the inventory
        if (type == InventoryType.Equip)
        { 
            if (!showInInventory)
                {
                       EquipmentManager.instance.Equip(this);
                       this.showInInventory = true;
                       // Equip
                       RemoveFromInventory();	// Remove from inventory
                }
            else if(!isDefault)
                {
                       EquipmentManager.instance.Unequip((int)equipSlot);
                      RemoveFromEquippedInventory((int)this.equipSlot);
                 } 
        }

        if (type == InventoryType.Buy)
        {
            Inventory.instance.items.Add(this);
            Inventory.instance.onItemChangedCallback.Invoke();

        }

        if (type == InventoryType.Upgrade)
        {
            EquipmentManager.instance.UpgradeEquip(this);
            //RemoveFromInventory();
        }

        if (type == InventoryType.UnEquip )
        {
            Inventory.instance.items.Add(this);
            Inventory.instance.onItemChangedCallback.Invoke();
        }

        if (type == InventoryType.Collect)
        {
            Inventory.instance.items.Add(this);
            Inventory.instance.onItemChangedCallback.Invoke();
        }
    }

    public void Fill(Equipment item)
    {
        this.equipSlot = item.equipSlot;
        armorModifier = item.armorModifier;
        damageModifier = item.damageModifier;
        mesh = item.mesh;
        price = item.price;
        name = item.name;
        icon = item.icon; 
        isDefault = item.isDefault;
        isUpgrade = item.isUpgrade;
        prefab = item.prefab;
        Save();
    }
}

public enum EquipmentSlot { Head,Body, Weapon, Feet}