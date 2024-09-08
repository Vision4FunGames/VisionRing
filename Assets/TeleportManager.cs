using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportManager : MonoBehaviour
{
    public TeleportScene[] teleports;
    public GameObject twoSideTeleport;
    private CameraShake _cameraShake;
    public Scene baseScene;
    public GameObject[] dungeons;
    public GameObject dungeonSpawnPoint;
    private Player player;
    private int currentDungeonValue;
    private GameObject currentDungeon;
    public bool isTutorial;
    public int currentDungeonIndex;

    private void Start()
    {
        player = Player.instance;
        _cameraShake = FindObjectOfType<CameraShake>();
       

        if (!PlayerPrefs.HasKey("dungeonIndex"))
        {
            PlayerPrefs.SetInt("dungeonIndex", 1);
        }

        currentDungeonIndex = PlayerPrefs.GetInt("dungeonIndex");
        
        if (PlayerPrefs.HasKey("DungeonTutorial"))
            TeleportOpenAll();
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
        currentDungeonIndex++;
        PlayerPrefs.SetInt("dungeonIndex", currentDungeonIndex);
    }

    public void TeleportOpenAll()
    {
        for (int i = 0; i < teleports.Length; i++)
        {
            teleports[i].gameObject.SetActive(true);
            teleports[i].sceneName = currentDungeonIndex;
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
            Debug.Log(dungeonLevel);
            UiManager.instance.backGroundImage.DOColor(new Color(0, 0, 0, 1), 1.5f);
            currentDungeon = Instantiate(dungeons[dungeonLevel], dungeonSpawnPoint.transform.position,
                Quaternion.identity);
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

        playerMovementStart();
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
        GameObject baseTeleport = Instantiate(twoSideTeleport, player.transform.position + new Vector3(0, 1, 0),
            quaternion.identity);
        baseTeleport.GetComponentInChildren<TwoSideTeleport>().targetTeleport =
            teleports[currentDungeonValue].gameObject;
        teleports[currentDungeonValue].targetTeleport = baseTeleport;
    }
}