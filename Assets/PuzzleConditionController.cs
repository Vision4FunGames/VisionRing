using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
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
            if (GetComponent<MeshRenderer>())
            {
                GetComponent<MeshRenderer>().enabled = false;
                GetComponent<Collider>().enabled = false;
            }
        }
    }

    public void DeadEnemyPuzzle()
    {
        leaveEnemy++;
        if (enemyCount <= leaveEnemy)
        {
            if (enemySpawner)
            {
                GetComponentInParent<TutorialCondition>().TutorialComplete();
                enemySpawner.isConditionCompleted = true;
            }

            if (GetComponent<TaskPrefab>())
            {
                GetComponent<TaskPrefab>().isCompleted = true;
                transform.parent.DOScale(Vector3.zero, 1);
                Destroy(transform.parent.gameObject, 1f);
            }
            else if (GetComponent<MeshRenderer>())
            {
                GetComponent<MeshRenderer>().enabled = true;
                GetComponent<Collider>().enabled = true;
            }
        }
    }
}