using System;
using DamageNumbersPro;
using MoreMountains.Tools;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    [HideInInspector] public bool isSkeletsLive;
    [HideInInspector] public bool bossSpecialSkelet;
    [HideInInspector] public GameObject _damageNumbersPro;


    public ParticleSystem footParticle;
    public GameObject tabuts;
    private float bossBaseHealth;
    private Canvas mainCanvas;
    private BossMovement bossMovement;
    private bool sleep;
    private Player player;
    public ParticleSystem stunParticle;
    private bool isStunned;
    public float bossHealth;
    public MMProgressBar mmProgressBar;
    public ParticleSystem _shieldParticle;
    private void Awake()
    {
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
        bossMovement.navMeshAgent.enabled = true;
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
    }

    public void SpawnSkelet()
    {
        _shieldParticle.Play();
        isSkeletsLive = true;
        bossSpecialSkelet = true;
        tabuts.SetActive(true);
        bossMovement.navMeshAgent.speed = 0;
    }

    public void DisablesSpawnSkeletSkill()
    {
        isSkeletsLive = false;
        tabuts.SetActive(false);
        bossMovement.navMeshAgent.speed = 2;
        bossMovement.StunDisable();
        _shieldParticle.Stop();

    }

    public void ShowDamageText(int damage)
    {
        DamageNumber newDamageNumber =
            _damageNumbersPro.GetComponent<DamageNumber>().Spawn(
                new Vector3(transform.position.x, transform.position.y, transform.position.z),
                damage);
    }
}