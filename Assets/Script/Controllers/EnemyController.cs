using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;
    private EnemyStats _enemyStats;
    [HideInInspector] public Transform target;
    NavMeshAgent agent;
    CharacterCombat combatManager;
    private float distance;
    void Start()
    {
        _enemyStats = GetComponent<EnemyStats>();
        target = Player.instance.transform;
        agent = GetComponent<NavMeshAgent>();
        combatManager = GetComponent<CharacterCombat>();
    }

    void Update()
    {
        // Get the distance to the player
        if (target)
        {
            distance = Vector3.Distance(target.position, transform.position);
        }
          

        // If inside the radius
        if (distance <= lookRadius && agent != null && !_enemyStats.die)
        {
            if (target)
                agent.SetDestination(target.position);
            else
            {
                target = Player.instance.transform;
                agent.SetDestination(target.position);
            }
            if (distance <= agent.stoppingDistance)
            {
                // Attack
                combatManager.Attack(Player.instance.GetComponent<PlayerStats>());
                FaceTarget();
            }
        }
    }

    // Point towards the player
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}