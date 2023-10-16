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
        UpdateUI();
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
                    if ((i < inventory.items.Count) && (listEq[i].equipSlot == EquipmentSlot.Weapon))
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
                break;
        }
        
        if (type == "All")
        {
            
        }
        for (int i = 0; i < equipmentManager.currentEquipment.Length; i++)
        {
            if (equipmentManager.currentEquipment[i] != null)
            {
                int index = (int)equipmentManager.currentEquipment[i].equipSlot;
                currentSlots[index].AddItem(equipmentManager.currentEquipment[i]);
                currentSlots[index].isEquipped = true;
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

    public void ShowSelected(string selected)
    {
        type = selected;
        UpdateUI();
        type = "All";
        
    }

    public void ConvertToEquipmentList()
    {
        listEq.Clear();
        for (int i = 0; i < inventory.items.Count; i++)
        {
            listEq.Add((Equipment)inventory.items[i]);
        }
    }

}