using System;
using System.Collections;
using DamageNumbersPro;
using DG.Tweening;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class BirlesikGolem : MonoBehaviour
{
    private Collider _collider;
    private bool dead;
    public int health;
    private int baseHealth;
    public bool sleep = true;
    private Player player;
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    private float distance;
    private bool attack;
    public float currentAttackTime, rateOfFire;
    public ParticleSystem earthQuake;
    public ParticleSystem explosion;
    private CameraShake _cameraShake;
    private IEnumerator cameraShake;
    private bool move;
    private float currentMovementTime;
    private float AttackTwoSpeed = 20;
    private MMProgressBar healthBar;
    private GameObject _damageNumbersPro;
    public Transform ust, alt;
    private SkinnedMeshRenderer[] _skinnedMeshRenderers;
    private bool damageAttack;

    private void Start()
    {
        _collider = GetComponentInChildren<Collider>();
        _skinnedMeshRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
        baseHealth = health;
        _cameraShake = FindObjectOfType<CameraShake>();
        animator = GetComponentInChildren<Animator>();
        rateOfFire = 5;
        player = FindObjectOfType<Player>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        _damageNumbersPro = Resources.Load("Spread Up") as GameObject;
        MMProgressBar prefab = Resources.Load<MMProgressBar>("BirlesikGolem");
        if (prefab != null)
        {
            healthBar = Instantiate(prefab, FindObjectOfType<ShopUI>().transform, false);
            healthBar.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError("BirlesikGolem prefab'ı bulunamadı veya yüklenemedi!");
        }
    }

    private void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
        if (!dead)
            CheckBoss();
    }

    public void CheckBoss()
    {
        if (sleep)
        {
            if (distance < 50)
            {
                sleep = false;
            }
        }
        else
        {
            if (!attack && !move)
            {
                Movement();
                currentAttackTime += Time.deltaTime;
                if (currentAttackTime > rateOfFire)
                {
                    currentAttackTime = 0;
                    Attack();
                }
            }

            if (attack && move)
            {
                Movement();
                currentMovementTime += Time.deltaTime;
                if (currentMovementTime > 3)
                {
                    StopAttack();
                }
            }
        }
    }

    public void Movement()
    {
        animator.SetFloat("runspeed", navMeshAgent.velocity.magnitude / navMeshAgent.speed, .1f, Time.deltaTime);
        if (player && navMeshAgent.enabled)
            navMeshAgent.SetDestination(player.transform.position);
    }

    public void ShowText(int damage)
    {
        DamageNumber newDamageNumber =
            _damageNumbersPro.GetComponent<DamageNumber>().Spawn(
                new Vector3(transform.position.x, transform.position.y + 6, transform.position.z),
                damage);
        newDamageNumber.transform.localScale = new Vector3(4, 4, 4);
    }


    public void TakeDamage(int damage)
    {
        GetComponentInChildren<Collider>().enabled = false;
        DamageMaterial();
        ShowText(damage);
        health -= damage;
        healthBar.UpdateBar(health, 0, baseHealth);
        if (health < baseHealth / 2)
        {
            GetComponent<Collider>().enabled = false;
            navMeshAgent.enabled = false;
            animator.Play("Ayrilma");
            dead = true;

            Invoke("SpawnGolems", 2);
        }
    }

    public void DamageMaterial()
    {
        for (int i = 0; i < _skinnedMeshRenderers.Length; i++)
        {
            int index = i;
            _skinnedMeshRenderers[i].material.DOColor(Color.red, .1f).SetEase(Ease.Linear)
                .OnComplete((() =>
                    _skinnedMeshRenderers[index].material.DOColor(Color.white, .1f).SetEase(Ease.Linear)));
        }
    }

    public void SpawnGolems()
    {
        earthQuake.transform.localPosition = new Vector3(0, 0, -16);
        earthQuake.Play();
        ust.gameObject.SetActive(true);
        alt.gameObject.SetActive(true);
        ust.SetParent(null);
        alt.SetParent(null);
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        if (healthBar)
            healthBar.gameObject.SetActive(false);
    }

    #region Attack

    public void EarthQuakeAndShake()
    {
        _collider.enabled = false;
        _collider.enabled = true;
        damageAttack = true;
        CancelInvoke("DisableDamageAttack");
        Invoke("DisableDamageAttack", 1);
        earthQuake.Play();
        cameraShake = _cameraShake.Shake(.6f, 1);
        StartCoroutine(cameraShake);
    }

    public void DisableDamageAttack()
    {
        damageAttack = false;
    }

    public void Attack()
    {
        attack = true;

        if (distance < 40)
        {
            int rand = Random.Range(0, 20);
            if (rand < 10)
            {
                AttackOne();
            }
            else
            {
                AttackTwo();
            }
        }
        else
        {
            AttackTwo();
        }
    }

    public void StopAttack()
    {
        damageAttack = false;
        var main = earthQuake.main;
        main.loop = false;
        currentMovementTime = 0;
        currentAttackTime = 0;
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        navMeshAgent.speed = 5;
        move = false;
        attack = false;
        animator.Play("Blend Tree");
        StopCoroutine(cameraShake);
        earthQuake.Stop();
    }

    public void AttackOne()
    {
        navMeshAgent.speed = 0;
        animator.Play("Attack1");
    }

    public void AttackTwo()
    {
        animator.Play("AttackTwoHazirlik");
    }

    public void MovementAttack()
    {
        _collider.enabled = false;
        _collider.enabled = true;
        damageAttack = true;
        navMeshAgent.speed = 35;
        cameraShake = _cameraShake.Shake(2, 1);
        StartCoroutine(cameraShake);
        var main = earthQuake.main;
        main.loop = true;
        move = true;
        earthQuake.Play();
    }

    #endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
            TakeDamage(player.GetComponent<PlayerAttack>().damage);
        }

        if (other.CompareTag("Player") && damageAttack)
        {
            player.GetComponent<PlayerManager>().Stun(gameObject);
            player.GetComponent<PlayerHealth>().TakeDamage(10);
            if (move)
                StopAttack();
        }
    }
}