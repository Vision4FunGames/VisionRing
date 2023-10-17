using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class DetectEnemyCollider : MonoBehaviour
{
    private NavMeshAgent na;
    private Animator animator;
    private EnemyController enemyController;
    private EnemyStats _enemyStats;
    private PlayerAttack _playerAttack;
    private Collider collider;
    private Rigidbody rb;

    private void Awake()
    {
        na = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        enemyController = GetComponent<EnemyController>();
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();
        _enemyStats = GetComponent<EnemyStats>();
        _playerAttack = Player.instance.GetComponent<PlayerAttack>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tornado"))
        {
            TornadoStart(other.gameObject);
        }

        if (other.CompareTag("RotateFire"))
        {
            _enemyStats.TakeDamage(_playerAttack.damage);
        }

        if (other.CompareTag("SwordCollider"))
        {
            _enemyStats.TakeDamage(_playerAttack.damage);
        }

        if (other.CompareTag("Floor"))
        {
            rb.isKinematic = true;
        }
    }


    public void TornadoStart(GameObject _tornado)
    {
        if (!_enemyStats.die)
        {
            na.enabled = false;
            collider.enabled = false;
            enemyController.enabled = false;
            FindObjectOfType<TornadoExit>().EnemyAdd(gameObject);
            animator.SetTrigger("tornado");
            transform.SetParent(_tornado.GetComponentInParent<Player>().transform.GetChild(2));
            rb.isKinematic = true;
            transform.DOMoveY(transform.position.y + 5, Random.Range(4, 10));
        }
    }

    public void TornadoFinish()
    {
        transform.DOKill();
        enemyController.enabled = true;
        FindObjectOfType<TornadoExit>().EnemyRemove(gameObject);
        AddForce();
    }

    public void AddForce()
    {
        transform.SetParent(null);
        rb.isKinematic = false;
        collider.enabled = true;
        Vector3 direction = transform.position - _playerAttack.transform.position;
        rb.AddForce(direction * 50);
    }
}