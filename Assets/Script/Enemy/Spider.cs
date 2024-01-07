using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spider : MonoBehaviour
{
    private Animator animator;
    [HideInInspector] public NavMeshAgent navMeshAgent;
    [HideInInspector]public Player player;
    [HideInInspector] public float currentAttackTimer;
    public float distance;
    public bool attack;
    public float rateOfFire;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        player = FindObjectOfType<Player>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
        
        animator.SetFloat("runspeed", navMeshAgent.velocity.magnitude/navMeshAgent.speed, .1f, Time.deltaTime);
        currentAttackTimer += Time.deltaTime;
        if (distance < 10)
        {
            FaceTarget();
            if (currentAttackTimer > rateOfFire && !attack)
                AttackNear();
        }

        if (distance is > 10 and < 30)
        {
            FaceTarget();
            if (currentAttackTimer > rateOfFire * 2)
            {
                if (!attack)
                    AttackFar();
            }
            else
            {
                if (!attack)
                {
                    animator.SetFloat("runspeed", navMeshAgent.velocity.magnitude/navMeshAgent.speed, .1f, Time.deltaTime);
                    navMeshAgent.SetDestination(player.transform.position);
                }
            }
        }
    }

    public void FaceTarget()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    public void AttackNear()
    {
        attack = true;
        navMeshAgent.isStopped = true;
        animator.Play("AttackNear");
    }

    public void AttackFar()
    {
        attack = true;
        navMeshAgent.isStopped = true;
        animator.Play("AttackFar");
    }
}