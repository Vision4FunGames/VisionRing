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

    private Item currentItem;

    public Image bgImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(Equipment newItem)
    {
        currentItem = newItem;
        bgImage.sprite = UiManager.instance.itemDescriptionSprites[newItem.itemLevel];
        price = newItem.price;
        priceText.text = price.ToString();
    }
    public void BuyShopSlot()
    {
        //money condition
        //currentItem?.Use(InventoryType.Buy);
        //Inventory.instance.Add(currentItem);
        Destroy(gameObject);
    }
}
