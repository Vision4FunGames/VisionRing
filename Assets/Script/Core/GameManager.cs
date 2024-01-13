using System;
using Cinemachine;
using Exoa.TutorialEngine;
using PixelCrushers;
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
    public GameObject baskan;
    public GameObject merchant;
    public GameObject blacksmith;
    public GameObject magician;
        
private void Awake()
    {
        instance = this;
        Application.targetFrameRate = 60;
        if (PlayerPrefs.HasKey("TutorialSection"))
        {
            tutorialCounter = 0;
            tutorialSection = PlayerPrefs.GetInt("TutorialSection");
            if (tutorialSection == 1)
            {
                tutorialEnemies.gameObject.SetActive(true);
            }
        }
    }
    private void Start()
    {
        tutorialName = tutorialSection + ".";
        PlayerName = "Patakoz";
        foxManager = FindObjectOfType<FoxManager>();
        if (!tutorial)
        {
            if (tutorialSection==0 && tutorialCounter == 0)
            {
                EquipmentManager.instance.currentWeapon.GetComponent<MeshRenderer>().enabled = false;
            }
            UpdateGameState(GameState.Tutorial); 
            Player.instance._fixedJoystick.transform.GetChild(0).gameObject.SetActive(true);
            TutorialLoader.instance.Load(tutorialName+tutorialCounter);
            TutorialEvents.OnTutorialComplete += TutorialChange;
        }
        else
        {
            
        }
    }
    private void TutorialChange()
    {
        TutorialEvents.OnTutorialComplete -= TutorialChange;
        tutorialCounter++;
        PlayerPrefs.SetInt("TutorialCounter",tutorialCounter);
        PlayerPrefs.SetInt("TutorialSection", tutorialSection);
        
        if (tutorialSection == 0 && tutorialCounter>5)
        {
            foxManager.FinishTutorial();
            //CinematicCamEnable(Player.instance.transform);
            //Player.instance.FinishTutorial();
            
        }
        else
        {
            UpdateGameState(GameState.Tutorial);
            CinematicCamDisable();
        }
       
       
        
    }

    public void TutorialLoad()
    {
        gameState = GameState.Pause;
        if (tutorialSection ==0 && tutorialCounter == 4)
        {
            CinematicCamEnable(foxManager.transform);
        }

        if (tutorialSection == 1)
        {
            if (tutorialCounter ==1)
            {
                CinematicCamEnable(baskan.transform);
            }
            else if (tutorialCounter ==3)
            {
                CinematicCamEnable(merchant.transform);
            }
            else if (tutorialCounter == 4)
            {
                CinematicCamEnable(blacksmith.transform);
            }
            else if (tutorialCounter == 5)
            {
                CinematicCamEnable(magician.transform);
            }
        }
       
       
        TutorialLoader.instance.Load(tutorialName + tutorialCounter);
        TutorialEvents.OnTutorialComplete += TutorialChange;
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
        PlayerPrefs.SetInt("StartVillage",0);
        
        SceneManager.LoadScene(0);
    }

    public void RestartGameResume()
    {
        PlayerPrefs.SetInt("StartVillage", 1);
    }

    public void CinematicCamEnable(Transform target)
    {
        playerVCam.gameObject.SetActive(false);
        cinematicVCam.gameObject.SetActive(true);
        cinematicVCam.Follow = target;
        cinematicVCam.LookAt = target;
    }
    public void CinematicCamDisable()
    {
        playerVCam.gameObject.SetActive(true);
        cinematicVCam.gameObject.SetActive(false);
    }

    public void EndOfTheCinematic()
    {
        tutorialSection++;
        tutorialCounter = 0;
        PlayerPrefs.SetInt("TutorialSection",tutorialSection);
        PlayerPrefs.SetInt("TutorialCounter",tutorialCounter);
        UiManager.instance.SceneChange();
        // Panel yapilacak buraya 
    }
}