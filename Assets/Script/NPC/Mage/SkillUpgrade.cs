using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SkillUpgrade : MonoBehaviour
{
    private SkillCoolDown _skillCoolDown;
    public GameObject shopParent,shopSlot;
    public GameObject itemSlot;
    public GameObject necessaryParent;
    private void Start()
    {
        _skillCoolDown = SkillCoolDown.instance;
    }

    public void BringSkills()
    {
        var currentSkills = _skillCoolDown._currentSkills;
        for (int i = 0; i < _skillCoolDown._currentSkills.Count; i++)
        {
            var currentSlot = Instantiate(shopSlot, shopParent.transform);


            var skillBuySlot = currentSlot.GetComponent<SkillBuySlot>();
            
            if (_skillCoolDown._currentSkills[i].skillLevel< UiManager.instance.itemlevelSprites.Length)
            {
                //Our Current Skill
                skillBuySlot.skillSlot1.GetComponent<InventorySlot>().icon.sprite = _skillCoolDown._currentSkills[i].skillImage;
                skillBuySlot.skillSlot1.GetComponent<InventorySlot>().backGImage.sprite =
                    UiManager.instance.itemlevelSprites[_skillCoolDown._currentSkills[i].skillLevel];
                //Upgrade Skill
                skillBuySlot.skillSlot2.GetComponent<InventorySlot>().icon.sprite = _skillCoolDown._currentSkills[i].skillImage;
                skillBuySlot.skillSlot2.GetComponent<InventorySlot>().backGImage.sprite =
                    UiManager.instance.itemlevelSprites[_skillCoolDown._currentSkills[i].skillLevel+1];

                int currentSkillLevel = currentSkills[i].skillLevel;
                var itemList = currentSkills[i].necessariesName[currentSkillLevel].ItemList;
                var itemCount = currentSkills[i].necessariesName[currentSkillLevel].itemCount;
                for (int j = 0; j < itemList.Count; j++)
                {
                    var necessaryItem = Instantiate(skillBuySlot.itemSlot, skillBuySlot.necessaryParent.transform);
                    necessaryItem.GetComponent<InventorySlot>().AddItem(itemList[j]);
                    necessaryItem.GetComponentInChildren<TextMeshProUGUI>().text = "X/ " + itemCount[j];
                }
               
                    
            }
        }
            
           
    }
}