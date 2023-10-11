using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCoolDown : MonoBehaviour
{
    public Skills[] _SkillsArray;

    public static SkillCoolDown instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < _SkillsArray.Length; i++)
        {
            _SkillsArray[i].coolDownTime = _SkillsArray[i].coolDown;
            for (int j = 0; j < UiManager.instance.ButtonType.Length; j++)
            {
                if (UiManager.instance.ButtonType[j].mySkillType.ToString() == _SkillsArray[i].skillName)
                {
                    UiManager.instance.ButtonType[j].skillButton.transform.GetChild(0).GetComponent<Image>().sprite = _SkillsArray[i].skillImage;
                }
            }
        }

     
    }

    private void Update()
    {
        for (int i = 0; i < _SkillsArray.Length; i++)
        {
            _SkillsArray[i].coolDownTime -= Time.deltaTime;
            float fillAmount = _SkillsArray[i].coolDownTime / _SkillsArray[i].coolDown;
            for (int j = 0; j < UiManager.instance.ButtonType.Length; j++)
            {
                if (UiManager.instance.ButtonType[j].mySkillType.ToString() == _SkillsArray[i].skillName)
                {
                    UiManager.instance.ButtonType[j].skillButton.GetComponent<Image>().fillAmount = fillAmount;
                }
            }
        }
    }

    public bool CanUse(int skillindex)
    {
        return _SkillsArray[skillindex].coolDownTime <= 0;
    }
}

[Serializable]
public class Skills
{
    public string skillName;
    public float coolDown;
    public float coolDownTime;
    public Sprite skillImage;
}