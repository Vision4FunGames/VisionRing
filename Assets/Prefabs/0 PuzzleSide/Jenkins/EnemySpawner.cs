using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using DG.Tweening;
using NaughtyAttributes;
using TMPro;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public SpawnOptions[] spawnOptions;
    public GameObject spawnParticle;
    public GameObject[] enemies;
    public PuzzleSpawnType PuzzleSpawnType;

    private float spawntHeigt =>
        transform.TransformPoint(BoxCollider.center - Vector3.up * (BoxCollider.size.y * 0.5f)).y;

    public BoxCollider BoxCollider;
    private GameObject enemyPrefab;

    #region Garbage[Deleteable]

    public GameObject testPrefab;

    private void Start()
    {
        if (PuzzleSpawnType== PuzzleSpawnType.Start)
        {
            SpawnEnemy();
        }
        
    }
    

    [Button]
    public void HeightTest()
    {
        var so = EditorUtility.InstantiatePrefab(testPrefab) as GameObject;
        var targetPos = transform.position;
        targetPos.y = spawntHeigt;
        so.transform.position = targetPos;
        so.transform.SetParent(transform, true);
        so.transform.Bounce(0.3f);
        var sp = Instantiate(spawnParticle, so.transform.position, Quaternion.identity);
        Destroy(sp, 3.0f);
    }

    #endregion

    private void OnDrawGizmos()
    {
        var color = Color.red;
        color.a = 0.3f;
        Gizmos.color = color;
        Matrix4x4 oldGizmosMatrix = Gizmos.matrix;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawCube(BoxCollider.center, BoxCollider.size);
        Gizmos.matrix = oldGizmosMatrix;
    }

    [Button]
    private void SpawnEnemy()
    {
        if (spawnOptions!=null)
        {
            for (int i = 0; i < spawnOptions.Length; i++)
            {
                for (int j = 0; j < spawnOptions[i].spawnCount; j++)
                {
                    for (int k = 0; k < enemies.Length; k++)
                    {
                        if (enemies[i].GetComponent<EnemyStats>().SpawnEnemyType == spawnOptions[i].spawnType)
                        {
                            enemyPrefab = enemies[i];
                            Debug.Log(enemyPrefab);
                            var enemy = Instantiate(enemies[i], new Vector3(transform.position.x + Random.Range(-15f, 15f),
                                spawntHeigt, transform.position.z + Random.Range(-15f, 15f)),Quaternion.identity);
                            enemy.transform.SetParent(transform, true);
                            enemy.transform.Bounce(.3f);
                            var sp = Instantiate(spawnParticle, enemy.transform.position, Quaternion.identity);
                            Destroy(sp, 3.0f);
                            break;
                        }
                    }

                    
                }
            }
        }
    }
}
[System.Serializable]
public class SpawnOptions
{
    public SpawnEnemyType spawnType;
    public int spawnCount;
    public Vector2 levelRange;
}


public enum SpawnEnemyType
{
    Null,
    Skeleton,
    Another1,
    Another2
}

public enum PuzzleSpawnType
{
    Trigger,
    Start
}
public static class BounceExtensions
{
    public static void Bounce(this Transform targetTransform, float bounceTime = 0.1f, bool randomDelay = false, float delay = 0.1f)
    {
        Vector3 defaultScale = targetTransform.localScale;
        targetTransform.localScale = Vector3.zero;
        targetTransform.gameObject.SetActive(true);
        float delayTime = randomDelay ? delay : 0;
        targetTransform.DOScale(defaultScale, bounceTime).SetDelay(Random.Range(delayTime / 4f, delayTime));
    }
    public static void CloseBounce(this Transform targetTransform, float bounceTime = 0.1f, bool destroy = false, float delay = 0)
    {
        Vector3 defaultScale = targetTransform.localScale;
        targetTransform.DOScale(Vector3.zero, bounceTime).SetDelay(delay).OnComplete(() =>
        {
            targetTransform.localScale = defaultScale;
            targetTransform.gameObject.SetActive(false);
            if (destroy)
            {
                GameObject.Destroy(targetTransform.gameObject);
            }
        });
    }
}