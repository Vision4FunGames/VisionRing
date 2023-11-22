using System;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.AI;

public class Clone : MonoBehaviour
{
    private Animator _animator;
    private Player _player;
    private NavMeshAgent _navMeshAgent;
    public List<GameObject> enemies;
    private EnemyStats _enemyStats;
    [HideInInspector] public bool attack;
    private CloneAttack cloneAttack;
    private float timer;
    private float clearTimer = .5f;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
        _animator = GetComponentInChildren<Animator>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.enabled = true;
        cloneAttack ??= _animator.gameObject.AddComponent<CloneAttack>();
    }

    private void Update()
    {
        _animator.SetFloat("Blend", _navMeshAgent.velocity.magnitude / _navMeshAgent.speed, .1f, Time.deltaTime);
        Movement();

        timer += Time.deltaTime;
        if (timer > clearTimer)
            EnemyRemove();
    }

    public void Movement()
    {
        if (enemies.Count > 0 && enemies[0] != null &&
            Vector3.Distance(_player.transform.position, transform.position) < 20)
        {
            _navMeshAgent.SetDestination(enemies[0].transform.position);
            if (Vector3.Distance(transform.position, enemies[0].transform.position) < 6)
            {
                Attack();
            }
        }
        else
        {
            _navMeshAgent.SetDestination(_player.transform.position);
        }
    }

    public void Attack()
    {
        if (!attack)
        {
            attack = true;
            _animator.Play("Attack");
        }
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
            EnemyRemove(other.gameObject);
        }
    }

    public void EnemyListAdd(GameObject _enemy)
    {
        _enemy.GetComponent<EnemyController>().target = transform;
        enemies.Add(_enemy);
    }

    public void EnemyRemove(GameObject other)
    {
        enemies.Remove(other);
    }

    public void EnemyRemove()
    {
        timer = 0;
        enemies.RemoveAll(x => x == null);
        for (int i = 0; i < enemies.Count; i++)
        {
            if (!enemies[i].activeSelf || enemies[i].GetComponent<EnemyStats>().die)
            {
                enemies.RemoveAt(i);
            }
        }
    }
}

public class CloneAttack : MonoBehaviour
{
    private BoxCollider swordCollider;
    private Clone clone;

    private void Start()
    {
        GenerateSwordCollider();
        clone = GetComponentInParent<Clone>();
    }

    public void GenerateSwordCollider()
    {
        swordCollider ??= gameObject.AddComponent<BoxCollider>();
        swordCollider.size = new Vector3(10, 2, 10);
        swordCollider.center = new Vector3(0, 0, 5);
        swordCollider.enabled = false;
        swordCollider.tag = "SwordCollider";
        swordCollider.isTrigger = true;
    }

    public void EnableSwordCollider()
    {
        swordCollider.enabled = false;
        swordCollider.enabled = true;
    }

    public void DisableCollider()
    {
        clone.attack = false;
        swordCollider.enabled = false;
    }
}