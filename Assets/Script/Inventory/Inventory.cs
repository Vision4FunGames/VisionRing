using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections.ObjectModel;

public class Inventory : MonoBehaviour
{
    #region Singleton

    public static Inventory instance;
    private EquipmentManager equipmentManager;
    
    void Awake ()
    {
        instance = this;
        equipmentManager = EquipmentManager.instance;
        
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 10;	// Amount of item spaces

    // Our current list of items in the inventory
    public List<Item> items = new List<Item>();
    public List<Item> upgradeItems = new List<Item>();
    public List<Item> currentItems = new List<Item>();
    
    // Add a new item if enough room
    private void Start()
    {
        
    }

    public void Add (Item item)
    {
        Debug.Log("Add e Girildi");
         if (item.showInInventory && !item.isDefault)
         {
            if (items.Count >= space)
            {
                Debug.Log("Not enough room.");
                return;
            }
            if (item.isUpgrade)
            {
                upgradeItems.Add(item);
            }
            else
            {
                items.Add(item);
            }
            item.showInInventory = false;
            Debug.Log("Item Added to Inventory " + item.name);
            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
            SaveAllItems();
        }
        
    }

    // Remove an item
    public void Remove (Item item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
        ES3.Save("currentItems",equipmentManager.currentEquipment);
        ES3.Save("inventory",items);
        Debug.Log("Saved");
    }

    public void InventoryTypeChange(InventoryType type)
    {
        InventorySlot[] slots;
        slots = InventoryUI.instance.itemsParent.GetComponentsInChildren<InventorySlot>();
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i]._inventoryType = type;
        }
    }

    public void SaveAllItems()
    {
        ES3.Save("currentItems",equipmentManager.currentEquipment);
        ES3.Save("inventory",items);
        ES3.Save("upgradeItems",upgradeItems);
        Debug.Log("Saved");
    }
    
    
}
