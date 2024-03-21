using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Itemmm", menuName = "Item", order = 2)]
public class Item : ScriptableObject
{
    public string name = "New ScriptableObject";
    public Sprite icon;
    [ES3NonSerializable] public bool showInInventory;
     public bool isDefault;
    [ES3NonSerializable] public bool isUpgrade;
    public int itemLevel;
    
    

    public virtual void Use (InventoryType type,int Count = 0)
    {
        // Use the item
        // Something may happen
    }

    // Call this method to remove the item from inventory
    public void RemoveFromInventory ()
    {
        Inventory.instance.Remove(this,false);
    }

    public void RemoveFromUsable()
    {
        Inventory.instance.Remove(this, true);
    }
    public void RemoveFromEquippedInventory(int slotIndex)
    {
        EquipmentManager.instance.currentEquipment[slotIndex] = null;
    }
}