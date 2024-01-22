using System;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class ChestDropObj : MonoBehaviour
{
    private bool isF;
    public UpgradeItem upItem;
    private Player player;
    private bool playerFollow;
    private void Awake()
    {
        player = FindObjectOfType<Player>();
        
    }

    public void Jumping()
    {
        Vector3 jumpPos = Random.insideUnitSphere * 6 + Random.insideUnitSphere * 6;
        jumpPos.y = 0;
        transform.DOLocalJump(jumpPos, 1, 4, 1.5f).SetEase(Ease.OutQuart).SetDelay(Random.Range(0f, 1f));
        
        Invoke("PlayerFollow",3);
    }

    private void Update()
    {
        if (playerFollow)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 1);
        }

        if (Vector3.Distance(player.transform.position, transform.position) < 1 && !isF)
        {
            EquipmentManager.instance.EarnUpgradeItem(upItem);
            isF = true;
            Destroy(gameObject);
        }
    }

    public void PlayerFollow()
    {
        transform.parent = null;
        playerFollow = true;
    }
}

