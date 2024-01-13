using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleConditionController : MonoBehaviour
{
    private EnemySpawner enemySpawner;

    public int enemyCount;

    public int leaveEnemy;
    // Start is called before the first frame update
    void Start()
    {
        enemySpawner = GetComponent<EnemySpawner>();
        for (int i = 0; i < enemySpawner.spawnOptions.Length; i++)
        {
            enemyCount += enemySpawner.spawnOptions[i].spawnCount;
        }
    }

    public void DeadEnemyPuzzle()
    {
        leaveEnemy++;
        if (enemyCount <= leaveEnemy)
            enemySpawner.isConditionCompleted = true;
    }
}
