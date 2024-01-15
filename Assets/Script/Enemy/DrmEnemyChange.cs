using System;
using System.Collections;
using System.Collections.Generic;
using AmazingAssets.DynamicRadialMasks;
using Exoa.TutorialEngine;
using NaughtyAttributes;
using UnityEngine;

public class DrmEnemyChange : MonoBehaviour
{
    private DRMGameObject _drmGameObject;
    public GameObject[] enemies;
    private float timer, rate = 0.1f;
    bool increas = false;
    public List<GameObject> enemyList;
    public TutoCage _tutoCage;
    private void Start()
    {
        InıtializeEnemy();
        if (_tutoCage)
        {
            TutorialInitialize();
        }
        _drmGameObject = GetComponent<DRMGameObject>();
    }

    private void TutorialInitialize()
    {
        for (int i = 0; i < _tutoCage.enemies.Length; i++)
        {
            enemyList.Add(enemies[i]);
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > rate)
        {
            if (TutorialLoader.instance.loadedTutorialName == "Ring")
            {
                KillTheEnemies();
            }
            else
            {
                VariationChange();
            }
          
        }
        
            
    }

    private void KillTheEnemies()
    {
        timer = 0;
        for (int i = 0; i < enemyList.Count; i++)
        {
            if (enemyList[i] != null)
            {
                if (Vector3.Distance(enemyList[i].transform.position, transform.position) < _drmGameObject.radius)
                {
                    enemyList[i].GetComponent<EnemyStats>().Die();
                    enemyList.RemoveAt(i);
                } 
            }
           
        }
    }

    public void VariationChange()
    {
        timer = 0;
        if (_drmGameObject.increaseEnes)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (Vector3.Distance(enemies[i].transform.position, transform.position) < _drmGameObject.radius &&
                    enemies[i].GetComponent<Enemy>().myVariation == EnemyVariation.Variation2)
                {
                    enemies[i].gameObject.SetActive(true);
                }

                if (Vector3.Distance(enemies[i].transform.position, transform.position) < _drmGameObject.radius &&
                    enemies[i].GetComponent<Enemy>().myVariation == EnemyVariation.Variation1)
                {
                    enemies[i].gameObject.SetActive(false);
                }
            }

            increas = true;
        }

        if (!_drmGameObject.increaseEnes)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (Vector3.Distance(enemies[i].transform.position, transform.position) > _drmGameObject.radius&&
                    enemies[i].GetComponent<Enemy>().myVariation == EnemyVariation.Variation2)
                {
                    enemies[i].gameObject.SetActive(false);
                }

                if (Vector3.Distance(enemies[i].transform.position, transform.position) > _drmGameObject.radius &&
                    enemies[i].GetComponent<Enemy>().myVariation == EnemyVariation.Variation1)
                {
                    enemies[i].gameObject.SetActive(true);
                }
            }
            increas = false;
        }
        
      
    }

    public void InıtializeEnemy()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i].GetComponent<Enemy>().myVariation == EnemyVariation.Variation2)
                enemies[i].gameObject.SetActive(false);
        }
    }
}