using System;
using UnityEngine;

public class BossDetect : MonoBehaviour
{
    private BossManager bossManager;
    private PlayerAttack playerAttack;
    private void Awake()
    {
        playerAttack = FindObjectOfType<PlayerAttack>();
        bossManager = GetComponent<BossManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
            bossManager.BossTakeSwordDamage(playerAttack.damage*10);
        }

        if (other.CompareTag("Tornado"))
        {
            FindObjectOfType<TornadoExit>().EnemyAdd(gameObject);
        }
        if (other.CompareTag("RotateFire"))
        {
            bossManager.BossTakeSwordDamage(playerAttack.damage);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tornado"))
        {
            FindObjectOfType<TornadoExit>().EnemyRemove(gameObject);
        }
    }
}
