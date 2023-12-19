using TMPro;
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
    public int slotIndex;

    public TextMeshProUGUI countText;
    //For Upgrade Items to Unequip
    public void AddItem (Item newItem,int count)
    {
        item = newItem;
        backGImage.sprite = UiManager.instance.itemlevelSprites[newItem.itemLevel];
        if (count>1)
        {
            countText.text = count.ToString(); 
        }
        else
        {
            countText.text = "";
        }
        icon.sprite = item.icon;
        icon.enabled = true;
       // removeButton.interactable = true;
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
        backGImage.sprite = UiManager.instance.itemlevelSprites[newItem.itemLevel];

        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void AddSkill(Skills skill)
    {
        backGImage.sprite = UiManager.instance.itemlevelSprites[skill.skillLevel];
        icon.sprite = skill.skillImage;
        icon.enabled = true;
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
        if (countText != null)
        {
            countText.text = "";
        }
       
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
        if (_inventoryType == InventoryType.UnEquip)
        {
            if (slotIndex != null && !item.isDefault)
            {
               
                EquipmentManager.instance.upgradeEquipment[slotIndex] = null;
                EquipmentManager.instance.onItemAddedCallback.Invoke();
            }
        }

        else if (_inventoryType == InventoryType.Collect)
        {
            Destroy(transform.parent.gameObject);
            Player.instance.GetComponent<CollectItemAnimation>().CollectItem(icon.sprite);
            UiManager.instance.selectedPouch.GetComponent<PouchManager>().PouchInsideControl();
        }
        else if (_inventoryType == InventoryType.Skill)
        {
            // Skill Secme
            
        }
    }
    public void SetSlotIndex(int index)
    {
        slotIndex = index;
    }

}
public enum InventoryType
{
    Equip,
    Buy,
    Sell,
    Upgrade,
    UnEquip,
    Collect,
    Skill
}

