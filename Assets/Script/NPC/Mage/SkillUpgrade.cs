using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SkillUpgrade : MonoBehaviour
{
    private SkillCoolDown _skillCoolDown;
    public GameObject shopParent,shopSlot;
    private void Start()
    {
        _skillCoolDown = SkillCoolDown.instance;
    }

    public void BringSkills()
    {
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
                skillBuySlot.skillSlot1.GetComponent<InventorySlot>().icon.sprite = _skillCoolDown._currentSkills[i].skillImage;
                skillBuySlot.skillSlot1.GetComponent<InventorySlot>().backGImage.sprite =
                    UiManager.instance.itemlevelSprites[_skillCoolDown._currentSkills[i].skillLevel+1];
                
                
            }
            
           
        }
    }
}
