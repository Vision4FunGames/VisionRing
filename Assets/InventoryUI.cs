using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine.UI;

/* This object manages the inventory UI. */

public class InventoryUI : MonoBehaviour {

    
    #region Singleton
    public static InventoryUI instance;
    private string type = "All";
    void Awake ()
    {
        instance = this;
    }
    #endregion
    public GameObject inventoryUI;	// The entire UI
    public Transform itemsParent,currentItemsParent;	// The parent object of all the items
    Inventory inventory;	// Our current inventory
    private EquipmentManager equipmentManager;
    List<Equipment> listEq = new List<Item>().Cast<Equipment>().ToList();
    void Start ()
    {
        equipmentManager = EquipmentManager.instance;
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        
        inventory.gameObject.SetActive(false);
        int counter = 0;
    }
    // Check to see if we should open/close the inventory
    void Update ()
    {
        // if (Input.GetButtonDown("Inventory"))
        // {
        //     inventoryUI.SetActive(!inventoryUI.activeSelf);
        //     UpdateUI();
        // }
    }
    // Update the inventory UI by:
    //		- Adding items
    //		- Clearing empty slots
    // This is called using a delegate on the Inventory.
    public void UpdateUI ()
    {
        int counter = 0;
        ConvertToEquipmentList();
        InventorySlot[] slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        InventorySlot[] currentSlots = currentItemsParent.GetComponentsInChildren<InventorySlot>();
        DefaultWearBringTop();
        if (type == "")
        {
            type = "All";
        }
        switch (type)
        { 
            case "All":
                
                for (int i = 0; i < slots.Length; i++)
                {
                    if (i < inventory.items.Count)
                    {
                        slots[i].AddItem(inventory.items[i]);
                    } else
                    {
                        slots[i].ClearSlot();
                    }
                }
                break;
            case "Armor":
                ClearAllSlots();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if ((i < inventory.items.Count) && (listEq[i].equipSlot == EquipmentSlot.Body))
                    {
                            slots[counter].AddItem(inventory.items[i]);
                            counter++;
                    } 
                }
                break;
            case "Sword":
                ClearAllSlots();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if ((i < inventory.items.Count) && (listEq[i]?.equipSlot == EquipmentSlot.Weapon))
                    {
                        slots[counter].AddItem(inventory.items[i]);
                        counter++;
                    } 
                }
                break;
            case "Shoes":
                ClearAllSlots();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if ((i < inventory.items.Count) && (listEq[i].equipSlot == EquipmentSlot.Feet))
                    {
                        slots[counter].AddItem(inventory.items[i]);
                        counter++;
                    } 
                }
                break;
            case "Head":
                ClearAllSlots();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if ((i < inventory.items.Count) && (listEq[i].equipSlot == EquipmentSlot.Head))
                    {
                        slots[counter].AddItem(inventory.items[i]);
                        counter++;
                    } 
                }
                break;
            case "Potion":
                ClearAllSlots();
                CountItem();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if (i<EconomyManager.instance.itemList.Count)
                    {
                        if (EconomyManager.instance.itemCount[i] > 0)
                        {
                            slots[i].AddItem(EconomyManager.instance.itemList[i]);
                            slots[i].countText.text = EconomyManager.instance.itemCount[i].ToString();
                        }
                       
                    }
                }
                break;
        }
        
        for (int i = 0; i < equipmentManager.currentEquipment.Length; i++)
        {
            if (equipmentManager.currentEquipment[i] != null)
            {
                int index = (int)equipmentManager.currentEquipment[i].equipSlot;
                currentSlots[index].AddItem(equipmentManager.currentEquipment[i]);
                currentSlots[index].isEquipped = true;
            }
            else
            {
                int index = (int)equipmentManager.defaultWear[i].equipSlot;
                currentSlots[i].AddItem(equipmentManager.defaultWear[i]);
                currentSlots[index].isEquipped = true;
                equipmentManager.Equip(equipmentManager.defaultWear[i]);
            }
        }
        
        for (int i = 0; i <currentSlots.Length; i++)
        {
            if (currentSlots[i].isEquipped ==false || currentSlots[i].name == null)
            {
                currentSlots[i].ClearSlot();
               
            }
        }
        // for (int i = 0; i < currentSlots.Length; i++)
        // {
        //     if (i < equipmentManager.currentEquipment.Length)
        //     {
        //         currentSlots[i].EquipItem(equipmentManager.currentEquipment[i]);
        //     } else
        //     {
        //         currentSlots[i].ClearSlot();
        //     }
        // }
    }

  
    private void ClearAllSlots()
    {
        InventorySlot[] slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].ClearSlot();
        }
    }
    
    //Button filter
    public void ShowSelected(string selected)
    {
        var btnBG = UiManager.instance.inventoryBtnPanel.GetComponentsInChildren<Button>();
        for (int i = 0; i < btnBG.Length; i++)
        {
            var image = btnBG[i].GetComponent<Image>().color;
            btnBG[i].GetComponent<Image>().color = new Color(image.r, image.g, image.b, 0f);
        }
        
        type = selected;
        UpdateUI();
        type = "All";
        
    }

    //selected button background change
    public void SelectedButton(GameObject btn)
    {
        var color = btn.GetComponent<Image>().color;
        btn.GetComponent<Image>().color = new Color(color.r, color.g, color.b, 255f);
    }
    public void ConvertToEquipmentList()
    {
        listEq.Clear();
        for (int i = 0; i < inventory.items.Count; i++)
        {
            if (inventory.items[i].GetType() == typeof(Item))
            {
                listEq.Add((Equipment)inventory.items[i]); 
            }
            

            
        }
    }

    public void DefaultWearBringTop()
    {
        for (int i = 0; i < inventory.items.Count; i++)
        {
            if (inventory.items[i].isDefault)
            {
                int index = (int)listEq[i].equipSlot;
                var temp = inventory.items[index];
                inventory.items[index] = inventory.items[i];
                inventory.items[i] = temp;
            }
        }
    }
    
    private void CountItem()
    {
        for (int i = 0; i < EconomyManager.instance.itemList.Count; i++)
        {
            EconomyManager.instance.itemCount[i] = GetItemCount(EconomyManager.instance.itemList[i].name);
        }
        
    }

    public int GetItemCount(String itemName)
    {
        int count = 0;

        foreach (var item in Inventory.instance.upgradeItems)
        {
            if (item.name == itemName)
            {
                count++;
            }
        }
        return count;
    } 

   
}