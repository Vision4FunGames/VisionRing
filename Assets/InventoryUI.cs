using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

/* This object manages the inventory UI. */

public class InventoryUI : MonoBehaviour {

    
    #region Singleton


    public static InventoryUI instance;
        

    void Awake ()
    {
        instance = this;
    }

    #endregion
    public GameObject inventoryUI;	// The entire UI
    public Transform itemsParent,currentItemsParent;	// The parent object of all the items

    Inventory inventory;	// Our current inventory
    private EquipmentManager equipmentManager;
    void Start ()
    {
        equipmentManager = EquipmentManager.instance;
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        UpdateUI();
        inventory.gameObject.SetActive(false);
    }

    // Check to see if we should open/close the inventory
    void Update ()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
            UpdateUI();
        }
    }

    // Update the inventory UI by:
    //		- Adding items
    //		- Clearing empty slots
    // This is called using a delegate on the Inventory.
    public void UpdateUI ()
    {
        InventorySlot[] slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        InventorySlot[] currentSlots = currentItemsParent.GetComponentsInChildren<InventorySlot>();
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

}