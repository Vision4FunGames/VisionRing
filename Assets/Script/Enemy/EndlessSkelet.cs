using System.Collections.Generic;
using UnityEngine;

public class EndlessSkelet : MonoBehaviour
{
   
    [HideInInspector]public int currentEnemy;
    public int enemyCount;
    [HideInInspector]public float currentTime;
    public float radius;
    public List<GameObject> enemyPrefabList;
    

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
        Gizmos.color = new Color(1,1,1,0.5f);
        Gizmos.DrawSphere(transform.position, radius);
    }
    public void EnemySpawn()
    {
        Vector3 tempPos = (Random.insideUnitSphere * radius);
        tempPos.y = 0;
        int rnd = Random.Range(0, enemyPrefabList.Count);
        GameObject _currentEnemy = Instantiate(enemyPrefabList[rnd],transform.TransformPoint(tempPos),Quaternion.identity,transform);
        //_currentEnemy.transform.localPosition = new Vector3(tempPos.x,0,tempPos.z);
        currentEnemy++;
    }
    public void DeadEnemy()
    {
        currentEnemy--;
    }
}