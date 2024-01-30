using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeItem", menuName = "Staff", order = 3)]
public class UpgradeItem : Item
{
    public override void Use(InventoryType type,int Count)
    {
        if (type == InventoryType.Collect)
        {
           // Inventory.instance.upgradeItems.Add(this);
            for (int i = 0; i < EconomyManager.instance.itemList.Count; i++)
            {
                if (EconomyManager.instance.itemList[i] == this)
                {
                    EconomyManager.instance.itemCount[i] += Count;
                }
            }
            Inventory.instance.onItemChangedCallback.Invoke();
        }
    }
}
