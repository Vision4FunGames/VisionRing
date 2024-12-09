using System;
using System.Collections.Generic;
using DG.Tweening;
using NaughtyAttributes;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportManager : MonoBehaviour
{
    public List<bool> completeDungeon;
    public int[] dungeonKeyPrice;
    public DungeonLayout[] dungeonLayouts;
    public GameObject[] dungeons;
    public TeleportScene[] teleports;
    public GameObject twoSideTeleport;
    private CameraShake _cameraShake;
    public Scene baseScene;
    public GameObject dungeonSpawnPoint;
    private Player player;
    private int currentDungeonValue;
    public GameObject currentDungeon;
    public bool isTutorial;
    public int currentDungeonIndex;

    private void Start()
    {
        player = Player.instance;
        _cameraShake = FindObjectOfType<CameraShake>();

        completeDungeon = ES3.Load("CompleteDungeon", completeDungeon);
        
        if (!PlayerPrefs.HasKey("dungeonIndex"))
        {
            PlayerPrefs.SetInt("dungeonIndex", 1);
        }

        currentDungeonIndex = PlayerPrefs.GetInt("dungeonIndex");

        if (FindObjectOfType<TaskSystem.TaskManager>().LastMainTaskIndex > 10 &&
            FindObjectOfType<TaskSystem.TaskManager>().LastMainTaskIndex <= 25)
        {
            currentDungeonIndex = 2;
        }

        if (PlayerPrefs.HasKey("DungeonTutorial"))
            TeleportOpenAll();

        SetUpdatePanel();
    }

    public void DungeonIndexChange(int dungeonIndex)
    {
        currentDungeonIndex = dungeonIndex;
    }
    public void SetUpdatePanel()
    {
        for (int i = 1; i < dungeonLayouts.Length; i++)
        {
            dungeonLayouts[i].price.text = "$" + dungeonKeyPrice[i];

            if (i == currentDungeonIndex)
            {
                dungeonLayouts[i].buyBtn.gameObject.SetActive(false);
                dungeonLayouts[i].price.gameObject.SetActive(false);
            }

            if (completeDungeon[i])
            {
                dungeonLayouts[i].complete.SetActive(true);
                dungeonLayouts[i].buyBtn.gameObject.SetActive(false);
                dungeonLayouts[i].price.gameObject.SetActive(false);
            }
        }
    }


    [Button("SaveDungeon")]
    public void SaveDungeon()
    {
        ES3.Save("CompleteDungeon", completeDungeon);
    }

    public void BuyKeyDungeon(DungeonLayout dungeonKeys)
    {
        for (int i = 1; i < dungeonLayouts.Length; i++)
        {
            if (dungeonLayouts[i] == dungeonKeys)
            {
                currentDungeonIndex = i;
                Inventory.instance.usableItemsCount[i-1] += 1;
                SetUpdatePanel();
                SaveDungeon();
                break;
            }
        }

        TaskPrefab taskPrefab = FindObjectOfType<MeetRuthledge>()?.GetComponent<TaskPrefab>();
        if (taskPrefab != null)
        {
            taskPrefab.isCompleted = true;
            Destroy(taskPrefab.gameObject,1);
        }
    }
    public void TeleportScene(int sceneName)
    {
        PlayerPrefs.SetInt("HideOut" + SceneManager.GetActiveScene().name, 0);
        if (PlayerPrefs.GetInt("MapLevel") < sceneName)
            PlayerPrefs.SetInt("MapLevel", sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void DungeonIndex()
    {
        completeDungeon[currentDungeonIndex] = true;
        SaveDungeon();
        currentDungeonIndex++;
        PlayerPrefs.SetInt("dungeonIndex", currentDungeonIndex);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
            TeleportOpenAll();
    }

    private float delayTime;

    public void TeleportOpenAll()
    {
        for (int i = 0; i < teleports.Length; i++)
        {
            teleports[i].transform.localScale = Vector3.zero;
            teleports[i].gameObject.SetActive(true);
            teleports[i].OpenDelayPortal(delayTime);
            delayTime = delayTime + 0.3f;
            teleports[i].sceneName = currentDungeonIndex;
            teleports[i].tpCount = 0;
        }
    }
    
    public void TeleportCloseAll()
    {
        for (int i = 0; i < teleports.Length; i++)
        {
            teleports[i].gameObject.SetActive(false);
        }
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
            if (currentDungeon == null)
            {
                currentDungeon = Instantiate(dungeons[dungeonLevel], dungeonSpawnPoint.transform.position,
                    Quaternion.identity);
            }

            player.teleportParticle.Play();
            player.isMovement = false;
            Invoke("MoveTeleportPlayer", 2f);
        }
    }

    public void MoveTeleportPlayer()
    {
        UiManager.instance.backGroundImage.DOColor(new Color(0, 0, 0, 0), 1.5f);
        player.transform.position = currentDungeon.transform.GetChild(0).position;
        if (Vector3.Distance(player.transform.position, dungeonSpawnPoint.transform.position) < 300)
        {
            UiManager.instance.DungeonEntry();
        }
        else
            UiManager.instance.HideOutEntry();

        Invoke("playerMovementStart", 1);
        _cameraShake.DungeonStart();
        player.teleportParticle.Stop();
    }

    public void BaseSceneReturn()
    {
        UiManager.instance.backGroundImage.DOColor(new Color(0, 0, 0, 0), 1.5f);
        player.transform.position = Vector3.zero;
        if (Vector3.Distance(player.transform.position, dungeonSpawnPoint.transform.position) < 300)
        {
            UiManager.instance.DungeonEntry();
        }
        else
            UiManager.instance.HideOutEntry();

        Invoke("playerMovementStart", 1f);
        _cameraShake.DungeonEnd();
        player.teleportParticle.Stop();
    }


    public void playerMovementStart()
    {
        player.isMovement = true;
        if (isTutorial)
        {
            FindObjectOfType<TaskPrefab>().isCompleted = true;
            Destroy(FindObjectOfType<TaskPrefab>().gameObject, 1f);
            isTutorial = false;
        }
    }

    public void TeleportSpawn()
    {
        if (Vector3.Distance(player.transform.position, dungeonSpawnPoint.transform.position) < 300)
        {
            GameObject baseTeleport = Instantiate(twoSideTeleport, player.transform.position + new Vector3(0, 1, 0),
                quaternion.identity);
            baseTeleport.GetComponentInChildren<TwoSideTeleport>().targetTeleport =
                teleports[currentDungeonValue].gameObject;
            teleports[currentDungeonValue].targetTeleport = baseTeleport;
        }
    }
}