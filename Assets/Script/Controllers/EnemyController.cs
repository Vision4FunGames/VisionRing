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
    private GameManager _gameManager;
    private float retrieveDistance = 3f;
    public bool attack;
    [HideInInspector] public bool bombActiveted;
    [HideInInspector] public bool bombexp;
    private Enemy enemy;
    private CharacterAnimator characterController;
    void Start()
    {
        enemy = GetComponent<Enemy>();
        _gameManager = FindObjectOfType<GameManager>();
        _enemyStats = GetComponent<EnemyStats>();
        target = Player.instance.transform;
        agent = GetComponent<NavMeshAgent>();
        combatManager = GetComponent<CharacterCombat>();
        characterController = GetComponent<CharacterAnimator>();
    }

    void Update()
    {
        // Get the distance to the player
        if (target)
        {
            distance = Vector3.Distance(target.position, transform.position);
        }


        // If inside the radius
        if (distance <= lookRadius && agent != null && !_enemyStats.die && _gameManager.gameState != GameState.GameOver)
        {
            if (_enemyStats.enemyType == EnemyType.Ghost)
            {
                if (target)
                {
                    if (distance < enemy.radius)
                    {
                        agent.isStopped = false;
                        attack = false;
                        Vector3 geriCekilmeYonu = transform.position - Player.instance.transform.position;
                        geriCekilmeYonu = geriCekilmeYonu.normalized * retrieveDistance;
                        Vector3 yeniHedef = transform.position + geriCekilmeYonu;
                        agent.SetDestination(yeniHedef);
                    }
                    else
                    {
                        agent.isStopped = true; // Agent'ı durdur
                        agent.velocity = Vector3.zero; // Hareketi sıfırla
                        attack = true; // Ateş etmeye başla
                        // Geri çekilme mesafesi kadar geriye doğru git

                        combatManager.Attack(Player.instance.GetComponent<PlayerStats>());
                        FaceTarget();
                    }
                }
            }
            else
            {
                if (target)
                    agent.SetDestination(target.position);
                else
                {
                    target = Player.instance.transform;
                    agent.SetDestination(target.position);
                }

                if (distance <= agent.stoppingDistance && !characterController.shied)
                {
                    // Attack
                    combatManager.Attack(Player.instance.GetComponent<PlayerStats>());
                    FaceTarget();
                }
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