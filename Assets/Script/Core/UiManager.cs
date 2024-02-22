using System;
using System.Collections.Generic;
using AeLa.EasyFeedback;
using Exoa.TutorialEngine;
using GameAnalyticsSDK;
using MoreMountains.Tools;
using PixelCrushers.QuestMachine;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.Video;

public class UiManager : MonoBehaviour
{
    [Header("Player Button")] public Button JumpBtn;
    public ButtonType[] ButtonType;
    public static UiManager instance;

    [Header("UI Objects")] public GameObject gamePlay,
        inventory,
        currentItems,
        blacksmithPanel,
        shopPanel,
        equipmentPanel,
        magicianPanel,
        armorFilter,
        gunFilter,
        deadPanel,
        skillPanel,
        goldPanel,
        contentPanel,
        playerHealthBarCanvas,
        navigationArea,
        settingPanel;

    public GameObject focusPanel;
    public CanvasGroup CanvasGroup;
    public float canvasTime;
    public GameObject ringBtn;
    public TextMeshProUGUI healText;
    public GameObject menuUi;
    [Header("Skill Buttons")] public Button[] skillButtons;
    private InventoryUI inventoryUi;
    private ShopUI shopUI;
    public GameObject inventoryObject;
    public GameObject mapCloseBtn;
    public GameObject mapOpenBtn;
    [HideInInspector] public float dashCoolDownLast, rotateFireLast, earthquickLast, flameTLastQuick;

    public MMProgressBar playerProgressBar;
    public FixedJoystick attackJoystick;
    public Sprite[] itemlevelSprites45;
    public Sprite[] itemLevelSprites;
    public Sprite[] itemDescriptionSprites;
    public Sprite[] skillBGSprites;
    public Sprite emptySprite = null;
    public Material skillMaterial;

    [Header("Economy ")] public TextMeshProUGUI diamondText, gemText, goldText;

    //Chest Scroll
    public GameObject caseScroll;
    public GameObject chestPanel;
    public GameObject selectedPouch;
    public List<GameObject> UiPanels = new List<GameObject>();
    public GameObject collectBtn;
    public GameObject upgradeWheel;

    public GameObject inventoryBtnPanel, shopBtnPanel;

    [SerializeField] private SkillUpgrade skillUpgrade;

    //Economy
    public TextMeshProUGUI contentText;

    [Header("Image")] public RawImage foxRaw;
    [Header("Chapters")] public VideoPlayer chapter1;
    public VideoPlayer chapter3;
    public VideoPlayer endVideo;

    public delegate void OnEconomyChanged();

    public OnEconomyChanged onEconomyChangedCallBack;

