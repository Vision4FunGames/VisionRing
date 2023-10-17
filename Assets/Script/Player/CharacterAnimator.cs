using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CharacterAnimator : MonoBehaviour
{
    public Animator animator;

    NavMeshAgent navmeshAgent;
    CharacterCombat combat;
    private EnemyStats enemyStats;
    private int attackCounter = 0;
    protected virtual void Start() {
        navmeshAgent = GetComponent<NavMeshAgent> ();
        combat = GetComponent<CharacterCombat> ();
        enemyStats = GetComponent<EnemyStats>();
        combat.OnAttack += OnAttack;
        enemyStats.OnDie += DieAnimation;
    }

    protected virtual void Update () {
        animator.SetFloat ("runspeed", navmeshAgent.velocity.magnitude/navmeshAgent.speed,.1f,Time.deltaTime);
    }

    protected virtual void OnAttack() {

        
        if (attackCounter % 3 == 0)
        {
           animator.SetTrigger("Charge");
        }
        else
        {
            animator.SetTrigger ("Attack");
        }
        attackCounter++;
    }

    protected virtual void DieAnimation()
    {
        animator.SetTrigger("death_");
        navmeshAgent.speed = 0;
        enemyStats.mmProgressBar.gameObject.SetActive(false);   
        Destroy(gameObject,3);
    }
}
