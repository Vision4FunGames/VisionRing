    using System;
using System.Collections;
using Cinemachine;
using DG.Tweening;
using Exoa.TutorialEngine;
using PixelCrushers.QuestMachine;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameAnalyticsSDK;
using NaughtyAttributes;
using UnityEngine.UI;

public enum GameState
{
    Play,
    Pause,
    GameOver,
    Tutorial
}

public class GameManager : MonoBehaviour, IGameAnalyticsATTListener
{
    public GameObject villageSpawnPos;
    public GameObject tutorial1SpawnPos;
    public GameObject tutorialStartPos;
    public static GameManager instance;
    public GameState gameState;
    public static event Action<GameState> onGameStateChanged;
    public string PlayerName;
    public CinemachineVirtualCamera playerVCam;
    public CinemachineVirtualCamera cinematicVCam;
    public CinemachineVirtualCamera foxVCam;
    public CinemachineVirtualCamera coleziumCam;
    public int tutorialCounter = 0;
    public int tutorialSection;
    private string tutorialName;
    public bool tutorial;
    public FoxManager foxManager;
    public GameObject MinimapOriginObj;
    [Header("Tutorial")] public GameObject tutorialEnemies;
    public GameObject fox;
    public GameObject tutoCage;
    public GameObject tutorialWall;
    public GameObject tutorialCollider1, tutorialCollider2, villageEntryCollider;
    public GameObject wallFires;
    public GameObject tutorialBox, tutorialBoxArea;
    public GameObject mainSword;
    public GameObject baskan;
    public GameObject shirley;
    public GameObject merchant;
    public GameObject blacksmith;
    public GameObject magician;
    public GameObject villageDoor, villageDoor2;
    public GameObject colosseum;
    public GameObject tutorialIncreaserFirst;
    public GameObject firstLevelEnemies;
    public GameObject realmChange;
    public GameObject seaWater;
    public GameObject campFire;
    public GameObject tutoVaril;
    public GameObject StonePanel;
    public GameObject playernamePanel;
    [Header("NPC isOpen")] public bool isMerchant;
    public bool isMagician;
    public bool isBlacksmith;
    public bool isRing;
    public bool isHeal;
    public bool isBox;
    public bool isColosseum;
    public bool isDash;
    public bool isDungeon;
    public float currentTime;
    public bool fightBool;
    public AudioClip fight, stand;
    public bool isFoxSaved;
    public bool isCampfire;
    public bool skillTutorial;
    private UnityUIQuestDialogueUI _questDialogueUI;
    private float DisableTimer;
    [Header("QuestTimer")] private QuestManager _questManager;
    public float timerKillTheAttackers;
    public float timerFirstMeeting;
    public float timerMerchant;
    public float timerFindMage;
    public float timerBoss;
    public float timerBoss1;
    public float timerPortal1;
    public float timerPortal2;
    public GameObject SkeletBoss;
    public QuestListContainer _questListContainer;
    private void Awake()
    {
        instance = this;
        Application.targetFrameRate = 60;
        PlayStandSound();

       
        // if (PlayerPrefs.HasKey("TutorialSection"))
        // {
        //     tutorialCounter = 0;
        //     tutorialSection = PlayerPrefs.GetInt("TutorialSection");
        // }

        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            GameAnalytics.Initialize();
        }
        else
        {
            GameAnalytics.Initialize();
        }
        
        //PlayerPrefs.SetInt("Fox", 1);
        if (PlayerPrefs.GetInt("Fox") == 1)
        {
            fox.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Blacksmith") == 1)
        {
            blacksmith.transform.DOScale(Vector3.one, 1);
        }
        // else
        //fox.SetActive(false);
    }

    public void CurrentTutorialComplete()
    {
       
    }
    public void PlayFightSound()
    {
        if (!fightBool)
        {
            GetComponent<AudioSource>().clip = fight;
            GetComponent<AudioSource>().Play();
            fightBool = true;
        }

        currentTime = 0;
    }

    public void PlayStandSound()
    {
        GetComponent<AudioSource>().clip = stand;
        GetComponent<AudioSource>().Play();
    }

