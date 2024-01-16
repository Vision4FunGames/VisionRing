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
        if (GetComponent<EnemySpawner>())
        {
            enemySpawner = GetComponent<EnemySpawner>();
            for (int i = 0; i < enemySpawner.spawnOptions.Length; i++)
            {
                enemyCount += enemySpawner.spawnOptions[i].spawnCount;
            }
        }
        else
        {
            enemyCount = transform.childCount;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
        }
    }

    public void DeadEnemyPuzzle()
    {
        leaveEnemy++;
        if (enemyCount <= leaveEnemy)
        {
            if (enemySpawner)
                enemySpawner.isConditionCompleted = true;
            else if (GetComponent<MeshRenderer>())
            {
                GetComponent<MeshRenderer>().enabled = true;
                GetComponent<Collider>().enabled = true;
            }
        }
    }
}