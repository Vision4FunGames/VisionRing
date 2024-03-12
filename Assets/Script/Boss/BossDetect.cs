using System;
using UnityEngine;

public class BossDetect : MonoBehaviour
{
    private BossManager bossManager;
    private PlayerAttack playerAttack;
    private float currentFlameTimer;

    private void Awake()
    {
        playerAttack = FindObjectOfType<PlayerAttack>();
        bossManager = GetComponent<BossManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
            bossManager.BossTakeSwordDamage(playerAttack.CalculateDamage() * 2);
        }

        if (other.CompareTag("Tornado"))
        {
            FindObjectOfType<TornadoExit>().EnemyAdd(gameObject);
        }

        if (other.CompareTag("RotateFire"))
        {
            bossManager.BossTakeSwordDamage(playerAttack.CalculateDamage());
        }
    }

    private void Update()
    {
        currentFlameTimer += Time.deltaTime;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Flame"))
        {
            if (currentFlameTimer > playerAttack.flameDamageRateOfFire)
            {
                currentFlameTimer = 0;
                bossManager.BossTakeSwordDamage(playerAttack.CalculateDamage());
            }
        }
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.name == "ArrowRain")
        {
            print("aa");
            bossManager.BossTakeSwordDamage(10);
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