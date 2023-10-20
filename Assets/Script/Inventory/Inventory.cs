using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public List<Item> currentItems = new List<Item>();
    
    // Add a new item if enough room
    private void Start()
    {
        
    }

    public void Add (Item item)
    {
        Debug.Log("Add e Girildi");
         if (item.showInInventory)
         {
            if (items.Count >= space)
            {
                Debug.Log("Not enough room.");
                return;
            }
            items.Add(item);
            Debug.Log("Item Added to Inventory " + item.name);
            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
            ES3.Save("currentItems",equipmentManager.currentEquipment);
            ES3.Save("inventory",items);
            Debug.Log("Saved");
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

}
