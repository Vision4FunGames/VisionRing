using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class EnemySpawner : PuzzleConditionTrigger
{
    public Transform navMeshPlane;
    public SpawnOptions[] spawnOptions;
    public GameObject spawnParticle;
    public GameObject[] enemies;
    public PuzzleSpawnType PuzzleSpawnType;

    private float spawntHeigt =>
        transform.TransformPoint(BoxCollider.center - Vector3.up * (BoxCollider.size.y * 0.5f)).y;

    public BoxCollider BoxCollider;

    private void Start()
    {
        if (!GetComponent<PuzzleConditionController>())
            gameObject.AddComponent<PuzzleConditionController>();
        if (PuzzleSpawnType == PuzzleSpawnType.Start)
        {
            SpawnEnemy();
        }
    }

    public void OnValidate() => SetupPlane();

    [Button]
    public void SetupPlane()
    {
        var pos = BoxCollider.center;
        navMeshPlane.transform.localPosition = pos;
        var childPos = navMeshPlane.transform.position;
        childPos.y = spawntHeigt + 0.1f;
        navMeshPlane.transform.position = childPos;
        navMeshPlane.transform.localScale = new Vector3(BoxCollider.size.x, 1.1f, BoxCollider.size.z);
    }

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

    public Transform testPrefab;

    [Button]
    public void SpawnTest()
    {
        var spawned = Instantiate(testPrefab, transform);
        var pos = GetPoint();
        spawned.transform.localPosition = pos;

        var cp = spawned.transform.position;
        cp.y = spawntHeigt;
        spawned.transform.position = cp;
    }

    private void SpawnEnemy()
    {

        for (int i = 0; i < spawnOptions.Length; i++)
        {
            for (int j = 0; j < spawnOptions[j].spawnCount; j++)
            {
                for (int k = 0; k < enemies.Length; k++)
                {
                    if (enemies[k].GetComponent<EnemyStats>().SpawnEnemyType == spawnOptions[i].spawnType)
                    {
                        var enemy = Instantiate(enemies[k]);
                        enemy.GetComponent<NavMeshAgent>().enabled = false;
                        enemy.transform.SetParent(transform);
                        enemy.transform.localPosition = GetPoint();
                        enemy.gameObject.GetComponent<EnemyVariations>().EnemyVariation = EnemyVariation.Variation1;
                        var currentPos = enemy.transform.position;
                        currentPos.y = spawntHeigt;
                        enemy.transform.position = currentPos;
                        enemy.GetComponent<NavMeshAgent>().enabled = true;
                        enemy.transform.Bounce(.3f);
                       
                        var sp = Instantiate(spawnParticle, enemy.transform.position, Quaternion.identity);
                        Destroy(sp, 3.0f);
                        break;
                    }
                }


            }
        }

    }

    private Vector3 GetPoint()
    {
        var size = BoxCollider.size;
        var randomLocalX = Random.Range(-size.x / 2, size.x / 2);
        var randomLocalZ = Random.Range(-size.z / 2, size.z / 2);
        return new Vector3(randomLocalX, 0, randomLocalZ);
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
    BombSkeleton,
    MiniSkeleton,
    Ghost,
    GoblinBomb,
    GoblinBow,
    GoblinSword,
    Spider
}

public enum PuzzleSpawnType
{
    Trigger,
    Start
}

public static class BounceExtensions
{
    public static void Bounce(this Transform targetTransform, float bounceTime = 0.1f, bool randomDelay = false,
        float delay = 0.1f)
    {
        Vector3 defaultScale = targetTransform.localScale;
        targetTransform.localScale = Vector3.zero;
        targetTransform.gameObject.SetActive(true);
        float delayTime = randomDelay ? delay : 0;
        targetTransform.DOScale(defaultScale, bounceTime).SetDelay(Random.Range(delayTime / 4f, delayTime));
    }

    public static void CloseBounce(this Transform targetTransform, float bounceTime = 0.1f, bool destroy = false,
        float delay = 0)
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