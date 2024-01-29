using System;
using System.Collections.Generic;
using AmazingAssets.DynamicRadialMasks;
using UnityEngine;
using Random = UnityEngine.Random;

public class EndlessSkelet : MonoBehaviour
{
    public int currentEnemy;
    public int enemyCount;
    public float currentTime;
    public float radius;
    public List<GameObject> enemyPrefabList;
    DrmEnemyChange drmEnemyChange;
    private DRMGameObject drmGameObject;

    private void Awake()
    {
        drmGameObject = FindObjectOfType<DRMGameObject>();
        drmEnemyChange = FindObjectOfType<DrmEnemyChange>();
    }

    public void Update()
    {
        if (currentEnemy < enemyCount)
        {
            currentTime += Time.deltaTime;
            if (currentTime > 2)
            {
                currentTime = 0;
                EnemySpawn();
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = new Color(1, 1, 1, 0.5f);
        Gizmos.DrawSphere(transform.position, radius);
    }

    public void EnemySpawn()
    {
        Vector3 tempPos = (Random.insideUnitSphere * radius);
        currentEnemy++;
        tempPos.y = 0;
        int rnd = Random.Range(0, enemyPrefabList.Count);
        GameObject _currentEnemy = Instantiate(enemyPrefabList[rnd], transform.TransformPoint(tempPos),
            Quaternion.identity, transform);
        drmEnemyChange.EnemyVariationsList.Add(_currentEnemy.GetComponent<EnemyVariations>());
        if (drmGameObject.increaseEnes &&
            _currentEnemy.GetComponent<EnemyVariations>().EnemyVariation == EnemyVariation.Variation2)
            _currentEnemy.SetActive(true);
        if (!drmGameObject.increaseEnes &&
            _currentEnemy.GetComponent<EnemyVariations>().EnemyVariation == EnemyVariation.Variation1)
            _currentEnemy.SetActive(true);
        //_currentEnemy.transform.localPosition = new Vector3(tempPos.x,0,tempPos.z);
    }

    public void DeadEnemy()
    {
        if (currentEnemy > 0)
            currentEnemy--;
    }
}