using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    
    #region Singleton
    public static ShopUI instance;
    private string type = "All";
    
    void Awake ()
    {
        instance = this;
    }
    #endregion
    
    public GameObject shopUI;	// The entire UI
    public Transform itemsParent;

    private Shop shop;
    List<Equipment> listEq = new List<Item>().Cast<Equipment>().ToList();
    void Start()
    {
        shop = Shop.instance;
        shop.onItemChangedCallback += UpdateShop;
        UpdateShop();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateShop()
    {
        int counter = 0;
        ConvertToEquipmentList();
        InventorySlot[] slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        ShopSlot[] shopSlots = itemsParent.GetComponentsInChildren<ShopSlot>();
        switch (type)
        { 
            case "All":
                ClearAllSlots();
                counter = 0;
                Debug.Log("ALL");
                for (int i = 0; i < slots.Length; i++)
                {
                    if (i < shop.shopItems.Count)
                    {
                        slots[i].AddItem(shop.shopItems[i]);
                        shopSlots[i].AddItem(listEq[i]);
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
                    if ((i < shop.shopItems.Count) && (listEq[i].equipSlot == EquipmentSlot.Body))
                    {
                            slots[counter].AddItem(shop.shopItems[i]);
                            counter++;
                    } 
                }
                break;
            case "Sword":
                ClearAllSlots();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if ((i < shop.shopItems.Count) && (listEq[i].equipSlot == EquipmentSlot.Weapon))
                    {
                        slots[counter].AddItem(shop.shopItems[i]);
                        counter++;
                    } 
                }
                break;
            case "Shoes":
                ClearAllSlots();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if ((i <shop.shopItems.Count) && (listEq[i].equipSlot == EquipmentSlot.Feet))
                    {
                        slots[counter].AddItem(shop.shopItems[i]);
                        counter++;
                    } 
                }
                break;
            case "Head":
                ClearAllSlots();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if ((i < shop.shopItems.Count) && (listEq[i].equipSlot == EquipmentSlot.Head))
                    {
                        slots[counter].AddItem(shop.shopItems[i]);
                        counter++;
                    } 
                }
                break;
            case "Potion":
                break;
        }
    }

    private void ClearAllSlots()
    {
        InventorySlot[] slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].ClearSlot();
        }
    }
    
    public void ConvertToEquipmentList()
    {
        listEq.Clear();
        for (int i = 0; i < shop.shopItems.Count; i++)
        {
            listEq.Add((Equipment)shop.shopItems[i]);
        }
    }
    public void ShowSelected(string selected)
    {
        type = selected;
        UpdateShop();
        type = "All";
        
    }
}
