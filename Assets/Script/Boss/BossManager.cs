using System;
using DamageNumbersPro;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.AI;

public class BossManager : MonoBehaviour
{
    [HideInInspector] public bool isSkeletsLive;
    [HideInInspector] public bool bossSpecialSkelet;
    [HideInInspector] public GameObject _damageNumbersPro;


    private BossMovement bossMovement;
    private BossCombat bossCombat;
    public ParticleSystem footParticle;
    public GameObject tabuts;
    private float bossBaseHealth;
    private Canvas mainCanvas;
    public NavMeshAgent navMeshAgent;
    private bool sleep;
    private Player player;
    public ParticleSystem stunParticle;
    private bool isStunned;
    public float bossHealth;
    public MMProgressBar mmProgressBar;
    public ParticleSystem _shieldParticle;
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        bossCombat = GetComponent<BossCombat>();
        bossBaseHealth = bossHealth;
        player = FindObjectOfType<Player>();
        bossMovement = GetComponent<BossMovement>();
        _damageNumbersPro = Resources.Load("Spread Up") as GameObject;
        mainCanvas = GameObject.FindWithTag("mainCanvas").GetComponent<Canvas>();
    }

    private void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 40 && !sleep)
        {
            WakeUp();
        }
    }

    public void WakeUp()
    {
        sleep = true;
        navMeshAgent.enabled = true;
        mmProgressBar.gameObject.SetActive(true);
    }

    public void BossTakeSwordDamage(int damage)
    {
        if (bossHealth > 0 && !isSkeletsLive)
        {
            if (isStunned)
            {
                bossHealth -= damage;
                ShowDamageText(damage * 100);
                mmProgressBar.UpdateBar(bossHealth, 0, 100);
            }
            else
            {
                bossHealth -= (damage / 10);
                ShowDamageText(damage * 10);
                mmProgressBar.UpdateBar(bossHealth, 0, 100);
            }

            CheckBossHealth();
        }
    }

    public void CheckBossHealth()
    {
        if (bossHealth < bossBaseHealth / 2 && !bossSpecialSkelet)
        {
            GetComponentInChildren<Animator>().Play("SkeletSpawn");
        }

        if (bossHealth <= 0)
        {
            DeadBoss();
        }
    }

    public void DeadBoss()
    {
        navMeshAgent.speed = 0;
        bossMovement.enabled = false;
        GetComponent<Collider>().enabled = false;
        GetComponentInChildren<Animator>().Play("Dead");
    }
    public void SpawnSkelet()
    {
        _shieldParticle.Play();
        isSkeletsLive = true;
        bossSpecialSkelet = true;
        tabuts.SetActive(true);
        navMeshAgent.speed = 0;
    }

    public void DisablesSpawnSkeletSkill()
    {
        isSkeletsLive = false;
        tabuts.SetActive(false);
        navMeshAgent.speed = 2;
        bossCombat.StunDisable();
        _shieldParticle.Stop();

    }

    public void ShowDamageText(int damage)
    {
        DamageNumber newDamageNumber =
            _damageNumbersPro.GetComponent<DamageNumber>().Spawn(
                new Vector3(transform.position.x, transform.position.y+6, transform.position.z),
                damage);
    }
}