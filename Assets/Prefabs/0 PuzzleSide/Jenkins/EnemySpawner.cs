using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using NaughtyAttributes;
using TMPro;
using UnityEditor;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public SpawnOptions[] spawnOptions;
    public GameObject spawnParticle;

    private float spawntHeigt => transform.TransformPoint(BoxCollider.center - Vector3.up * (BoxCollider.size.y * 0.5f)).y;
    public BoxCollider BoxCollider;


    #region Garbage[Deleteable]
    public GameObject testPrefab;

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