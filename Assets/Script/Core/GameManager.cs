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
    public static GameManager instance;
    public GameState gameState;
    public static event Action<GameState> onGameStateChanged;
    public CinemachineVirtualCamera playerVCam;
    public int tutorialCounter = 1;
    private string tutorialName = "1.";
    public bool tutorial;
    private void Awake()
    {
        instance = this;
        Application.targetFrameRate = 60;
    }
    private void Start()
    {
        if (!tutorial)
        {
            EquipmentManager.instance.currentWeapon.GetComponent<MeshRenderer>().enabled = false;
            UpdateGameState(GameState.Tutorial); 
            Player.instance._fixedJoystick.transform.GetChild(0).gameObject.SetActive(true);
            TutorialLoader.instance.Load(tutorialName+tutorialCounter);
            TutorialEvents.OnTutorialComplete += TutorialChange;
        }
        else
        {
            UpdateGameState(GameState.Play);
        }
    
    }
    private void TutorialChange()
    {
        TutorialEvents.OnTutorialComplete -= TutorialChange;
        tutorialCounter++;
        gameState = GameState.Tutorial;

    }

    public void TutorialLoad()
    {
        gameState = GameState.Pause;
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
        SceneManager.LoadScene(0);
    }
}