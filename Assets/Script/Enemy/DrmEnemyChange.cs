using System;
using System.Collections;
using System.Collections.Generic;
using AmazingAssets.DynamicRadialMasks;
using Exoa.TutorialEngine;
using NaughtyAttributes;
using UnityEngine;

public class DrmEnemyChange : MonoBehaviour
{
    public DRMGameObject _drmGameObject;
    public EnemyVariations[] enemies;
    public List<EnemyVariations> EnemyVariationsList;
    public GameObject[] boss;
    private float timer, rate = 0.1f;
    bool increas = false;

    private void Start()
    {
        _drmGameObject = GetComponent<DRMGameObject>();
       InıtializeEnemy();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > rate)
        {
            VariationChange();
        }
    }


    public void VariationChange()
    {
        timer = 0;
        if (_drmGameObject.increaseEnes)
        {
            for (int i = 0; i < EnemyVariationsList.Count; i++)
            {
                if (EnemyVariationsList[i] != null)
                {
                    if (Vector3.Distance(EnemyVariationsList[i].transform.position, transform.position) <
                        _drmGameObject.radius)
                    {
                        Debug.Log("0");
                        EnemyVariationsList[i].VariationChange(0);
                    }
                }
            }
            increas = true;
        }

        if (!_drmGameObject.increaseEnes)
        {
            for (int i = 0; i < EnemyVariationsList.Count; i++)
            {
                if (EnemyVariationsList[i] != null)
                {
                    if (Vector3.Distance(EnemyVariationsList[i].transform.position, transform.position) >
                        _drmGameObject.radius)
                    {
                        Debug.Log("1");
                        EnemyVariationsList[i].VariationChange(1);
                    }                       
                }
                
            }
        
            increas = false;
        }
    }

    public void InıtializeEnemy()
    {
        enemies = FindObjectsOfType<EnemyVariations>();

        for (int i = 0; i < enemies.Length; i++)
        {
            EnemyVariationsList.Add(enemies[i]);
        }
       
    }
}