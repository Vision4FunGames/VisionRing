using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections.ObjectModel;
using System.Linq;
using Unity.VisualScripting;

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
    public List<int> itemsCount = new List<int>();
    public List<Item> upgradeItems = new List<Item>();
    public List<Item> currentItems = new List<Item>();
    List<Equipment> listEq = new List<Item>().Cast<Equipment>().ToList();
    
    // Add a new item if enough room
    private void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        listEq.Clear();
        for (int i = 0; i <items.Count; i++)
        {
            items[i].icon ??= Resources.Load<Sprite>("ItemSprite/" + items[i].name);
            
            if (items[i].GetType() == typeof(Equipment))
            {
                listEq.Add((Equipment)items[i]);  
                var s =  listEq[i].equipSlot.ToString();
                if (listEq[i].equipSlot == EquipmentSlot.Weapon)
                {
                    listEq[i].prefab = Resources.Load<GameObject>("Weapon/" + items[i].name);
                }
                else
                {
                    listEq[i].mesh = Resources.Load<SkinnedMeshRenderer>(s+"/" + items[i].name);
                }
            }
            
        }
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
                //upgradeItems.Add(item);
                // 
                for (int i = 0; i < EconomyManager.instance.itemList.Count; i++)
                {
                    if (EconomyManager.instance.itemList[i] == item)
                    {
                        EconomyManager.instance.itemCount[i]++;
                    }
                }
            }
            else
            {
                if (items.Contains(item))
                {
                   int index =  items.FindIndex(r => r.name.Contains(item.name));
                   itemsCount[index]++;
                }
                else
                {
                    items.Add(item);
                    itemsCount.Add(1);
                }
               
                
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
        int index = items.FindIndex(r => r.name.Contains(item.name));
        if (itemsCount[index] > 1)
        {
            itemsCount[index]--;
        }
        else
        {
            items.RemoveAt(index);
            itemsCount.RemoveAt(index);
        }
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
        ES3.Save("itemCount",EconomyManager.instance.itemCount);
        ES3.Save("InvItemCount",itemsCount);
        Debug.Log("Saved");
        
    }
    
    
}
