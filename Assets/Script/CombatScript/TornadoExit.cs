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
        for (int i = 0; i < enemies.Count; i++)
        {
            enemies[i].GetComponentInChildren<DetectEnemyCollider>().TornadoFinish();
        }
    }

    public void EnemyAdd(GameObject enemy)
    {
        enemies.Add(enemy);
    }
    public void EnemyRemove(GameObject enemy)
    {
        enemies.Remove(enemy);
        enemy.GetComponent<DetectEnemyCollider>().AddForce();
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
            enemies[i].GetComponentInChildren<EnemyStats>().TakeDamage(playerAttack.tornadoDamage);
        }
    }
}