using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeItem", menuName = "UsableItem", order = 3)]
public class UsableItem : Item
{
    public GameObject popUp;
    public Transform popUpTransform;
    public override void Use(InventoryType type,int count = 0)
    {
        if (type == InventoryType.Usable)
        {
            if (this.name == "DungeonPortal")
            {
                DungeonPortal();
            }
        }
        else if (type == InventoryType.Collect)
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
        RemoveFromUsable();
        UiManager.instance.CloseAllUI();
        UiManager.instance.MapOpen();
        UiManager.instance.GamePlayUI();
       
    }

    private void DungeonPortal()
    {
      
        FindObjectOfType<TeleportManager>().TeleportOpenAll();
        ResetScreen();
    }

    public void ResetScreen()
    {
        RemoveFromUsable();
        UiManager.instance.CloseAllUI();
        UiManager.instance.GamePlayUI();
    }
    public void PopupOpen()
    {
        popUp = Instantiate(Resources.Load("UsablePopUp")as GameObject);
        popUp.transform.parent = popUpTransform.parent.transform.parent.transform.parent.transform.parent;
        popUpTransform.position = new Vector3(0, 0, 0);
        
    }
}
    // Start is called before the first frame update


