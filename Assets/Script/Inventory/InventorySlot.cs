using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class InventorySlot : MonoBehaviour
{
    public Image icon;
   // public Button removeButton;
     Item item;
     private UsableItem usableItem;// Current item in the slot
    public bool isEquipped = false;
    public InventoryType _inventoryType;

    public Image backGImage;
    // Add item to the slot
    public int slotIndex;
    private Skills skill;
    public TextMeshProUGUI countText;
    //For Upgrade Items to Unequip
    public void AddItem (Item newItem,int count)
    {
        item = newItem;
        if (_inventoryType is InventoryType.Inventory or InventoryType.Upgrade or InventoryType.Usable)
        {
            int maxIndex = UiManager.instance.itemlevelSprites45.Length - 1;
            int clampedIndex = Mathf.Clamp(newItem.itemLevel, 0, maxIndex);
            backGImage.sprite = UiManager.instance.itemlevelSprites45[clampedIndex];
        }
        else
        {
            int maxIndex = UiManager.instance.itemlevelSprites45.Length - 1;
            int clampedIndex = Mathf.Clamp(newItem.itemLevel, 0, maxIndex);
            backGImage.sprite = UiManager.instance.itemlevelSprites45[clampedIndex];
        }
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

    public string GetItemName()
    {
        return item.name;
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
        if (_inventoryType == InventoryType.Inventory)
        {
            backGImage.sprite = UiManager.instance.itemLevelSprites[newItem.itemLevel];
        }
        else
        {
            int maxIndex = UiManager.instance.itemlevelSprites45.Length - 1;
            int clampedIndex = Mathf.Clamp(newItem.itemLevel, 0, maxIndex);
            backGImage.sprite = UiManager.instance.itemlevelSprites45[clampedIndex];
        }
      

        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void AddSkill(Skills skill)
    {
        this.skill = skill;
        switch (skill.skillName)
        {
            case "FireRotate":
                backGImage.sprite = Resources.Load<Sprite>("SkillSprite/slot red");
                break;
            case "FlameT":
                backGImage.sprite = Resources.Load<Sprite>("SkillSprite/slot red");
                break;
            case "EarthQ":
                backGImage.sprite = Resources.Load<Sprite>("SkillSprite/slot red");
                break;
            case "Tornado":
                backGImage.sprite = Resources.Load<Sprite>("SkillSprite/slot orange");
                break;
            case "Sword":
                backGImage.sprite = Resources.Load<Sprite>("SkillSprite/slot gray");
                break;
            case "ArrowRain":
                backGImage.sprite = Resources.Load<Sprite>("SkillSprite/slot gray");
                break;
            case "Clone":
                backGImage.sprite = Resources.Load<Sprite>("SkillSprite/slot green");
                break;
            case "Shield":
                backGImage.sprite = Resources.Load<Sprite>("SkillSprite/slot green");
                break;
                
        }
      //  backGImage.sprite = UiManager.instance.itemlevelSprites[skill.skillLevel];
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
        Inventory.instance.Remove(item,false);
    }

    // Use the item
    public void UseItem ()
    {
        if (_inventoryType == InventoryType.Collect)
        {
            item?.Use(_inventoryType,int.Parse(countText
                .text));
        }
        else if (_inventoryType == InventoryType.Usable)
        {
            
        }
        else
        {
            item?.Use(_inventoryType);
        }
        
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
            Player.instance.GetComponent<CollectItemAnimation>().CollectItem(item,int.Parse(countText.text));
            UiManager.instance.selectedPouch.GetComponent<PouchManager>().PouchInsideControl();
        }
        else if (_inventoryType == InventoryType.Skill)
        {
            // Skill Secme
            SkillPanel.instance.selectedSlot = this;
            SkillPanel.instance.onSelectedSkillChange.Invoke();
        }
        else if (_inventoryType == InventoryType.CurrentSkill)
        {
            SkillPanel.instance.currentSlot = this;
            SkillPanel.instance.ChangeSkill();
            
        }
        else if (_inventoryType == InventoryType.Usable)
        {
            usableItem = (UsableItem)item;
            if (item!=null)
            {
               var popUp = Instantiate(Resources.Load("UsablePopUp")as GameObject);
                popUp.transform.parent = transform.parent.transform.parent.transform.parent.transform.parent;
                popUp.transform.position = new Vector3(transform.position.x -20f,transform.position.y,transform.position.z);
    
                popUp.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
                {
                    item.Use(InventoryType.Usable, 0);
                    Destroy(popUp);
                });
                popUp.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(() =>
                {
                    Destroy(popUp);
                });
                popUp.transform.GetChild(2).GetComponent<Button>().onClick.AddListener(() =>
                {
                    usableItem.RemoveFromUsable();
                    Destroy(popUp);
                });
            }
            
            
        }
        else if (_inventoryType == InventoryType.SkillInfo)
        {
            UiManager.instance.SkillPopUp(skill);
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
    Skill,
    CurrentSkill,
    Inventory,
    Usable,
    SkillInfo
}

