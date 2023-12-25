using System;
using System.Collections.Generic;
using UnityEngine;

public class TornadoExit : MonoBehaviour
{
    private PlayerAttack playerAttack;
    private float currentTime;
    public List<GameObject> enemies;

    private void Awake()
    {
        playerAttack = GetComponentInParent<PlayerAttack>();
        enemies = new List<GameObject>();
    }

    public void TornadoExitFunc()
    {
        int enemieC = enemies.Count;
        for (int i = 0; i < enemieC; i++)
        {
            if (enemies[0].GetComponent<Enemy>())
                enemies[0].GetComponent<Enemy>().TornadoFinish();
            else
            {
                enemies.RemoveAt(0);
            }
        }
    }

    public void EnemyAdd(GameObject enemy)
    {
        enemies.Add(enemy);
    }

    public void EnemyRemove(GameObject enemy)
    {
        enemies.Remove(enemy);
        if (enemy.GetComponent<Enemy>())
            enemy.GetComponent<Enemy>().AddForce();
    }


    private void Update()
    {
        currentTime += Time.deltaTime;
        if (CanDamage())
            TornadoDamage();
    }

    public bool CanDamage()
    {
        return currentTime > playerAttack.tornadoDamageRate;
    }

    public void TornadoDamage()
    {
        currentTime = 0;
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i].GetComponent<EnemyStats>())
                enemies[i].GetComponent<EnemyStats>().TakeDamage(playerAttack.tornadoDamage);
            else if (enemies[i].GetComponent<BossManager>())
                enemies[i].GetComponent<BossManager>().BossTakeSwordDamage(playerAttack.tornadoDamage);
            else if (enemies[i].GetComponent<Golem1>())
                enemies[i].GetComponent<Golem1>().TakeDamage(playerAttack.tornadoDamage);
            else if (enemies[i].GetComponent<Golem2>())
                enemies[i].GetComponent<Golem2>().TakeDamage(playerAttack.tornadoDamage);
            else if (enemies[i].GetComponent<BirlesikGolem>())
                enemies[i].GetComponent<BirlesikGolem>().TakeDamage(playerAttack.tornadoDamage);
        }
    }
}