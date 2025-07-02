using System;
using AmazingAssets.DynamicRadialMasks;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BossRaidSpawnEnemy : MonoBehaviour
{
    private int level;
    public Animator bossAnimator;
    public GameObject raidPanel;
    public float spawnTime;
    public float currentTime;
    public Transform playerTransform;
    public GameObject[] enemyPrefab;
    public Slider raidSlider;
    public TextMeshProUGUI raidLevelText; // Spawn edilecek düşman prefabı
    public float spawnRadius = 10f; // Yarıçap
    public int maxAttempts = 10; // Rastgele nokta arama deneme sayısı
    public int numberOfEnemiesToSpawn = 3;
    int spawned = 0;
    private int killCount = 0;
    public DRMGameObject DrmGameObject;

    private void Awake()
    {
        raidSlider.maxValue = spawnTime;
    }

    public void SpawnEnemy()
    {
        spawned = 0;
        bossAnimator.SetTrigger("attack");
        level++;
        raidLevelText.text = "Raid Level" + level;
        for (int i = 0; i < maxAttempts && spawned < numberOfEnemiesToSpawn; i++)
        {
            Vector2 randomCircle = Random.insideUnitCircle * spawnRadius;
            Vector3 randomPosition = playerTransform.position + new Vector3(randomCircle.x, 0, randomCircle.y);

            NavMeshHit hit;
            if (NavMesh.SamplePosition(randomPosition, out hit, 4f, NavMesh.AllAreas))
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

    public void KillAllEnemy()
    {
        for (int i = 0; i < spawned; i++)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }

        killCount = 0;
    }

    public void KillEnemy()
    {
        killCount++;
        if (killCount == spawned)
        {
            killCount = 0;
            SpawnEnemy();
        }
    }

    void Update()
    {
        if (raidPanel.activeSelf)
        {
            currentTime += Time.deltaTime;
            raidSlider.value = currentTime;
            if (currentTime > spawnTime)
            {
                currentTime = 0;
                SpawnEnemy();
            }
        }
    }
}