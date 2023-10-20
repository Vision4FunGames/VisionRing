using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [Header("Player Button")] public Button JumpBtn;
    public ButtonType[] ButtonType;
    public static UiManager instance;
    public GameObject gamePlay, inventory;
    private InventoryUI inventoryUi;
    public GameObject inventoryObject;
    [HideInInspector] public float dashCoolDownLast, rotateFireLast, earthquickLast, flameTLastQuick;
    public MMProgressBar playerProgressBar;

    private void Awake()
    {
        instance = this;
        
    }

    private void Start()
    {
        inventoryUi = InventoryUI.instance;
        //inventory.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            ShowInventory();
        }
    }

    public void ShowInventory()
    {
        inventory.SetActive(!inventory.activeSelf);
        inventoryObject.SetActive(!inventoryObject.activeSelf);
        gamePlay.SetActive(!gamePlay.activeSelf);
        inventoryUi.UpdateUI();
    }

    // public void UpdatePlayerHealthBar(float health)
    // {
    //     playerProgressBar.UpdateBar(health, 0, 100);
    // }


}

[Serializable]
public class ButtonType
{
    public SkillType mySkillType;
    public Button skillButton;
}


