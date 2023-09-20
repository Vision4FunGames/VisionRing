using System;
using UnityEngine;

public enum GameState
{
    Play,
    Pause,
    GameOver
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState gameState;
    public static event Action<GameState> onGameStateChanged;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateGameState(GameState.Pause);
    }

    private void Update()
    {
         /* Test Actionları */
         
        if (Input.GetKeyDown(KeyCode.Q))
            UpdateGameState(GameState.Play);
        if (Input.GetKeyDown(KeyCode.W))
            UpdateGameState(GameState.Pause);
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
        }

        onGameStateChanged?.Invoke(newState);
    }
}