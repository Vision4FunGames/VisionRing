using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossRaidSpawnEnemy : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject[] enemyPrefab; // Spawn edilecek düşman prefabı
    public float spawnRadius = 10f; // Yarıçap
    public int maxAttempts = 10; // Rastgele nokta arama deneme sayısı
    public int numberOfEnemiesToSpawn = 3;
    int spawned = 0;
    private int killCount=0;
    void SpawnEnemy()
    {
        spawned = 0;

        for (int i = 0; i < maxAttempts && spawned < numberOfEnemiesToSpawn; i++)
        {
            Vector2 randomCircle = Random.insideUnitCircle * spawnRadius;
            Vector3 randomPosition = playerTransform.position + new Vector3(randomCircle.x, 0, randomCircle.y);

            NavMeshHit hit;
            if (NavMesh.SamplePosition(randomPosition, out hit, 2f, NavMesh.AllAreas))
            {
                int rand = Random.Range(0, enemyPrefab.Length);
                GameObject currentEnemy = Instantiate(enemyPrefab[rand], hit.position, Quaternion.identity);
                currentEnemy.transform.SetParent(transform);
                currentEnemy.GetComponent<EnemyStats>().damage.baseValue =
                    currentEnemy.GetComponent<EnemyStats>().damage.baseValue * 2;
                spawned++;
            }
        }

        if (spawned < numberOfEnemiesToSpawn)
        {
            Debug.LogWarning("Tüm düşmanlar spawn edilemedi, yeterli NavMesh alanı yok.");
        }
    }

    public void KillEnemy()
    {
        killCount++;
        Debug.Log("AAAAAAA----");
        if (killCount == spawned)
        {
            Debug.Log("AAAAAAA");
            killCount = 0;
            SpawnEnemy();
        }
    }
    // Örnek olarak test için: G tuşuna basınca enemy spawn et
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SpawnEnemy();
        }
    }
}