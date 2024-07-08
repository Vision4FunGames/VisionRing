using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportManager : MonoBehaviour
{
    public Scene baseScene;


    public void TeleportScene(int sceneName)
    {
        PlayerPrefs.SetInt("HideOut" + SceneManager.GetActiveScene().name, 0);
        if (PlayerPrefs.GetInt("MapLevel") < sceneName)
            PlayerPrefs.SetInt("MapLevel", sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void DungeonScene(String sceneName)
    {
        String sceneKey = SceneManager.GetActiveScene().name;
        Debug.Log(sceneKey);
        SceneManager.LoadScene(sceneName);
    }

    public void BaseSceneReturn()
    {
        SceneManager.LoadScene(1);
    }
}