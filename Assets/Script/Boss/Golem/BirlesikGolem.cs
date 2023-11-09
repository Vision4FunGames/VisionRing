using System;
using System.Collections;
using DamageNumbersPro;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class BirlesikGolem : MonoBehaviour
{
    private bool dead;
    public int health, baseHealth;
    public bool sleep = true;
    private Player player;
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    private float distance;
    private bool attack;
    private float currentAttackTime, rateOfFire;
    public ParticleSystem earthQuake;
    public ParticleSystem explosion;
    private CameraShake _cameraShake;
    private IEnumerator cameraShake;
    private bool move;
    private float currentMovementTime;
    public float AttackTwoSpeed = 20;
    public MMProgressBar healthBar;
    public GameObject _damageNumbersPro;
    public Transform ust, alt;

    private void Start()
    {
        baseHealth = health;
        _cameraShake = FindObjectOfType<CameraShake>();
        animator = GetComponentInChildren<Animator>();
        rateOfFire = 5;
        player = FindObjectOfType<Player>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        _damageNumbersPro = Resources.Load("Spread Up") as GameObject;
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
            if (!attack)
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
                transform.Translate(Vector3.forward * AttackTwoSpeed * Time.deltaTime);
                currentMovementTime += Time.deltaTime;
                if (currentMovementTime > 2)
                {
                    StopAttack();
                }
            }
        }
    }

    public void Movement()
    {
        animator.SetFloat("runspeed", navMeshAgent.velocity.magnitude / navMeshAgent.speed, .1f, Time.deltaTime);
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
        ShowText(damage);
        health -= damage;
        healthBar.UpdateBar(health, 0, baseHealth);
        if (baseHealth > health)
        {
            GetComponent<Collider>().enabled = false;
            navMeshAgent.enabled = false;
            animator.Play("Ayrilma");
            dead = true;
            
            Invoke("SpawnGolems",2);
        }
    }

    public void SpawnGolems()
    {
        GameObject golem1 = Instantiate(Resources.Load("Golem") , ust.transform.position  , Quaternion.identity,null)  as GameObject;
        GameObject golem2 = Instantiate(Resources.Load("Golem - 2") , alt.transform.position  , Quaternion.identity,null)  as GameObject;
    }
    #region Attack

    public void EarthQuakeAndShake()
    {
        earthQuake.Play();
        cameraShake = _cameraShake.Shake(.6f, 1);
        StartCoroutine(cameraShake);
    }

    public void Attack()
    {
        attack = true;

        if (distance < 20)
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
    }

    public void StopAttack()
    {
        currentMovementTime = 0;
        currentAttackTime = 0;
        navMeshAgent.enabled = true;
        attack = false;
        move = false;
        animator.Play("Blend Tree");
        var main = earthQuake.main;
        main.loop = false;
        StopCoroutine(cameraShake);
        earthQuake.Stop();
    }

    public void AttackOne()
    {
        navMeshAgent.enabled = false;
        animator.Play("Attack1");
    }

    public void AttackTwo()
    {
        navMeshAgent.enabled = false;
        animator.Play("AttackTwoHazirlik");
    }

    public void MovementAttack()
    {
        navMeshAgent.enabled = false;
        cameraShake = _cameraShake.Shake(3, 1);
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
    }
}