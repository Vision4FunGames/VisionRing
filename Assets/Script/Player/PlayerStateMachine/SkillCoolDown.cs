using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SkillCoolDown : MonoBehaviour
{
    public List<Image> _skillImages;
    public List<Skills> _currentSkills;
    public Skills[] skillsArray;
    public static SkillCoolDown instance;

    public delegate void onSkillChange();
    
    public onSkillChange onSkillChangeCallBack;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        
        onSkillChangeCallBack += UpdateSkillButton;
        for (int i = 0; i < skillsArray.Length; i++)
        {
            skillsArray[i].skillImage = Resources.Load<Sprite>("SkillSprite/" + skillsArray[i].skillName);
        }
    }

    private void Update()
    {
        CoolDownImage();
    }

    public bool CanUse(int skillindex)
    {
        Debug.Log(skillindex + " Index");
        return skillsArray[skillindex].coolDownTime <= 0;
    }

    public void CoolDownImage()
    {
        if (skillsArray[0].coolDownTime > 0)
            skillsArray[0].coolDownTime -= Time.deltaTime;
        for (int i = 0; i < _currentSkills.Count; i++)
        {
            if ( _currentSkills[i].coolDownTime > 0)
            {
                _currentSkills[i].coolDownTime -= Time.deltaTime;
                float fillAmount = 1 - (_currentSkills[i].coolDownTime / _currentSkills[i].coolDown);
                _skillImages[i].fillAmount = fillAmount;
            }
        }
        
    }

    public void UpdateSkillButton()
    {
        
        for (int i = 0; i < _currentSkills.Count; i++)
        {
            UiManager.instance.ButtonType[i].skillButton.gameObject.SetActive(true);
            switch (_currentSkills[i].skillName)
            {
                case "FireRotate":
                    UiManager.instance.ButtonType[i].mySkillType = SkillType.FireRotate;
                    break;
                case "EarthQ":
                    UiManager.instance.ButtonType[i].mySkillType = SkillType.EarthQ;
                    break;
                case "FlameT":
                    UiManager.instance.ButtonType[i].mySkillType = SkillType.FlameT;
                    break;
                case "Tornado":
                    UiManager.instance.ButtonType[i].mySkillType = SkillType.Tornado;
                    break;
                case "Sword":
                    UiManager.instance.ButtonType[i].mySkillType = SkillType.Sword;
                    break;
                case "ArrowRain":
                    UiManager.instance.ButtonType[i].mySkillType = SkillType.ArrowRain;
                    break;
                case "Shield":
                    UiManager.instance.ButtonType[i].mySkillType = SkillType.Shield;
                    break;
                case "Clone":
                    UiManager.instance.ButtonType[i].mySkillType = SkillType.Clone;
                    break;

            }
         
            UiManager.instance.ButtonType[i].skillButton.transform.GetChild(0).GetChild(0).GetComponent<Image>()
                    .sprite =
                _currentSkills[i].skillImage;
            UiManager.instance.ButtonType[i].skillButton.transform.GetChild(1).GetComponent<Image>().sprite =
                _currentSkills[i].skillImage;
            _skillImages.Add(UiManager.instance.ButtonType[i].skillButton.transform.GetChild(0)
                .GetComponent<Image>());
            if (_currentSkills.Count > 3)
            {
                return;
            }
        }
    }
}

[Serializable]
public class Skills
{
    public string skillName;
    public float coolDown;
    public float coolDownTime;
    [HideInInspector] public Sprite skillImage;
    public int skillLevel;
    public SkillNecessary[] necessariesName;
}


// public partial class SkillNecessary : ScriptableObject
// {
//     public List<Equipment> ItemList;
//     public List<int> itemCount;
//     
//   
//    
// }