using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeItem", menuName = "Staff", order = 3)]
public class UpgradeItem : Item
{
    public override void Use(InventoryType type)
    {
        if (type == InventoryType.Collect)
        {
            Inventory.instance.upgradeItems.Add(this);
            Inventory.instance.onItemChangedCallback.Invoke();
        }
    }
}
