using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour
{
    public Animator animator;
    [HideInInspector] public bool isTabut;
    NavMeshAgent navmeshAgent;
    CharacterCombat combat;
    private EnemyStats enemyStats;
    private int attackCounter = 0;

    protected virtual void Start()
    {
        navmeshAgent = GetComponent<NavMeshAgent>();
        combat = GetComponent<CharacterCombat>();
        enemyStats = GetComponent<EnemyStats>();
        combat.OnAttack += OnAttack;
        enemyStats.OnDie += DieAnimation;
    }

    protected virtual void Update()
    {
        animator.SetFloat("runspeed", navmeshAgent.velocity.magnitude / navmeshAgent.speed, .1f, Time.deltaTime);
    }

    protected virtual void OnAttack()
    {
        if (attackCounter % 3 == 0)
        {
            animator.SetTrigger("Attack");
        }
        else
        {
            int rand = Random.Range(0, 30);
            if (rand < 10 && rand >= 0)
                animator.SetTrigger("Attack");
            else if(rand>=10 && rand<20)
                animator.SetTrigger("Attack2");
            else if(rand>=20 && rand<30)
                animator.SetTrigger("Attack3");
        }

        attackCounter++;
    }

    protected virtual void DieAnimation()
    {
        if (isTabut)
        {
            FindObjectOfType<TabutManager>().DeadEnemy();
        }

        GetComponent<Collider>().enabled = false;
        enemyStats.die = true;
        animator.SetTrigger("death_");
        navmeshAgent.speed = 0;
        enemyStats.mmProgressBar.gameObject.SetActive(false);
        if (GetComponentInParent<TornadoExit>())
        {
            GetComponent<Enemy>().TornadoFinish();
        }
    }
}