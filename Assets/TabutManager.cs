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
            Vector3 currentPos = new Vector3(spawnPos[i].transform.position.x, spawnPos[i].transform.position.y + 5,
                spawnPos[i].transform.position.z);
            GameObject currentEnemy = Instantiate(Resources.Load("SkeletTabut"),currentPos,Quaternion.identity,null) as GameObject;
            currentEnemy.GetComponent<EnemyController>().lookRadius = 30;
            currentEnemy.GetComponent<CharacterAnimator>().isTabut = true;
            liveEnemy++;
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