    private GameObject teleportPos;
    public void PlayerTeleport(GameObject tpPos)
    {
        teleportPos = tpPos;
        Player.instance.teleportParticle.Play();
        UiManager.instance.MapClose();
        Player.instance._myController.enabled = false;
        Invoke("Teleport",2);
    }

    public void Teleport()
    {
        Player.instance.transform.position = teleportPos.transform.position;
        Player.instance._myController.enabled = true;
        Player.instance.teleportParticle.Stop();
    }
    private void Start()
    {
        Player.instance.transform.position = villageSpawnPos.transform.position;
        // _questManager = GetComponent<QuestManager>();
        //
        //  #region Tutorial
        // //
        // // if (PlayerPrefs.HasKey("TutorialSection"))
        // // {
        // //     tutorialSection = PlayerPrefs.GetInt("TutorialSection");
        // // }
        // //
        // // if (tutorialSection == 1)
        // // {
        // //     // //Quest quest = new Quest(questMachineConfiguration)
        // //     // Player.instance.GetComponent<QuestJournal>()
        // //     //     .AddQuest(questMachineConfiguration.questDatabases[0].questAssets[9]);
        // // }
        // //
        // // if (tutorialSection == 2)
        // // {
        // //     tutorial = true;
        // //     QuestLoad();
        // // }
        // // // else if (magician.GetComponent<QuestGiver>().HasOfferableOrActiveQuest())
        // // // {
        // // //     var questlist = magician.GetComponent<QuestGiver>().questList;
        // // //     for (int i = 0; i < questlist.Count; i++)
        // // //     {
        // // //         if (_questManager.successedQuests.Contains(questlist[i].id.ToString()))
        // // //         {
        // // //             questlist[i].SetState(QuestState.Successful);
        // // //             Debug.Log(questlist[i].id.ToString()+ " Bitirildi ");
        // // //         }
        // // //         else
        // // //         {
        // // //             questlist[i].SetState(QuestState.WaitingToStart);
        // // //             IndicatorDefine(magician);
        // // //             break;
        // // //         }
        // // //     }
        // // // }
        // //
        // // if (PlayerPrefs.HasKey("Blacksmith"))
        // // {
        // //     if (PlayerPrefs.GetInt("Blacksmith") == 1)
        // //     {
        // //         isBlacksmith = true;
        // //     }
        // // }
        // //
        // // if (PlayerPrefs.HasKey("Merchant"))
        // // {
        // //     if (PlayerPrefs.GetInt("Merchant") == 1)
        // //     {
        // //         isMerchant = true;
        // //     }
        // // }
        // //
        // // if (PlayerPrefs.HasKey("Magician"))
        // // {
        // //     if (PlayerPrefs.GetInt("Magician") == 1)
        // //     {
        // //         isMagician = true;
        // //     }
        // // }
        // //
        // // if (PlayerPrefs.HasKey("Ring"))
        // // {
        // //     if (PlayerPrefs.GetInt("Ring") == 1)
        // //     {
        // //         if (gameState != GameState.Tutorial)
        // //         {
        // //             isRing = true;
        // //             UiManager.instance.ringBtn.gameObject.SetActive(true);
        // //             UiManager.instance.ringBtn.GetComponent<Button>().enabled = true;
        // //         }
        // //     }
        // //     else
        // //     {
        // //         UiManager.instance.ringBtn.gameObject.SetActive(false);
        // //     }
        // // }
        // //
        // // if (PlayerPrefs.HasKey("FirstEnemies"))
        // // {
        // //     if (PlayerPrefs.GetString("FirstEnemies") == "True")
        // //     {
        // //         firstLevelEnemies.gameObject.SetActive(true);
        // //     }
        // // }
        // //
        // // if (PlayerPrefs.HasKey("Heal"))
        // // {
        // //     if (PlayerPrefs.GetInt("Heal") == 1)
        // //     {
        // //         isHeal = true;
        // //     }
        // // }
        // //
        // // if (PlayerPrefs.HasKey("Dash"))
        // // {
        // //     if (PlayerPrefs.GetInt("Dash") == 1)
        // //     {
        // //         isDash = true;
        // //     }
        // // }
        // //
        // // if (PlayerPrefs.HasKey("FoxSaved"))
        // // {
        // //     if (PlayerPrefs.GetInt("FoxSaved") == 1)
        // //     {
        // //         isFoxSaved = true;
        // //         seaWater.transform.DOLocalMove(new Vector3(89.502594f, -31f, -113.304504f),2f);
        // //     }
        // // }
        // // if (PlayerPrefs.HasKey("Colosseum"))
        // // {
        // //     if (PlayerPrefs.GetInt("Colosseum") == 1)
        // //     {
        // //         isColosseum = true;
        // //     }
        // // }
        // // if (PlayerPrefs.HasKey("Campfire"))
        // // {
        // //     if (PlayerPrefs.GetInt("Campfire") == 1)
        // //     {
        // //         isCampfire = true;
        // //     }
        // // }
        // //
        // // if (PlayerPrefs.HasKey("isDungeon"))
        // // {
        // //     isDungeon = true;
        // // }
        // // tutorialName = tutorialSection + ".";
        // // PlayerName = "";
        // // foxManager = FindObjectOfType<FoxManager>();
        // // if (!tutorial)
        // // {
        // //     if (tutorialSection == 0 && tutorialCounter == 0)
        // //     {
        // //         EquipmentManager.instance.currentWeapon.GetComponent<MeshRenderer>().enabled = false;
        // //         Player.instance._fixedJoystick.transform.GetChild(0).gameObject.SetActive(true);
        // //     }
        // //
        // //     UpdateGameState(GameState.Tutorial);
        // //     TutorialLoader.instance.Load(tutorialName + tutorialCounter);
        // //     TutorialEvents.OnTutorialComplete += TutorialChange;
        // // }
        // #endregion
        //
        //
        //
        //
        //
        // _questDialogueUI = FindObjectOfType<UnityUIQuestDialogueUI>();
        //
        // PlayStandSound();
        //
        //
        // UnityUIQuestDialogueUI.OnQuestChange.AddListener(AcceptQuest);
        // PixelCrushers.QuestMachine.Wrappers.UnityUIQuestDialogueUI.OnQuestChange.AddListener(AcceptQuest);
    }

