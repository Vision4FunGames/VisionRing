using Unity.VisualScripting;
using UnityEngine;

/* An Item that can be equipped to increase armor/damage. */

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Equipment")]
public class Equipment : Item {

    public EquipmentSlot equipSlot;		// What slot to equip it in
    public int armorModifier;
    public int damageModifier;
    public SkinnedMeshRenderer mesh;
    public GameObject prefab;

    //public bool isEquipped = false;
    // Called when pressed in the inventory
    private void Start ()
    {
       
    }
    public override void Use ()
    {
        if (!showInInventory)
        {
            EquipmentManager.instance.Equip(this);
            this.showInInventory = true;
            // Equip
            RemoveFromInventory();	// Remove from inventory
        }
        else
        {
            EquipmentManager.instance.Unequip((int)equipSlot);
           RemoveFromEquippedInventory((int)this.equipSlot);
        }
    }

    
}

public enum EquipmentSlot { Head,Body, Weapon, Feet}