using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Clone : MonoBehaviour
{
    private Animator _animator;
    private Player _player;
    private NavMeshAgent _navMeshAgent;
    public List<GameObject> enemies;
    private EnemyStats _enemyStats;

    public CharacterHealth.DieDelegate OnDie;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        _animator.SetFloat("Blend", _navMeshAgent.velocity.magnitude / _navMeshAgent.speed, .1f, Time.deltaTime);
        Movement();
    }

    public void Movement()
    {
        _navMeshAgent.SetDestination(_player.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (!enemies.Contains(other.gameObject))
            {
                EnemyListAdd(other.gameObject);
                other.GetComponent<EnemyStats>().OnDie += EnemyRemove;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (enemies.Contains(other.gameObject))
                EnemyListRemove(other.gameObject);
        }
    }

    public void EnemyListAdd(GameObject _enemy)
    {
        enemies.Add(_enemy);
    }

    public void EnemyListRemove(GameObject _enemy)
    {
        enemies.Add(_enemy);
    }

    public void EnemyRemove()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (!enemies[i].activeSelf)
            {
                enemies.RemoveAt(i);
            }
        }
    }
}