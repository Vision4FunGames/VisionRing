using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SkillBuySlot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject skillSlot,contentPanel;
    public GameObject itemSlot;
    public GameObject necessaryParent;
    private List<UpgradeItem> itemlist = new List<UpgradeItem>();
    private List<int> itemCount = new List<int>();
    public int slotIndex;
    private SkillUpgrade skillUpgrade;
    public TextMeshProUGUI buyText;
    
    private void Start()
    {
        skillUpgrade = GetComponentInParent<SkillUpgrade>();
    }

    public void Fill(Skills skill)
    {
        if (skill.skillLevel >5)
        {
            skill.skillLevel = 5;
        }
        skillSlot.GetComponent<InventorySlot>().icon.sprite = skill.skillImage;
        if (skill.skillLevel<= UiManager.instance.itemlevelSprites45.Length)
        {
            skillSlot.GetComponent<InventorySlot>().backGImage.sprite = UiManager.instance.itemlevelSprites45[skill.skillLevel];
        }
       
        if (skill.skillLevel == 0)
        {
            buyText.text = "BUY";
        }
        else if (skill.skillLevel == 5)
        {
            buyText.text = "MAX";
            buyText.transform.parent.gameObject.GetComponent<Button>().enabled = false;
        }
        else
        {
            buyText.text = "UPGRADE";
        }
        
        var necessary = skill.necessariesName[skill.skillLevel];
        itemlist = necessary.ItemList;
         itemCount = necessary.itemCount;
        if (necessaryParent.transform.childCount < itemlist.Count)
        {
            for (int i = 0; i < itemlist.Count; i++)
            {
                var item = Instantiate(itemSlot, necessaryParent.transform);
                item.GetComponent<InventorySlot>().AddItem(itemlist[i]);
            }
            UpdateSlot();
        }
        else
        {
            UpdateSlot();
        }
    }
    public void UpdateSlot()
    {
       for (int i = 0; i < necessaryParent.transform.childCount; i++)
            {
                var item = necessaryParent.transform.GetChild(i);
                string itemName = itemlist[i].name;
                int count;
                for (int k = 0; k < EconomyManager.instance.itemList.Count; k++)
                {
                    if (EconomyManager.instance.itemList[k].name == itemName)
                    {
                        count = EconomyManager.instance.itemCount[k];
                        var tmp = item.GetComponentInChildren<TextMeshProUGUI>();
                        tmp.text = count +" / " + itemCount[i];
                        if (count < itemCount[i])
                        {
                            tmp.color = Color.red;
                        }
                        else
                        {
                            tmp.color = Color.white;
                        }
                        break;
                    }
                }
            } 
    }

    public void BuySkill()
    {
        skillUpgrade.BuySkill(this);
    }

    public List<UpgradeItem> GetItemList()
    {
        return itemlist;
    }

    public List<int> GetItemCount()
    {
        return itemCount;
    }

}