    public void QuestLoad()
    {
        _questManager.successedQuests = ES3.Load("SuccessedQuest", _questManager.successedQuests);
        OpenTheVillageDoors();
        tutorialEnemies.gameObject.SetActive(false);
        wallFires.gameObject.SetActive(false);
        int count = _questManager.successedQuests.Count;
        // for (int i = 0; i <_questListContainer.questList.Count ; i++)
        // {
        //     if (_questListContainer.questList[i].id.ToString() == _questManager.successedQuests[count-1])
        //     {
        //         _questListContainer.questList[i+1]?.SetState(QuestState.WaitingToStart);
        //     }
        // }
        if (baskan.GetComponent<QuestGiver>().questList.Count != 0)
        {
            var questlist = baskan.GetComponent<QuestGiver>().questList;
            int counter = questlist.Count;
            for (int i = 0; i < counter; i++)
            {
                if (_questManager.successedQuests.Contains(questlist[i].id.ToString()))
                {
                    // 
                    Debug.Log(questlist[i].id.ToString() + " Bitirildi ");
                    questlist[i].SetState(QuestState.Successful);
                    questlist[i].BecomeUnofferable();
                    questlist.RemoveAt(i);
                    i--;
                    counter--;
                }
                else
                {
                    if (questlist[i].id.ToString() != "Monster" && questlist[i].id.ToString() != "BigMonster")
                    {
                        questlist[i].SetState(QuestState.WaitingToStart);
                        IndicatorDefine(baskan);
                        Debug.Log("Baskan quest verdi");
                        break;
                    }
                    else
                    {
                        firstLevelEnemies.gameObject.SetActive(true);
                        PlayerPrefs.SetString("FirstEnemies", "True");
                        var magicianGiver = magician.GetComponent<QuestGiver>();
                        int mageSuccessed = 0;
                        for (int j = 0; j < magicianGiver.questList.Count; j++)
                        {
                            if (_questManager.successedQuests.Contains(magicianGiver.questList[j].id.ToString()))
                            {
                                mageSuccessed++;
                                realmChange.gameObject.SetActive(true);
                                magicianGiver.questList[j].SetState(QuestState.Successful);
                            }
                        }

                        if (mageSuccessed is 0 or 1 && magicianGiver.questList.Count > 0)
                        {
                            for (int k = 0; k < magicianGiver.questList.Count; k++)
                            {
                                if (magicianGiver.questList[k].GetState() != QuestState.Successful)
                                {
                                    magicianGiver.questList[k].SetState(QuestState.WaitingToStart);
                                    break;
                                }
                            }

                            IndicatorDefine(magician.transform.parent.gameObject);
                            Debug.Log(mageSuccessed + " Completed quest count");
                            Debug.Log("Mage Quest verdi ");
                            break;
                        }
                        else
                        {
                            questlist[i].SetState(QuestState.WaitingToStart);
                            //baskan.GetComponent<QuestGiver>().StartDialogueWithPlayer();
                            IndicatorDefine(baskan);
                            Debug.Log("Baskan quest verdi");
                            if (questlist[i].id.ToString() == "BigMonster")
                            {
                                Debug.Log("Sasirtti");
                                Destroy(SkeletBoss.gameObject);
                            }

                            break;
                        }
                    }
                }
            }
        }
    }

