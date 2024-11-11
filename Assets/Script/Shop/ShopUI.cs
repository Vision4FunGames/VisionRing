using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    #region Singleton

    public static ShopUI instance;
    private string type = "All";
    private InventorySlot[] slots;
    private ShopSlot[] shopSlots;

    void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject shopUI; // The entire UI
    public Transform itemsParent;

    private Shop shop;
    List<Equipment> listEq = new List<Item>().Cast<Equipment>().ToList();
    List<Equipment> listUp = new List<UpgradeItem>().Cast<Equipment>().ToList();
    private MapMaskManager map;

    void Start()
    {
        shop = Shop.instance;
        shop.onItemChangedCallback += UpdateShop;
        map = GameManager.instance.GetComponentInChildren<MapMaskManager>();
        UpdateShop();
    }

    public void UpdateShop()
    {
        int counter = 0;
        ClearAllSlots();
        ConvertToEquipmentList();
        AllSlotsShow();
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        shopSlots = itemsParent.GetComponentsInChildren<ShopSlot>();
        switch (type)
        {
            case "All":
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if (i < shop.shopItems.Count &&
                        map.currentMapLevel == listEq[i].mapLevel) //Current Level == shopItems[i].mapLevel;
                    {
                        slots[i].AddItem(shop.shopItems[i]);
                        shopSlots[i].AddItem(listEq[i]);
                        shopSlots[i].index = i;
                        shopSlots[i].onSpendMoneyChanged.Invoke();
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
                    if ((i < shop.shopItems.Count) && (listEq[i].equipSlot == EquipmentSlot.Body) &&
                        map.currentMapLevel == listEq[i].mapLevel)
                    {
                        shopSlots[i].AddItem(listEq[i]);
                        shopSlots[i].index = i;
                        slots[i].AddItem(shop.shopItems[i]);
                        shopSlots[i].onSpendMoneyChanged.Invoke();
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
                    if ((i < shop.shopItems.Count) && (listEq[i].equipSlot == EquipmentSlot.Weapon) &&
                        map.currentMapLevel == listEq[i].mapLevel)
                    {
                        shopSlots[i].AddItem(listEq[i]);
                        shopSlots[i].index = i;
                        slots[i].AddItem(shop.shopItems[i]);
                        shopSlots[i].onSpendMoneyChanged.Invoke();
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
                    if ((i < shop.shopItems.Count) && (listEq[i].equipSlot == EquipmentSlot.Feet) &&
                        map.currentMapLevel == listEq[i].mapLevel)
                    {
                        shopSlots[i].AddItem(listEq[i]);
                        shopSlots[i].index = i;
                        slots[i].AddItem(shop.shopItems[i]);
                        shopSlots[i].onSpendMoneyChanged.Invoke();
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
                    if ((i < shop.shopItems.Count) && (listEq[i].equipSlot == EquipmentSlot.Head) &&
                        map.currentMapLevel == listEq[i].mapLevel)
                    {
                        shopSlots[i].AddItem(listEq[i]);
                        shopSlots[i].index = i;
                        slots[i].AddItem(shop.shopItems[i]);
                        shopSlots[i].onSpendMoneyChanged.Invoke();
                        counter++;
                    }
                    else
                    {
                        shopSlots[i].gameObject.SetActive(false);
                    }
                }

                break;
            case "Potion":
                ClearAllSlots();
                AllSlotsShow();
                counter = 0;
                for (int i = 0; i < slots.Length; i++)
                {
                    if ((i < shop.shopItemsUp.Count))

                    {
                        shopSlots[i].AddItem(listUp[i]);
                        shopSlots[i].index = i;
                        slots[i].AddItem(shop.shopItems[i]);
                        shopSlots[i].onSpendMoneyChanged.Invoke();
                        counter++;
                    }
                    else
                    {
                        shopSlots[i].gameObject.SetActive(false);
                    }
                }

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
        listUp.Clear();
        for (int i = 0; i < shop.shopItems.Count; i++)
        {
            if (shop.shopItems.Count > i)
                listEq.Add((Equipment)shop.shopItems[i]);
            else
            {
                listUp.Add((Equipment)shop.shopItems[i]);
            }
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
        //type = "All";
    }

    public void SelectedButton(GameObject btn)
    {
        var color = btn.GetComponent<Image>().color;
        btn.GetComponent<Image>().color = new Color(color.r, color.g, color.b, 255f);
    }
}