    [Header("ItemCollect")] public GameObject itemTextPanel;
    private bl_MiniMap _blMiniMap;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        _blMiniMap = FindObjectOfType<bl_MiniMap>();
        inventoryUi = InventoryUI.instance;
        shopUI = global::ShopUI.instance;
        inventory.SetActive(false);
        gamePlay.SetActive(true);
        onEconomyChangedCallBack += EconomyUI;
        onEconomyChangedCallBack.Invoke();
    }

    public void DisableButton()
    {
        for (int i = 0; i < ButtonType.Length; i++)
        {
            ButtonType[i].skillButton.enabled = false;
        }
    }
   
    public void EnableButton()
    {
        for (int i = 0; i < ButtonType.Length; i++)
        {
            ButtonType[i].skillButton.enabled = true;
        }
    }

    public void MapOpen()
    {
        _blMiniMap.GetMiniMapSize();
        var ui = _blMiniMap.MiniMapUI;
        if (ui != null)
        {
            ui.root.anchoredPosition = _blMiniMap.FullMapPosition;
            ui.root.sizeDelta = _blMiniMap.FullMapSize;
            ui.root.eulerAngles = _blMiniMap.FullMapRotation;
            ui.minimapMaskManager?.ChangeMaskType(true);
        }

        _blMiniMap._isPreviewFullscreen = true;
        mapCloseBtn.SetActive(true);
        mapOpenBtn.SetActive(false);
    }

    public void MapClose()
    {
        var ui = _blMiniMap.MiniMapUI;
        if (ui != null)
        {
            ui.root.anchoredPosition = _blMiniMap.MiniMapPosition;
            ui.root.sizeDelta = _blMiniMap.MiniMapSize;
            ui.root.eulerAngles = _blMiniMap.MiniMapRotation;
            ui.minimapMaskManager?.ChangeMaskType(false);
        }

        _blMiniMap._isPreviewFullscreen = false;
        mapCloseBtn.SetActive(false);
        mapOpenBtn.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            EconomyManager.instance.SetGold(5000);
        }

        if (chapter1.frame + 5 >= (long)chapter1.frameCount && chapter1.gameObject.activeSelf)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Cinematic", "Cinematic02");
            chapter1.gameObject.SetActive(false);
        }

        if (chapter3.frame + 5 >= (long)chapter3.frameCount && chapter3.gameObject.activeSelf)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Cinematic", "Cinematic03");
            GetComponent<SoundManager>().mainMusicSource.volume = GetComponent<SoundManager>().mainMusicVolume.value;
            chapter3.gameObject.SetActive(false);
        }
        
    }

    public void MenuUI()
    {
        CloseAllUI();
        OpenUI(inventory);
        OpenUI(menuUi);
        // inventory.gameObject.SetActive(true);
        // menuUi.gameObject.SetActive(true);
    }

    public void ShopUI()
    {
        QuestMachineMessages.SendCompositeMessage(this, "Meet:Merchant");
        if (GameManager.instance.isMerchant)
        {
            CloseAllUI();
            Invoke("OpenUI", canvasTime);

            OpenUI(shopPanel);
            OpenUI(equipmentPanel);
            OpenUI(inventory);
            OpenUI(inventoryObject);
            OpenUI(goldPanel);
            OpenUI(contentPanel);

            inventoryUi.UpdateUI();
            shopUI.UpdateShop();
            onEconomyChangedCallBack.Invoke();
            contentText.text = "SHOP";
        }
        else
        {
            CloseAllUI();
            Invoke("OpenUI", canvasTime);
            OpenUI(shopPanel);
            OpenUI(equipmentPanel);
            OpenUI(inventory);
            OpenUI(inventoryObject);
            OpenUI(goldPanel);
            OpenUI(contentPanel);
            inventoryUi.UpdateUI();
            shopUI.UpdateShop();
            onEconomyChangedCallBack.Invoke();
            contentText.text = "SHOP";
            GameManager.instance.isMerchant = true;
            TutorialLoader.instance.Load("Merchant");
            PlayerPrefs.SetInt("Merchant", 1);
        }
    }

    private void FeedBackOpen()
    {
       FindObjectOfType<FeedbackForm>().Show();
    }

    public void FeedBackOpenWait()
    {
        Invoke("FeedBackOpen",.5f);
    }
    public void FocusMode(GameObject switchOnClick)
    {
        if (focusPanel.gameObject.activeSelf)
        {
            focusPanel.gameObject.SetActive(false);
            switchOnClick.gameObject.SetActive(true);
        }
        else
        {
            switchOnClick.gameObject.SetActive(false);
            focusPanel.gameObject.SetActive(true);
        }
    }

    public void ShowInventory()
    {
        CloseAllUI();

        contentText.text = "INVENTORY";
        OpenUI(currentItems);
        OpenUI(equipmentPanel);
        OpenUI(inventory);
        OpenUI(inventoryObject);
        OpenUI(goldPanel);
        OpenUI(contentPanel);
        Inventory.instance.InventoryTypeChange(InventoryType.Inventory);
        inventoryUi.ShowSelected("All");
        inventoryUi.UpdateUI();
        onEconomyChangedCallBack.Invoke();
    }

    public void SettingUI()
    {
        CloseAllUI();

        Invoke("OpenUI", canvasTime);
        OpenUI(inventory);
        OpenUI(settingPanel);
    }

    public void BlackSmithUI()
    {
        CloseAllUI();

        Invoke("OpenUI", canvasTime);
        OpenUI(inventory);
        OpenUI(blacksmithPanel);
        OpenUI(equipmentPanel);
        OpenUI(inventoryObject);
        OpenUI(contentPanel);
        OpenUI(goldPanel);
        Inventory.instance.InventoryTypeChange(InventoryType.Upgrade);
        inventoryUi.UpdateUI();
        contentText.text = "BLACKSMITH";
        if (!GameManager.instance.isBlacksmith)
        {
            TutorialLoader.instance.Load("Blacksmith");
            PlayerPrefs.SetInt("Blacksmith", 1);
            GameManager.instance.isBlacksmith = true;
        }
    }

    public void MagicianUI()
    {
        if (GameManager.instance.isMagician &&
            GameManager.instance.magician.GetComponent<QuestGiver>().GetOfferableQuests().Count == 0)
        {
            CloseAllUI();
            Invoke("OpenUI", canvasTime);
            OpenUI(inventory);
            OpenUI(magicianPanel);
            OpenUI(contentPanel);
            OpenUI(goldPanel);
            contentText.text = "MAGICIAN";
            Inventory.instance.onItemChangedCallback?.Invoke();
            skillUpgrade.onSkillShopChangeCallBack?.Invoke();
            //navigationArea.gameObject.SetActive(true);
            //skillUpgrade.BringCurrentSkills();
        }
        else
        {
            if (GameManager.instance.magician.GetComponent<QuestGiver>().GetOfferableQuests().Count == 0 &&
                GameManager.instance.magician.GetComponent<QuestGiver>().GetActiveQuests().Count == 0)
            {
                CloseAllUI();
                Invoke("OpenUI", canvasTime);
                OpenUI(inventory);
                OpenUI(magicianPanel);
                OpenUI(contentPanel);
                OpenUI(goldPanel);
                contentText.text = "MAGICIAN";
                Inventory.instance.onItemChangedCallback?.Invoke();
                skillUpgrade.onSkillShopChangeCallBack?.Invoke();
                // navigationArea.gameObject.SetActive(true);
                TutorialLoader.instance.Load("Magician");
                PlayerPrefs.SetInt("Magician", 1);
                GameManager.instance.isMagician = true;
            }

            else
            {
                GameManager.instance.magician.GetComponent<QuestGiver>().StartDialogueWithPlayer();
            }
        }
    }

    public void SkillUI()
    {
        CloseAllUI();
        Invoke("OpenUI", canvasTime);
        OpenUI(inventory);
        OpenUI(skillPanel);
        OpenUI(contentPanel);
        OpenUI(goldPanel);
        //navigationArea.gameObject.SetActive(true);
        contentText.text = "SKILLS";
        SkillPanel.instance.onSkillUseChangeCallBack.Invoke();
    }

    public void SceneChange()
    {
        // sceneUI.gameObject.SetActive(true);
        // sceneUI.transform.GetChild(0).transform.localScale = new Vector3(0, 0, 0);
        // sceneUI.transform.GetChild(0).transform.DOScale(20f, 5f);
        // GameManager.instance.RestartGame();
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Cinematic", "Cinematic02");
        ringBtn.gameObject.SetActive(false);
        chapter1.gameObject.SetActive(true);

        Invoke("AfterVideoOpen", 2);
    }

    public void AfterVideoOpen()
    {
        Player.instance.tutorial = false;
        Player.instance.GetComponent<NavMeshAgent>().enabled = false;
        PlayerPrefs.SetInt("StartVillage", 0);
        Player.instance.transform.position = GameManager.instance.tutorial1SpawnPos.transform.position;
        PlayerManager.instance.pet.GetComponent<NavMeshAgent>().enabled = false;
        PlayerManager.instance.pet.transform.position = Player.instance.transform.position + new Vector3(5f, 0, 0);
        PlayerManager.instance.pet.GetComponent<NavMeshAgent>().enabled = true;
        GameManager.instance.tutorialSection = 1;
        GameManager.instance.tutorialCounter = 0;
        GameManager.instance.seaWater.transform.localPosition = new Vector3(89.502594f, -31f, -113.304504f);
        Invoke("LoadTuto", 3f);

        Player.instance.TurnB();
    }

    private void LoadTuto()
    {
        GameManager.instance.TutorialLoad();
    }

    public void CloseAllUI()
    {
        for (int i = 0; i < UiPanels.Count; i++)
        {
            // UiPanels[i].gameObject.SetActive(false);
            var tweener = UiPanels[i].gameObject.GetComponent<CanvasGroupTweener>();
            if (tweener != null)
            {
                tweener.Close();
            }
            else
            {
                UiPanels[i].gameObject.SetActive(false);
            }
        }
    }

    public void OpenUI(GameObject gameObject)
    {
        var tweener = gameObject.GetComponent<CanvasGroupTweener>();
        if (tweener != null)
        {
            tweener.Open();
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
        OpenUI(gamePlay);
        OpenUI(playerHealthBarCanvas);
    }

    public void ChestPanelUI()
    {
        CloseAllUI();
        OpenUI(inventory);
        OpenUI(chestPanel);
    }

    public void CollectButtonOpen()
    {
        collectBtn.gameObject.SetActive(true);
    }

    public void EconomyUI()
    {
        goldText.text = EconomyManager.instance.GetGold().ToString();
        diamondText.text = EconomyManager.instance.GetDiamond().ToString();
        gemText.text = EconomyManager.instance.GetGem().ToString();
    }

    public void InventoryFilter(String type)
    {
        if (type == "Gun")
        {
            armorFilter.gameObject.SetActive(false);
            gunFilter.gameObject.SetActive(true);
        }
        else if (type == "Armor")
        {
            armorFilter.gameObject.SetActive(true);
            gunFilter.gameObject.SetActive(false);
        }
        else
        {
            armorFilter.gameObject.SetActive(false);
            gunFilter.gameObject.SetActive(false);
        }
    }

    public void DeadUI()
    {
        deadPanel.gameObject.SetActive(true);
    }
}

[Serializable]
public class ButtonType
{
    public SkillType mySkillType;
    public Button skillButton;
}