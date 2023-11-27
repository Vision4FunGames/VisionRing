using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopSlot : MonoBehaviour
{
    public TextMeshProUGUI priceText;
    public Text firstText, secondText, thirdText;
    public int price;
    public int index;
    private Item currentItem;
    public InventorySlot inveSlot;
    public delegate void onSpendMoney();

    public onSpendMoney onSpendMoneyChanged;
        
    public Image bgImage;
    // Start is called before the first frame update
    private void Awake()
    {
        onSpendMoneyChanged += UpdateButton;
    }
    
    public void AddItem(Equipment newItem)
    {
        currentItem = newItem;
        bgImage.sprite = UiManager.instance.itemDescriptionSprites[newItem.itemLevel];
        price = newItem.price;
        priceText.text = price.ToString();
        UpdateButton();
    }
    public void BuyShopSlot()
    {
        //money condition
        //currentItem?.Use(InventoryType.Buy);
        //Inventory.instance.Add(currentItem);
        if (CheckMoney(price))
        {
            inveSlot.UseItem();
            Shop.instance.shopItems.RemoveAt(index);
           // Destroy(gameObject);
            if (Shop.instance.onItemChangedCallback!= null)
            {
                Shop.instance.onItemChangedCallback.Invoke(); 
                Debug.Log("Invoked");
            }
            else
            {
                ShopUI.instance.UpdateShop();
            }
        }
      
    }

    private bool CheckMoney(int price)
    {
        if (price <= EconomyManager.instance.GetGold())
        {
            EconomyManager.instance.SetGold(-price);
            return true;
        }

        return false;
    }

    public void UpdateButton()
    {
        if (EconomyManager.instance.GetGold() < price)
        {
            priceText.color = Color.red;
        }
        else
        {
            priceText.color = Color.white;
        }
    }
}
