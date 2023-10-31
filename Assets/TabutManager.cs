using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabutManager : MonoBehaviour
{
    public List<GameObject> spawnPos;
     public int liveEnemy,currentLiveEnemy;
    private void Awake()
    {
        spawnPos = new List<GameObject>();
        for (int i = 0; i < transform.childCount; i++)
        {
            spawnPos.Add(transform.GetChild(i).gameObject);
        }

        Invoke("SpawnSkelet",1);
        Invoke("SpawnSkelet",2);
    }

    public void SpawnSkelet()
    {
        for (int i = 0; i < spawnPos.Count; i++)
        {
            GameObject currentEnemy = Instantiate(Resources.Load("SkeletTabut")) as GameObject;
            if (currentEnemy != null)
            {
                currentEnemy.transform.position = spawnPos[i].transform.position;
                currentEnemy.GetComponent<EnemyController>().lookRadius = 30;
                currentEnemy.GetComponent<CharacterAnimator>().isTabut = true;
                liveEnemy++;
            }
        }
    }

    public void DeadEnemy()
    {
        currentLiveEnemy++;
        if (currentLiveEnemy >= liveEnemy)
        {
            GetComponentInParent<BossManager>().DisablesSpawnSkeletSkill();
        }
    }
}