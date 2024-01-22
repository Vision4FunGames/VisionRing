using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EconomyManager : MonoBehaviour
{
    public static EconomyManager instance;
    private ShopSlot[] shopSlot;
    private void Awake()
    {
        instance = this;
        shopSlot = GetComponents<ShopSlot>();
    }
    

    [Header("Items")] public List<Item> itemList = new List<Item>();
    public List<int> itemCount = new List<int>();

    [SerializeField]
    private int diamond { get; set; }
    private int coin { get; set; }
    private int gold { get; set; }

    public void setDiamond(int count)
    {
        diamond += count;
        UiManager.instance.diamondText.text = diamond.ToString();
    }

    public int GetDiamond()
    {
        int index = 0;
        for (int i = 0; i < itemList.Count; i++)
        {
            index = itemList.FindIndex(r => r.name.Contains("Diamond"));
            
        }
        diamond = itemCount[index]; 
        return diamond;
    }

    public int GetGem()
    {
        return coin;
    }

    public int GetGold()
    {
        return gold;
    }

    public void SetGold(int count)
    {
        gold += count;
        print(count + "Earned");
        UiManager.instance.onEconomyChangedCallBack.Invoke();
        Shop.instance.onItemChangedCallback.Invoke();
        PlayerPrefs.SetInt("gold",gold);
    }
    public void SetCoin(int count)
    {
        coin += count;
        UiManager.instance.onEconomyChangedCallBack.Invoke();
        PlayerPrefs.SetInt("coin",coin);
    }

    public void SetDiamond(int count)
    {
        diamond += count;
        UiManager.instance.onEconomyChangedCallBack.Invoke();
        PlayerPrefs.SetInt("diamond", diamond);
    }
    void Start()
    {
        LoadEconomy();
       
    }

    public void EarnItem(int index,int itemCount)
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            if (i == index)
            {
                this.itemCount[i] += itemCount;
            }
        }
    }

    public void EarnUpgradeItem(UpgradeItem upgradeItem)
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            if (itemList[i].name == upgradeItem.name)
            {
                itemCount[i]++;
            }
        }
    }
    private void LoadEconomy()
    {
        if (PlayerPrefs.HasKey("gold"))
        {
            gold = PlayerPrefs.GetInt("gold");
        }

        if (PlayerPrefs.HasKey("dimond"))
        {
            diamond = PlayerPrefs.GetInt("diamond");
        }

        if (PlayerPrefs.HasKey("coin"))
        {
            coin = PlayerPrefs.GetInt("coin");
        }
        
    }

    public void SpendItems(List<UpgradeItem> itemList,List<int> itemCount)
    {
       
        for (int i = 0; i < itemList.Count; i++)
        {
            for (int j = 0; j < this.itemList.Count; j++)
            {
                if (this.itemList[j] == itemList[i])
                {
                    this.itemCount[j] -= itemCount[i];
                    break;
                }
            }
        }
        ES3.Save("itemCount",itemCount);
    }

    public int GetGemAmount(int level) => level * 50;

    public void EarnRewards()
    {
        EarnItem(0,30);
        EarnItem(1,30);
        EarnItem(2,30);
    }
}
