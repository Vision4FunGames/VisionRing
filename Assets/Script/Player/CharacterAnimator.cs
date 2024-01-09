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
    public bool shied;

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
        if (navmeshAgent.velocity.magnitude / navmeshAgent.speed >= 0)
            animator.SetFloat("runspeed", navmeshAgent.velocity.magnitude, .1f, Time.deltaTime);
    }

    protected virtual void OnAttack()
    {
        if (enemyStats.enemyType != EnemyType.kingSkelet)
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
                else if (rand >= 10 && rand < 20)
                    animator.SetTrigger("Attack2");
                else if (rand >= 20 && rand < 30)
                    animator.SetTrigger("Attack3");
            }

            attackCounter++;
        }
        else
        {
            if (!shied)
            {
                shied = true;
                if (attackCounter % 3 == 0)
                {
                    GetComponent<NavMeshAgent>().speed = 0;
                    animator.SetBool("shield", false);

                    animator.SetTrigger("Attack");

                    CancelInvoke("ShieldClose");
                    Invoke("ShieldClose", 5f);
                }
                else
                {
                    ShieldClose();
                    int rand = Random.Range(0, 40);
                    if (rand < 10 && rand >= 0)
                        animator.SetTrigger("Attack2");
                    else if (rand >= 10 && rand < 20)
                        animator.SetTrigger("Attack2");
                    else if (rand >= 20 && rand < 30)
                        animator.SetTrigger("Attack3");
                    else if (rand >= 30 && rand < 40)
                        animator.Play("Shieldattack");
                }

                attackCounter++;
            }
        }
    }

    public void ShieldClose()
    {
        navmeshAgent.speed = 6;
        shied = false;
        animator.SetBool("shield", true);
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