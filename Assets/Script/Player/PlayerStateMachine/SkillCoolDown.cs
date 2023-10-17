using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCoolDown : MonoBehaviour
{
    [HideInInspector] public List<Image> _skillImages;
    [HideInInspector] public List<Skills> _currentSkills;
    public Skills[] skillsArray;
    public static SkillCoolDown instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < skillsArray.Length; i++)
        {
            skillsArray[i].coolDownTime = skillsArray[i].coolDown;

            for (int j = 0; j < UiManager.instance.ButtonType.Length; j++)
            {
                if (UiManager.instance.ButtonType[j].mySkillType.ToString() == skillsArray[i].skillName)
                {
                    skillsArray[i].skillImage = Resources.Load<Sprite>("SkillSprite/" + skillsArray[i].skillName);
                    UiManager.instance.ButtonType[j].skillButton.transform.GetChild(0).GetChild(0).GetComponent<Image>()
                            .sprite =
                        skillsArray[i].skillImage;
                    UiManager.instance.ButtonType[j].skillButton.transform.GetChild(1).GetComponent<Image>().sprite =
                        skillsArray[i].skillImage;
                    _skillImages.Add(UiManager.instance.ButtonType[j].skillButton.transform.GetChild(0)
                        .GetComponent<Image>());
                    _currentSkills.Add(skillsArray[i]);
                }
            }
        }
    }

    private void Update()
    {
        CoolDownImage();
    }

    public bool CanUse(int skillindex)
    {
        return skillsArray[skillindex].coolDownTime <= 0;
    }

    public void CoolDownImage()
    {
        for (int i = 0; i < _currentSkills.Count; i++)
        {
            _currentSkills[i].coolDownTime -= Time.deltaTime;
            float fillAmount = 1 - (_currentSkills[i].coolDownTime / _currentSkills[i].coolDown);
            _skillImages[i].fillAmount = fillAmount;
        }
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