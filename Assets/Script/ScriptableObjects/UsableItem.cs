using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeItem", menuName = "UsableItem", order = 3)]
public class UsableItem : Item
{
    private GameObject popUp;
    public Transform popUpTransform;
    public override void Use(InventoryType type,int count = 0)
    {
        if (this.name == "TownScroll")
        {
            TownScroll();
        }
        if (type == InventoryType.Collect)
        {
            // Inventory.instance.upgradeItems.Add(this);
            for (int i = 0; i < Inventory.instance.usableItems.Count; i++)
            {
                if (Inventory.instance.usableItems[i] == this)
                {
                    Inventory.instance.usableItemsCount[i] += 1;
                }
            }
            Inventory.instance.onItemChangedCallback.Invoke();
        }
    }

    private void TownScroll()
    {
       Debug.Log("Town Scroll");
    }

    public void PopupOpen()
    {
        popUp = Instantiate(Resources.Load("UsablePopUp")as GameObject);
        popUp.transform.parent = popUpTransform.parent.transform.parent.transform.parent.transform.parent;
        popUpTransform.position = new Vector3(0, 0, 0);
    }
}
    // Start is called before the first frame update


