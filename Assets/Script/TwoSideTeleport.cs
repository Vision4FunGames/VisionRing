using DG.Tweening;
using UnityEngine;

public class TwoSideTeleport : MonoBehaviour
{
    public GameObject targetTeleport;
    private Player player;
    private CameraShake _cameraShake;
    private TeleportManager _teleportManager;

    private void Awake()
    {
        player = Player.instance;
        _cameraShake = FindObjectOfType<CameraShake>();
        Invoke("EnableCollider", 1);
        _teleportManager = FindObjectOfType<TeleportManager>();
    }

    public void EnableCollider()
    {
        GetComponent<Collider>().enabled = true;
    }

    public void Tp()
    {
        UiManager.instance.backGroundImage.DOColor(new Color(0, 0, 0, 0), 1.5f);
        player.transform.position = targetTeleport.transform.position + new Vector3(3, 0, -6);
        if (Vector3.Distance(player.transform.position, _teleportManager.dungeonSpawnPoint.transform.position) < 300)
        {
            UiManager.instance.DungeonEntry();
            player.isBase = false;
        }
        else
        {
            UiManager.instance.HideOutEntry();
            player.isBase =true;
        }
         

        _cameraShake.DungeonEnd();
        player.teleportParticle.Stop();
        Invoke("playerMovementStart", 1);
    }

    public void playerMovementStart()
    {
        player.isMovement = true;
        GetComponent<Collider>().enabled = true;
    }

    public void TpStart()
    {
        UiManager.instance.backGroundImage.DOColor(new Color(0, 0, 0, 1), 1.5f);
        player.teleportParticle.Play();
        player.isMovement = false;
        Invoke("Tp", 2f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Collider>().enabled = false;
            TpStart();
        }
    }
}