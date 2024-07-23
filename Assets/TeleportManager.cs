using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportManager : MonoBehaviour
{
    private CameraShake _cameraShake;
    public Scene baseScene;
    public GameObject[] dungeons;
    public GameObject dungeonSpawnPoint;
    private Player player;
    private GameObject currentDungeon;

    private void Start()
    {
        player = Player.instance;
        _cameraShake = FindObjectOfType<CameraShake>();
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
        if (dungeonLevel == 0)
        {
            UiManager.instance.backGroundImage.DOColor(new Color(0, 0, 0, 1), 1.5f);
            player.teleportParticle.Play();
            player.isMovement = false;
            Invoke("BaseSceneReturn", 2f);
        }
        else
        {
            UiManager.instance.backGroundImage.DOColor(new Color(0, 0, 0, 1), 1.5f);
            currentDungeon = Instantiate(dungeons[dungeonLevel], dungeonSpawnPoint.transform.position, Quaternion.identity);
            player.teleportParticle.Play();
            player.isMovement = false;
            Invoke("MoveTeleportPlayer", 2f);
        }
    }

    public void MoveTeleportPlayer()
    {
        UiManager.instance.backGroundImage.DOColor(new Color(0, 0, 0, 0), 1.5f);
        player.transform.position = currentDungeon.transform.GetChild(0).position;
        player.isMovement = true;
        _cameraShake.DungeonStart();
        player.teleportParticle.Stop();
    }

    public void BaseSceneReturn()
    {
        UiManager.instance.backGroundImage.DOColor(new Color(0, 0, 0, 0), 1.5f);
        player.transform.position = Vector3.zero;
        player.isMovement = true;
        _cameraShake.DungeonEnd();
        player.teleportParticle.Stop();
    }
}