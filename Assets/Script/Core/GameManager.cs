using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using DG.Tweening;
using Exoa.TutorialEngine;
using PixelCrushers;
using PixelCrushers.QuestMachine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    Play,
    Pause,
    GameOver,
    Tutorial
}

public class GameManager : MonoBehaviour
{
    public GameObject villageSpawnPos;
    public GameObject tutorial1SpawnPos;
    public static GameManager instance;
    public GameState gameState;
    public static event Action<GameState> onGameStateChanged;
    public string PlayerName;
    public CinemachineVirtualCamera playerVCam;
    public CinemachineVirtualCamera cinematicVCam;
    public int tutorialCounter = 1;
    public int tutorialSection;
    private string tutorialName;
    public bool tutorial;
    public FoxManager foxManager;
    [Header("Tutorial")] public GameObject tutorialEnemies;
    public GameObject tutoCage;
    public GameObject tutorialWall;
    public GameObject tutorialCollider1, tutorialCollider2, villageEntryCollider;
    public GameObject wallFires;
    public GameObject tutorialBox, tutorialBoxArea;
    public GameObject mainSword;
    public GameObject baskan;
    public GameObject merchant;
    public GameObject blacksmith;
    public GameObject magician;
    public GameObject villageDoor, villageDoor2;
    public GameObject tutorialIncreaserFirst;
    [Header("NPC isOpen")] public bool isMerchant;
    public bool isMagician;
    public bool isBlacksmith;
    public bool isRing;
    public bool isHeal;
    public bool isBox;
    public float currentTime;
    public bool fightBool;
    public AudioClip fight, stand;
    public bool isFoxSaved;

    private float DisableTimer;
    
    private void Awake()
    {
        instance = this;
        Application.targetFrameRate = 60;
        PlayStandSound();
        if (PlayerPrefs.HasKey("TutorialSection"))
        {
            tutorialCounter = 0;
            tutorialSection = PlayerPrefs.GetInt("TutorialSection");
        }
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

    private void Start()
    {
        #region Tutorial

        if (tutorialSection == 1)
        {
            // //Quest quest = new Quest(questMachineConfiguration)
            // Player.instance.GetComponent<QuestJournal>()
            //     .AddQuest(questMachineConfiguration.questDatabases[0].questAssets[9]);
        }
        if (PlayerPrefs.HasKey("Blacksmith"))
        {
            if (PlayerPrefs.GetInt("Blacksmith") == 1)
            {
                isBlacksmith = true;
            }
        }

        if (PlayerPrefs.HasKey("Merchant"))
        {
            if (PlayerPrefs.GetInt("Merchant") == 1)
            {
                isMerchant = true;
            }
        }

        if (PlayerPrefs.HasKey("Magician"))
        {
            if (PlayerPrefs.GetInt("Magician") == 1)
            {
                isMagician = true;
            }
        }

        if (PlayerPrefs.HasKey("Ring"))
        {
            if (PlayerPrefs.GetInt("Ring") == 1)
            {
                if (gameState != GameState.Tutorial)
                {
                    isRing = true;
                    UiManager.instance.ringBtn.gameObject.SetActive(true);
                }
                
            }
            else
            {
                UiManager.instance.ringBtn.gameObject.SetActive(false);
            }
        }

        if (PlayerPrefs.HasKey("Heal"))
        {
            if (PlayerPrefs.GetInt("Heal") == 1)
            {
                isHeal = true;
            }
        }

        if (PlayerPrefs.HasKey("FoxSaved"))
        {
            if (PlayerPrefs.GetInt("FoxSaved")== 1)
            {
                isFoxSaved = true;
            }
        }

        #endregion

        tutorialName = tutorialSection + ".";
        PlayerName = "";
        foxManager = FindObjectOfType<FoxManager>();
        if (!tutorial)
        {
            if (tutorialSection == 0 && tutorialCounter == 0)
            {
                EquipmentManager.instance.currentWeapon.GetComponent<MeshRenderer>().enabled = false;
                Player.instance._fixedJoystick.transform.GetChild(0).gameObject.SetActive(true);
            }

            UpdateGameState(GameState.Tutorial);
            TutorialLoader.instance.Load(tutorialName + tutorialCounter);
            TutorialEvents.OnTutorialComplete += TutorialChange;
        }
        else
        {
            
        }


        PlayStandSound();
    }

    private void TutorialChange()
    {
        TutorialEvents.OnTutorialComplete -= TutorialChange;
        CinematicCamDisable();
        print("Counter : " + tutorialCounter);
        tutorialCounter++;
        PlayerPrefs.SetInt("TutorialCounter", tutorialCounter);
        PlayerPrefs.SetInt("TutorialSection", tutorialSection);

        if (tutorialSection == 0 && tutorialCounter > 5)
        {
            if (tutorialCounter > 5)
            {
                foxManager.FinishTutorial();
                FindObjectOfType<Player>().FinishTutorial();
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

        if (tutorialSection == 1 && tutorialCounter == 1)
        {
            baskan.GetComponent<QuestGiver>().StartDialogueWithPlayer();
            
        }
    }

    public string TutorialLoad()
    {
        gameState = GameState.Pause;
        if (tutorialSection == 0 && tutorialCounter == 4)
        {
            CinematicCamEnable(foxManager.transform);
        }
        else if (tutorialSection == 0 && tutorialCounter ==5)
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
    
    public void CinematicCamEnable(Transform target,float timer = 0)
    {
        playerVCam.gameObject.SetActive(false);
        cinematicVCam.gameObject.SetActive(true);
        cinematicVCam.Follow = target;
        cinematicVCam.LookAt = target;
        // if (tutorialWall.name == target.name)
        // {
        //     CinemachineTransposer cmoffset = cinematicVCam.GetCinemachineComponent<CinemachineTransposer>();
        //     cmoffset.m_FollowOffset = new Vector3(0, 29, -27);
        //     print("wall");
        // }
        print(timer + " CInematic ");
        if (timer !=0)
        {
            CinematicCamDisable(timer);
        }
    }

    private void CinematicCamDisable(float timer = 0)
    {
        if (timer !=0)
        {
            DisableTimer = timer;
            StartCoroutine("DisableCamera");
        }
        else
        {
            playerVCam.gameObject.SetActive(true);
            cinematicVCam.gameObject.SetActive(false);
        }
    }

    IEnumerator DisableCamera()
    {
        yield return new WaitForSeconds(DisableTimer);
        playerVCam.gameObject.SetActive(true);
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
        gameObject.GetComponent<Waypoint_Indicator>().enabled = true;
    }

    public void IndicatorClose( GameObject gameObject)
    {
        gameObject.GetComponent<Waypoint_Indicator>().enabled = false;
    }
}