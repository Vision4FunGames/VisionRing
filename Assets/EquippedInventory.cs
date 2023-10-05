using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquippedInventory : MonoBehaviour
{
    #region Singleton

    public static EquippedInventory instance;
	
    void Awake()
    {
        instance = this;
    }

    #endregion

    public List<Item> CurrentItems = new List<Item>();
    public Item[] currentItemss;
    public delegate void OnItemChanged();

    public OnItemChanged onItemChangedCallback;
    private EquipmentManager equipmentManager;

    private void Start()
    {
	    equipmentManager = EquipmentManager.instance;
	   
    }

    public void Add(Equipment newItem)
    {
	    int slotIndex = (int)newItem.equipSlot;
	    CurrentItems[slotIndex] = newItem;
        
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
       // UpdateCurrentItemInventory();
    }
    
    public void Remove(Equipment item)
    {
	    int slotindex = (int)item.equipSlot;
	    CurrentItems[slotindex] = null;
	    if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
       // UpdateCurrentItemInventory();
    }
    
  
}