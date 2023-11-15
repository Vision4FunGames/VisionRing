using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EconomyManager : MonoBehaviour
{
    public static EconomyManager instance;

    private void Awake()
    {
        instance = this;
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
        UiManager.instance.onEconomyChangedCallBack.Invoke();
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

    private void LoadItem()
    {
        for (int i = 0; i < Inventory.instance.upgradeItems.Count; i++)
        {
            
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
