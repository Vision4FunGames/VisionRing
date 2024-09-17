using System;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;

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
            if (task)
            {
                Invoke("TaskCompletedWait",4f);
                Destroy(tp.currentDungeon,4f);
            }
            Debug.Log("sssssssssss");
            GetComponent<Collider>().enabled = false;
            Invoke("EnableCollider", 4f);
            if (tpCount !=0)
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
        if (Vector3.Distance(_player.transform.position, tp.dungeonSpawnPoint.transform.position) < 300)
        {
            UiManager.instance.DungeonEntry();
        }
        else
            UiManager.instance.HideOutEntry();
        
        _cameraShake.DungeonEnd();
        _player.teleportParticle.Stop();
        Invoke("playerMovementStart", 1);
    }

    public void playerMovementStart()
    {
        _player.isMovement = true;
    }

    public void TpStart()
    {
        UiManager.instance.backGroundImage.DOColor(new Color(0, 0, 0, 1), 1.5f);
        _player.teleportParticle.Play();
        _player.isMovement = false;
        Invoke("Tp", 2f);
    }
}