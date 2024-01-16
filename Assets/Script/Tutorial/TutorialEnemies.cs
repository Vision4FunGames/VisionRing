using System;
using System.Collections;
using System.Collections.Generic;
using Exoa.TutorialEngine;
using UnityEngine;

public class TutorialEnemies : MonoBehaviour
{

    public GameObject[] enemies;
    private int enemyCount;
    
    private void Start()
    {
        enemyCount = enemies.Length;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            AllEnemyDead();
        }
    }

    private void AllEnemyDead()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<EnemyStats>().Die();
        }
    }

    public void EnemyDied()
    {
        enemyCount--;
        print("Enemy Count --");
        if (enemyCount==0)
        {
            GameManager.instance.TutorialLoad();
        }
    }
}