    private int count;

    public void DeadBirlesikGolem()
    {
        count++;
        if (count > 1)
        {
            Invoke("PlayChapter3", 1);
        }
    }

    [Button("Chapter3")]
    public void PlayChapter3()
    {
        UiManager.instance.chapter3.gameObject.SetActive(true);
        GetComponent<SoundManager>().mainMusicSource.volume = 0f;
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Cinematic", "Cinematic03");
    }
    
    public void PlayEndVideo()
    {
        UiManager.instance.endVideo.gameObject.SetActive(true);
        GetComponent<SoundManager>().mainMusicSource.volume = 0f;
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Cinematic", "Cinematic04");
    }

    private void TutorialChange()
    {
      
        TutorialEvents.OnTutorialComplete -= TutorialChange;
        CinematicCamDisable();
        tutorialCounter++;
        PlayerPrefs.SetInt("TutorialCounter", tutorialCounter);
        PlayerPrefs.SetInt("TutorialSection", tutorialSection);

        if (tutorialSection == 0 && tutorialCounter > 8)
        {
            if (tutorialCounter > 8)
            {
                foxManager.FinishTutorial();
                FindObjectOfType<Player>().FinishTutorial();
                var foxgate = GameObject.FindWithTag("FoxGate");
                foxgate.GetComponent<Collider>().enabled = false;
                //EndOfTheCinematic();
            }
            //CinematicCamEnable(Player.instance.transform);
            //Player.instance.FinishTutorial();
        }
        else
        {
            UpdateGameState(GameState.Tutorial);
            CinematicCamDisable();
        }

        if (tutorialSection == 0 && tutorialCounter == 4)
        {
            Time.timeScale = 1f;
        }

        if (tutorialSection == 1 && tutorialCounter == 1)
        {
            tutorialEnemies.gameObject.SetActive(true);
            baskan.GetComponent<QuestGiver>().StartDialogueWithPlayer();
        }

        if (tutorialSection == 1 && tutorialCounter == 3)
        {
            tutorialSection++;
            PlayerPrefs.SetInt("TutorialSection", tutorialSection);
            tutorial = true;
            PlayerPrefs.SetString("Tutorial", "true");
        }
    }

    public void MagicianGaveRing()
    {
        PlayerPrefs.SetInt("Ring", 1);
        UiManager.instance.ringBtn.GetComponent<Button>().enabled = true;
    }

