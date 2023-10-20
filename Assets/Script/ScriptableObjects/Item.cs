using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item", order = 2)]
public class Item : ScriptableObject
{
    public string name = "New ScriptableObject";
    [ES3NonSerializable] public Sprite icon;
    public bool showInInventory;
    public int itemLevel;

  

    public virtual void Use (InventoryType type)
    {
        // Use the item
        // Something may happen
    }

    // Call this method to remove the item from inventory
    public void RemoveFromInventory ()
    {
        Inventory.instance.Remove(this);
    }
    public void RemoveFromEquippedInventory(int slotIndex)
    {
        EquipmentManager.instance.currentEquipment[slotIndex] = null;
    }
}