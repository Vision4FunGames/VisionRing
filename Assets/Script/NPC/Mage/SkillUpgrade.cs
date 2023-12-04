using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class SkillUpgrade : MonoBehaviour
{
    private SkillCoolDown _skillCoolDown;
    public GameObject shopParent,shopSlot;
    public GameObject itemSlot;
    public GameObject necessaryParent;
    public delegate void onSkillShopChange();
    public onSkillShopChange onSkillShopChangeCallBack; 
    private void Start()
    {
        _skillCoolDown = SkillCoolDown.instance;
        onSkillShopChangeCallBack += UpdateSkillShop;
        ShopAddSlot();
    }
    public void ShopAddSlot()
    {
        for (int i = 0; i < _skillCoolDown.skillsArray.Length-1; i++)
        {
            Instantiate(shopSlot, shopParent.transform);
        }
        onSkillShopChangeCallBack.Invoke();
    }
    public void UpdateSkillShop()
    {
        SkillBuySlot[] slots = shopParent.GetComponentsInChildren<SkillBuySlot>();
        for (int i = 0; i < slots.Length  ; i++)
        {
            slots[i].Fill(_skillCoolDown.skillsArray[i+1]);
            slots[i].slotIndex = i+1;
        }
    }
    public void BringCurrentSkills()
    {
        if (_skillCoolDown == null)
        {
         _skillCoolDown = SkillCoolDown.instance;
        }
        var currentSkills = _skillCoolDown._currentSkills;
        for (int i = 0; i < _skillCoolDown._currentSkills.Count; i++)
        {
            var currentSlot = Instantiate(shopSlot, shopParent.transform);
            var skillBuySlot = currentSlot.GetComponent<SkillBuySlot>();
            if (_skillCoolDown._currentSkills[i].skillLevel< UiManager.instance.itemlevelSprites.Length)
            {
                //Our Current Skill
                skillBuySlot.skillSlot.GetComponent<InventorySlot>().icon.sprite = _skillCoolDown._currentSkills[i].skillImage;
                skillBuySlot.skillSlot.GetComponent<InventorySlot>().backGImage.sprite = UiManager.instance.itemlevelSprites[_skillCoolDown._currentSkills[i].skillLevel];
               

                int currentSkillLevel = currentSkills[i].skillLevel;
                var itemList = currentSkills[i].necessariesName[currentSkillLevel].ItemList;
                var itemCount = currentSkills[i].necessariesName[currentSkillLevel].itemCount;
                for (int j = 0; j < itemList.Count; j++)
                {
                    var necessaryItem = Instantiate(skillBuySlot.itemSlot, skillBuySlot.necessaryParent.transform);
                    necessaryItem.GetComponent<InventorySlot>().AddItem(itemList[j]);
                    string itemName = itemList[j].name;
                    int count;
                    for (int k = 0; k < EconomyManager.instance.itemList.Count; k++)
                    {
                        if (EconomyManager.instance.itemList[k].name == itemName)
                        {
                            count = EconomyManager.instance.itemCount[k];
                            var tmp = necessaryItem.GetComponentInChildren<TextMeshProUGUI>();
                            tmp.text = count +" / " + itemCount[j];
                            if (count < itemCount[j])
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
        }
    }
    public void BuySkill(SkillBuySlot slot)
    {
        int readyCounter = 0;
        var list = slot.GetItemList();
        var countList = slot.GetItemCount();
        for (int i = 0; i < list.Count; i++)
        {
            int index = EconomyManager.instance.itemList.FindIndex(r => r.name.Contains(list[i].name));
            if (EconomyManager.instance.itemCount[index] >= countList[i])
            {
                readyCounter++;
                Debug.Log("Alindi");
            }
            else
            {
                Debug.LogWarning("Yetersiz");
            }
        }
        if (readyCounter == list.Count)   // Control if enough items 
        {
            // Spend Items here
            EconomyManager.instance.SpendItems(list,countList);
            if (_skillCoolDown.skillsArray[slot.slotIndex].skillLevel == 0)
            {
                if (!_skillCoolDown._currentSkills.Contains(_skillCoolDown.skillsArray[slot.slotIndex]))
                {
                    _skillCoolDown._currentSkills.Add(_skillCoolDown.skillsArray[slot.slotIndex]);
                    _skillCoolDown.skillsArray[slot.slotIndex].skillLevel++;
                }
            }
            else
            {
                _skillCoolDown.skillsArray[slot.slotIndex].skillLevel++;
            }
            _skillCoolDown.onSkillChangeCallBack?.Invoke();
            slot.skillSlot.transform.DOScale(new Vector3(0, 0, 0), .5f)
                .OnComplete(() => slot.skillSlot.transform.DOScale(new Vector3(1, 1, 1), .5f));
            slot.skillSlot.GetComponent<InventorySlot>().backGImage.material = UiManager.instance.skillMaterial;
            onSkillShopChangeCallBack.Invoke();
        }

        ES3.Save("currentSkills", _skillCoolDown._currentSkills);
    }
}