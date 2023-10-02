using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [Header("Player Button")] 
    public Button JumpBtn;
    public ButtonType[] ButtonType;
    public static UiManager instance;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
    }
}

[Serializable]
public class ButtonType
{
    public SkillType mySkillType;
    public Button skillButton;
}