    public string TutorialLoad()
    {
        tutorialName = tutorialSection + ".";
        gameState = GameState.Pause;
        if (tutorialSection == 0 && tutorialCounter == 4)
        {
            FoxCamEnable();
            var cage = tutoCage.GetComponent<TutoCage>();
            for (int i = 0; i <cage.enemies.Length ; i++)
            {
                cage.enemies[i].GetComponent<Waypoint_Indicator>().enabled = true;
            }
        }
        else if (tutorialSection == 0 && tutorialCounter == 6)
        {
            CinematicCamEnable(tutoVaril.transform);
        }
        else if (tutorialSection == 0 && tutorialCounter ==8)
        {
            isFoxSaved = true;
            PlayerPrefs.SetInt("FoxSaved", 1);
        }

        if (tutorialSection == 1)
        {
            if (tutorialCounter == 1)
            {
                OpenTheVillageDoors();
                wallFires.gameObject.SetActive(false);
                CinematicCamEnable(villageEntryCollider.transform);
            }
            else if (tutorialCounter == 2)
            {
                CinematicCamEnable(baskan.transform.GetChild(1).transform);
            }
            else if (tutorialCounter == 3)
            {
                CinematicCamEnable(merchant.transform.GetChild(2).transform);
            }
            else if (tutorialCounter == 4)
            {
                CinematicCamEnable(blacksmith.transform.GetChild(2).transform);
            }
            else if (tutorialCounter == 5)
            {
                CinematicCamEnable(magician.transform.GetChild(1).transform);
            }
        }
        // else if (tutorialSection == 0 && tutorialCounter == 3)
        // {
        //     CinematicCamEnable(tutorialWall.transform.GetChild(0).transform);
        //     tutorialWall.transform.DOLocalMoveY(-1f, 5f).OnComplete((() => { CinematicCamDisable(); }));
        // }


        TutorialLoader.instance.Load(tutorialName + tutorialCounter);
        TutorialEvents.OnTutorialComplete += TutorialChange;
        return null;
    }

    private void Update()
    {
        /* Test Actionları */

        if (Input.GetKeyDown(KeyCode.Q))
            UpdateGameState(GameState.Play);
        if (Input.GetKeyDown(KeyCode.W))
            UpdateGameState(GameState.Pause);
        if (Input.GetKeyDown(KeyCode.E))
            FindObjectOfType<PlayerHealth>().TakeDamage(10);
        if (Input.GetKeyDown(KeyCode.A))
        {
            EconomyManager.instance.EarnRewards();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            UiManager.instance.MagicianUI();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            EconomyManager.instance.SetGold(1000);
        }

        currentTime += Time.deltaTime;

        if (currentTime > 10 && fightBool)
        {
            fightBool = false;
            PlayStandSound();
        }
    }

    public void UpdateGameState(GameState newState)
    {
        gameState = newState;
        switch (newState)
        {
            case GameState.Pause:
                break;
            case GameState.Play:
                break;
            case GameState.GameOver:
                break;
            case GameState.Tutorial:
                break;
        }

        onGameStateChanged?.Invoke(newState);
    }

    public void RestartGame()
    {
        PlayerPrefs.SetString("Edit", "false");
        PlayerPrefs.SetInt("StartVillage", 0);
        SceneManager.LoadScene(0);
    }

    public void RestartGameResume()
    {
        PlayerPrefs.SetInt("StartVillage", 1);
        SceneManager.LoadScene(0);
    }

    public void CinematicCamEnable(Transform target, float timer = 0)
    {
        //playerVCam.gameObject.SetActive(false);
        //foxVCam.gameObject.SetActive(false);
        //cinematicVCam.gameObject.SetActive(true);
        //cinematicVCam.Follow = target;
        //cinematicVCam.LookAt = target;
        // if (tutorialWall.name == target.name)
        // {
        //     CinemachineTransposer cmoffset = cinematicVCam.GetCinemachineComponent<CinemachineTransposer>();
        //     cmoffset.m_FollowOffset = new Vector3(0, 29, -27);
        //     print("wall");
        // }
        if (timer != 0)
        {
            CinematicCamDisable(timer);
        }
    }

