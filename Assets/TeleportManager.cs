using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportManager : MonoBehaviour
{
    public Scene baseScene;
    public GameObject[] dungeons;
    public GameObject dungeonSpawnPoint;
    private Player player;
    private GameObject currentDungeon;
    private void Start()
    {
        player = Player.instance;
    }

    public void TeleportScene(int sceneName)
    {
        PlayerPrefs.SetInt("HideOut" + SceneManager.GetActiveScene().name, 0);
        if (PlayerPrefs.GetInt("MapLevel") < sceneName)
            PlayerPrefs.SetInt("MapLevel", sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void DungeonScene(int dungeonLevel)
    {
         currentDungeon = Instantiate(dungeons[dungeonLevel],dungeonSpawnPoint.transform.position,Quaternion.identity);
         player.teleportParticle.Play();
        Invoke("MoveTeleportPlayer",2f);
    }

    public void MoveTeleportPlayer()
    {
        player.transform.position = currentDungeon.transform.GetChild(0).position;
        player.teleportParticle.Stop();
    }

    public void BaseSceneReturn()
    {
        SceneManager.LoadScene(1);
    }
}