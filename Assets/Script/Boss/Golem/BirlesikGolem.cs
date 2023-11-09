using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class BirlesikGolem : MonoBehaviour
{
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
    
    private void Start()
    {
        _cameraShake = FindObjectOfType<CameraShake>();
        animator = GetComponentInChildren<Animator>();
        rateOfFire = 5;
        player = FindObjectOfType<Player>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
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
        animator.SetFloat ("runspeed", navMeshAgent.velocity.magnitude/navMeshAgent.speed,.1f,Time.deltaTime);
        navMeshAgent.SetDestination(player.transform.position);
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
}