    public void CinematicCamDisable(float timer = 0)
    {
        if (timer != 0)
        {
            DisableTimer = timer;
            StartCoroutine("DisableCamera");
        }
        else
        {
            //playerVCam.gameObject.SetActive(true);
            cinematicVCam.gameObject.SetActive(false);
            foxVCam.gameObject.SetActive(false);
        }
    }

    public void FoxCamEnable()
    {
        //playerVCam.gameObject.SetActive(false);
        cinematicVCam.gameObject.SetActive(false);
        foxVCam.gameObject.SetActive(true);
    }

    IEnumerator DisableCamera()
    {
        yield return new WaitForSeconds(DisableTimer);
        //playerVCam.gameObject.SetActive(true);
        cinematicVCam.gameObject.SetActive(false);
    }

    public void EndOfTheCinematic()
    {
        
        tutorialSection++;
        tutorialCounter = 0;
        PlayerPrefs.SetInt("TutorialSection", tutorialSection);
        PlayerPrefs.SetInt("TutorialCounter", tutorialCounter);
        UiManager.instance.SceneChange();
        // Panel yapilacak buraya 
    }

    public void OpenTheVillageDoors()
    {
        villageDoor.transform.DORotate(new Vector3(0, 90, 0), 5f);
        villageDoor2.transform.DORotate(new Vector3(0, 90, 0), 5f);
    }

    public void CloseTheVillageDoors()
    {
        villageDoor.transform.DORotate(new Vector3(0, 0, 0), 5f);
        villageDoor2.transform.DORotate(new Vector3(0, 0, 0), 5f);
    }

    public void IndicatorDefine(GameObject gameObject)
    {
        Player.instance.autoMoveTarget = gameObject.transform;
        UiManager.instance.autoMoveBtn.gameObject.SetActive(true);
        gameObject.SetActive(true);
        gameObject.GetComponent<Waypoint_Indicator>().enabled = true;
    }

    public void IndicatorClose(GameObject gameObject)
    {
        gameObject.GetComponent<Waypoint_Indicator>().enabled = false;
        if (gameObject.transform.parent.gameObject.GetComponent<Waypoint_Indicator>())
        {
            gameObject.transform.parent.gameObject.GetComponent<Waypoint_Indicator>().enabled = false;
        }
    }


    public void GameAnalyticsATTListenerNotDetermined()
    {
        GameAnalytics.Initialize();
    }

    public void GameAnalyticsATTListenerRestricted()
    {
        GameAnalytics.Initialize();
    }

    public void GameAnalyticsATTListenerDenied()
    {
        GameAnalytics.Initialize();
    }

    public void GameAnalyticsATTListenerAuthorized()
    {
        GameAnalytics.Initialize();
    }

