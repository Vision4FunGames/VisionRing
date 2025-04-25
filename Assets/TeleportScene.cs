using System;
using Cinemachine;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class TeleportScene : MonoBehaviour
{
    private CameraShake _cameraShake;
    private TeleportManager tp;
    public int sceneName;
    private Player _player;
    public int tpCount;
    public GameObject targetTeleport;
    public bool task;

    private void Awake()
    {
        tpCount = 0;
        _cameraShake = FindObjectOfType<CameraShake>();
        _player = FindObjectOfType<Player>();
        tp = FindObjectOfType<TeleportManager>();
    }

    private void Start()
    {
    }

    public void TaskComplete()
    {
        FindObjectOfType<TaskPrefab>().isCompleted = true;
    }

    public void EnableCollider()
    {
        GetComponent<Collider>().enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.playerVCam.GetCinemachineComponent<CinemachineTransposer>().m_XDamping = 0;
            GameManager.instance.playerVCam.GetCinemachineComponent<CinemachineTransposer>().m_YDamping = 0;
            GameManager.instance.playerVCam.GetCinemachineComponent<CinemachineTransposer>().m_ZDamping = 0;

            transform.DOScale(Vector3.zero, 1).SetDelay(2).OnComplete((() => gameObject.SetActive(false)));

            if (task)
            {
                Invoke("TaskCompletedWait", 4f);
                Destroy(tp.currentDungeon, 4f);
            }

            Debug.Log("sssssssssss");
            GetComponent<Collider>().enabled = false;
            Invoke("EnableCollider", 4f);
            if (tpCount != 0)
            {
                TpStart();
            }
            else
            {
                tpCount++;
                tp.DungeonScene(sceneName);
            }
        }
    }

    public void TaskCompletedWait()
    {
        FindObjectOfType<TeleportManager>().DungeonIndex();
        TaskComplete();
    }

    public void Tp()
    {
        UiManager.instance.backGroundImage.DOColor(new Color(0, 0, 0, 0), 1.5f);
        _player.transform.position = targetTeleport.transform.position + new Vector3(3, 0, -6);
        Debug.Log(PlayerPrefs.GetInt("Fox"));
        if (PlayerPrefs.GetInt("Fox") == 1)
        {
            GameManager.instance.fox.SetActive(true);
            GameManager.instance.fox.GetComponent<NavMeshAgent>().enabled = false;
            GameManager.instance.fox.transform.position = _player.transform.position;
            GameManager.instance.fox.GetComponent<NavMeshAgent>().enabled = true;
        }
      
        if (Vector3.Distance(_player.transform.position, tp.dungeonSpawnPoint.transform.position) < 300)
        {
            UiManager.instance.DungeonEntry();
            _player.isBase = false;
        }
        else
        {
            _player.isBase = true;
            _player.playerDrm.gameObject.SetActive(false);
            UiManager.instance.HideOutEntry();
        }

        _cameraShake.DungeonEnd();
        _player.teleportParticle.Stop();
        Invoke("playerMovementStart", 1);
    }

    public void playerMovementStart()
    {
        _player.isMovement = true;
        GameManager.instance.playerVCam.GetCinemachineComponent<CinemachineTransposer>().m_XDamping = 1;
        GameManager.instance.playerVCam.GetCinemachineComponent<CinemachineTransposer>().m_YDamping = 1;
        GameManager.instance.playerVCam.GetCinemachineComponent<CinemachineTransposer>().m_ZDamping = 1;
    }

    public void TpStart()
    {
        UiManager.instance.backGroundImage.DOColor(new Color(0, 0, 0, 1), 1.5f);
        _player.teleportParticle.Play();
        _player.isMovement = false;
        Invoke("Tp", 2f);
    }

    public void OpenDelayPortal(float delay)
    {
        transform.DOScale(new Vector3(4.27f, 3.12f, 3.12f), 1f).SetEase(Ease.OutBack).SetDelay(delay);
    }

    public void CloseDelayPortal(float delay)
    {
        transform.DOScale(Vector3.zero, 1).SetDelay(delay);
    }
}