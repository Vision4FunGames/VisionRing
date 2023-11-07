using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

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
                AllSlotsShow();
                counter = 0;
                Debug.Log("ALL");
                for (int i = 0; i < slots.Length; i++)
                {
                    if (i < shop.shopItems.Count)
                    {
                        slots[i].AddItem(shop.shopItems[i]);
                        shopSlots[i].AddItem(listEq[i]);
                    } 
                    else
                    {
                        shopSlots[i].gameObject.SetActive(false);
                    }
                }
                break;
            case "Armor":
                ClearAllSlots();
                AllSlotsShow();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if ((i < shop.shopItems.Count) && (listEq[i].equipSlot == EquipmentSlot.Body))
                    {
                            slots[counter].AddItem(shop.shopItems[i]);
                            counter++;
                    } 
                    else
                    {
                        shopSlots[i].gameObject.SetActive(false);
                    }
                }
                break;
            case "Sword":
                ClearAllSlots();
                AllSlotsShow();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if ((i < shop.shopItems.Count) && (listEq[i].equipSlot == EquipmentSlot.Weapon))
                    {
                        slots[counter].AddItem(shop.shopItems[i]);
                        counter++;
                    }
                    else
                    {
                        shopSlots[i].gameObject.SetActive(false);
                    }
                }
                break;
            case "Shoes":
                ClearAllSlots();
                AllSlotsShow();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if ((i <shop.shopItems.Count) && (listEq[i].equipSlot == EquipmentSlot.Feet))
                    {
                        slots[counter].AddItem(shop.shopItems[i]);
                        counter++;
                    } 
                    else
                    {
                        shopSlots[i].gameObject.SetActive(false);
                    }
                }
                break;
            case "Head":
                ClearAllSlots();
                AllSlotsShow();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if ((i < shop.shopItems.Count) && (listEq[i].equipSlot == EquipmentSlot.Head))
                    {
                        slots[counter].AddItem(shop.shopItems[i]);
                        counter++;
                    } 
                    else
                    {
                        shopSlots[i].gameObject.SetActive(false);
                    }
                }
                break;
            case "Potion":
                break;
        }
    }

    private void AllSlotsShow()
    {
        for (int i = 0; i < itemsParent.childCount; i++)
        {
            itemsParent.GetChild(i).gameObject.SetActive(true);
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
        
        var btnBG = UiManager.instance.shopBtnPanel.GetComponentsInChildren<Button>();
        for (int i = 0; i < btnBG.Length; i++)
        {
            var image = btnBG[i].GetComponent<Image>().color;
            btnBG[i].GetComponent<Image>().color = new Color(image.r, image.g, image.b, 0f);
        }
        type = selected;
        UpdateShop();
        type = "All";
        
    }
    public void SelectedButton(GameObject btn)
    {
        var color = btn.GetComponent<Image>().color;
        btn.GetComponent<Image>().color = new Color(color.r, color.g, color.b, 255f);
    }
}