    public void AcceptQuest(string questname)
    {
        string tempName = questname;
        questname = "";
        for (int i = 0; i < tempName.Length; i++)
        {
            if (tempName[i] == '(')
            {
                break;
            }

            questname += tempName[i];
        }

        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, questname, questname, "Accepted");
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, questname, questname, "InProgress");


        switch (questname)
        {
            case "KillTheAttackers":
                timerKillTheAttackers = Time.time;
                break;
            case "FirstMeet":
                timerFirstMeeting = Time.time;
             Invoke("HorseTutorial",3f);
                break;
            case "MerchantMeet":
                timerMerchant = Time.time;
                break;
            case "Magician":
                timerFindMage = Time.time;
                break;
            case "Monster":
                timerBoss = Time.time;
                break;
            case "BigMonster":
                timerBoss1 = Time.time;
                break;
            case "Magician2":
                //timerPortal1 = Time.time;
                break;
            case "Portal1":
                timerPortal1 = Time.time;
                break;
            case "Portal2":
                timerPortal2 = Time.time;
                break;
            case "Award":
                break;
        }
    }

    public void HorseTutorial()
    {
        TutorialLoader.instance.Load("Horse");
    }

    public void SuccessQuest(string questname)
    {
        string tempName = questname;
        questname = "";
        for (int i = 0; i < tempName.Length; i++)
        {
            if (tempName[i] == '(')
            {
                break;
            }

            questname += tempName[i];
        }

        switch (questname)
        {
            case "KillTheAttackers":
                timerKillTheAttackers = Time.time - timerKillTheAttackers;
                GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, questname, questname, "InProgress",
                    (int)timerKillTheAttackers);
                _questManager.successedQuests.Add(questname);
                Debug.Log(questname + " Tamamlandi ");

                // baskan.GetComponent<QuestGiver>().questList[0].SetState(QuestState.WaitingToStart);
                ES3.Save("SuccessedQuest", _questManager.successedQuests);
                QuestLoad();
                break;
            case "FirstMeet":
                timerFirstMeeting = Time.time - timerFirstMeeting;
                GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, questname, questname, "InProgress",
                    (int)timerFirstMeeting);
                _questManager.successedQuests.Add(questname);
                Debug.Log(questname + " Tamamlandi ");

                // baskan.GetComponent<QuestGiver>().questList[0].SetState(QuestState.WaitingToStart);
                ES3.Save("SuccessedQuest", _questManager.successedQuests);
                QuestLoad();
                break;
            case "MerchantMeet":
                timerMerchant = Time.time - timerMerchant;
                GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, questname, questname, "InProgress",
                    (int)timerMerchant);
                _questManager.successedQuests.Add(questname);
                Debug.Log(questname + " Tamamlandi ");

                // baskan.GetComponent<QuestGiver>().questList[0].SetState(QuestState.WaitingToStart);
                ES3.Save("SuccessedQuest", _questManager.successedQuests);
                QuestLoad();
                break;
            case "Magician":
                timerFindMage = Time.time - timerFindMage;
                GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, questname, questname, "InProgress",
                    (int)timerFindMage);
                _questManager.successedQuests.Add(questname);
                Debug.Log(questname + " Tamamlandi ");

                //magician.GetComponent<QuestGiver>().questList[0].SetState(QuestState.WaitingToStart);
                ES3.Save("SuccessedQuest", _questManager.successedQuests);
                QuestLoad();
                break;
            case "Monster":
                timerBoss = Time.time - timerBoss;
                GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, questname, questname, "InProgress",
                    (int)timerBoss);
                _questManager.successedQuests.Add(questname);
                Debug.Log(questname + " Tamamlandi ");
                ES3.Save("SuccessedQuest", _questManager.successedQuests);
                QuestLoad();
                break;
            case "BigMonster":
                timerBoss1 = Time.time - timerBoss1;
                GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, questname, questname, "InProgress",
                    (int)timerBoss1);
                _questManager.successedQuests.Add(questname);
                Debug.Log(questname + " Tamamlandi ");
                ES3.Save("SuccessedQuest", _questManager.successedQuests);
                break;
            case "Magician2":
                timerPortal1 = Time.time - timerPortal1;
                GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, questname, questname, "InProgress",
                    (int)timerPortal1);
                _questManager.successedQuests.Add(questname);
                Debug.Log(questname + " Tamamlandi ");
                realmChange.SetActive(true);
                //  magician.GetComponent<QuestGiver>().questList[0].SetState(QuestState.WaitingToStart);
                ES3.Save("SuccessedQuest", _questManager.successedQuests);
                QuestLoad();
                break;
            case "Portal2":
                timerPortal2 = Time.time - timerPortal2;
                GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, questname, questname, "InProgress",
                    (int)timerPortal2);
                break;
            case "Portal1":
                timerPortal1 = Time.time - timerPortal1;
                GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, questname, questname, "InProgress",
                    (int)timerPortal1);
                break;
            case "Award":
                IndicatorClose(magician);
                IndicatorClose(magician.transform.parent.gameObject);
                _questManager.successedQuests.Add(questname);
                ES3.Save("SuccessedQuest", _questManager.successedQuests);
                QuestLoad();
                //baskan.GetComponent<QuestGiver>().questList[0].SetState(QuestState.WaitingToStart);
                break;
        }
    }

    public void InitTutorialAnalytics(string tutorialName)
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Tutorial",
            "TutorialName_" + tutorialName);
    }

    
}