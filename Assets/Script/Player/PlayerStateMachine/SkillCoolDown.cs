using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        }
    }

    private void Update()
    {
        for (int i = 0; i < _SkillsArray.Length; i++)
        {
            _SkillsArray[i].coolDownTime -= Time.deltaTime;
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
    public UnityEngine.UI.Image skillImage;
}