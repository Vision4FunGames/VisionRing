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

    public void EnemyDied()
    {
        enemyCount--;
        if (enemyCount==0)
        {
            GameManager.instance.TutorialLoad();
        }
    }
}
