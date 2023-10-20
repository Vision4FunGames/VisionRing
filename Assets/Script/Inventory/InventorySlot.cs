using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class InventorySlot : MonoBehaviour
{
    public Image icon;
   // public Button removeButton;
     Item item;	// Current item in the slot
    public bool isEquipped = false;
    public InventoryType _inventoryType;

    public Image backGImage;
    // Add item to the slot
    
    public void AddItem (Item newItem)
    {
        item = newItem;
        backGImage.sprite = UiManager.instance.itemlevelSprites[newItem.itemLevel];
       
        icon.sprite = item.icon;
        icon.enabled = true;
       // removeButton.interactable = true;
    }
    
    // Clear the slot
    public void ClearSlot ()
    {
        item = null;
        icon.sprite = null;
        if (UiManager.instance.emptySprite != null)
        {
            backGImage.sprite = UiManager.instance.emptySprite;
        }
       
        icon.enabled = false;
       // removeButton.interactable = false;
    }

    // If the remove button is pressed, this function will be called.
    public void RemoveItemFromInventory ()
    {
        Inventory.instance.Remove(item);
    }

    // Use the item
    public void UseItem ()
    {
        item?.Use(_inventoryType);
    }

}
public enum InventoryType
{
    Equip,
    Buy,
    Sell,
    Upgrade
}