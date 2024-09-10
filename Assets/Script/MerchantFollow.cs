using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MerchantFollow : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Player player;
    private Animator animator;

    private void OnEnable()
    {
        animator = GetComponent<Animator>();
        transform.SetParent(null);
        player = FindObjectOfType<Player>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.enabled = true;
    }

    private void Update()
    {
        if (player)
        {
            if (navMeshAgent.velocity.magnitude / navMeshAgent.speed >= 0)
                animator.SetFloat("Blend", navMeshAgent.velocity.magnitude, .1f, Time.deltaTime);
            navMeshAgent.SetDestination(player.transform.position);
        }
    }
}