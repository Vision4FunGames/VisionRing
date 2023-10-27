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
    [Header("UI Objects")]
    public GameObject gamePlay, inventory,currentItems,blacksmithPanel,shopPanel,equipmentPanel;

    private InventoryUI inventoryUi;
    public GameObject inventoryObject;
    [HideInInspector] public float dashCoolDownLast, rotateFireLast, earthquickLast, flameTLastQuick;
    public MMProgressBar playerProgressBar;
    public FixedJoystick attackJoystick;
    public Sprite[] itemlevelSprites;
    public Sprite[] itemDescriptionSprites;
    public Sprite emptySprite = null;

    public List<GameObject> UiPanels = new List<GameObject>();
    private void Awake()
    {
        instance = this;
        
    }

    private void Start()
    {
        inventoryUi = InventoryUI.instance;
        inventory.SetActive(false);
        gamePlay.SetActive(true);
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
        Inventory.instance.InventoryTypeChange(InventoryType.Equip);
        inventoryUi.UpdateUI();
    }

    public void BlackSmithUI()
    {
        CloseAllUI();
        
        inventory.gameObject.SetActive(true);
        blacksmithPanel.gameObject.SetActive(true);
        equipmentPanel.gameObject.SetActive(true);
        inventoryObject.gameObject.SetActive(true);
        Inventory.instance.InventoryTypeChange(InventoryType.Upgrade);
        inventoryUi.UpdateUI();
        
    }

    public void CloseAllUI()
    {
        for (int i = 0; i < UiPanels.Count; i++)
        {
            UiPanels[i].gameObject.SetActive(false);
        }
    }
    // public void UpdatePlayerHealthBar(float health)
    // {
    //     playerProgressBar.UpdateBar(health, 0, 100);
    // }

    public void GamePlayUI()
    {
        EquipmentManager.instance.SaveUpgradeItems();
        CloseAllUI();
        gamePlay.gameObject.SetActive(true);
    }
}

[Serializable]
public class ButtonType
{
    public SkillType mySkillType;
    public Button skillButton;
}


