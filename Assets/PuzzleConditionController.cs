using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class PuzzleConditionController : MonoBehaviour
{
    private EnemySpawner enemySpawner;

    public int enemyCount;
    int currentCount;
    public int leaveEnemy;

    public bool task;

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

        if (task)
        {
            Invoke("OpenEnemies", 2.5f);
        }
    }

    public void OpenEnemies()
    {
        if (currentCount < enemyCount)
        {
            transform.GetChild(currentCount).gameObject.SetActive(true);
            currentCount++;
            Invoke("OpenEnemies", Random.Range(0f, .75f));
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

            if (GetComponentInParent<TaskPrefab>() && GetComponentInParent<SaveTheFox>())
            {
                GetComponentInParent<SaveTheFox>().FoxFree();
            }

            if (GetComponentInParent<TaskPrefab>() && !GetComponentInParent<SaveTheFox>())
            {
                GetComponentInParent<TaskPrefab>().isCompleted = true;
                transform.parent.DOScale(Vector3.zero, 1);
                Destroy(transform.gameObject, 1f);
            }
            else if (GetComponent<MeshRenderer>())
            {
                GetComponent<MeshRenderer>().enabled = true;
                GetComponent<Collider>().enabled = true;
            }
        }
    }
}