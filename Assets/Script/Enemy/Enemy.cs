using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
public enum EnemyVariation
{
    Variation1,
    Variation2
}

[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable
{
    #region Variables

    public EnemyVariation myVariation;
    private EnemyController enemyController;
    private Animator animator;
    private Rigidbody rb;
    private Collider collider;
    private float health;
    private PlayerAttack playerAttack;
    private NavMeshAgent navMeshAgent;
    private EnemyStats _enemyStats;
    private PlayerManager playerManager;
    private CharacterStats myStats;

    #endregion

    private void Start()
    {
        enemyController = GetComponent<EnemyController>();
        animator = GetComponentInChildren<Animator>();
        playerAttack = FindObjectOfType<PlayerAttack>();
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<Collider>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        _enemyStats = GetComponent<EnemyStats>();
        playerManager = PlayerManager.instance;
        myStats = GetComponent<CharacterStats>();
    }

    public override void Interact()
    {
        base.Interact();
        CharacterCombat playerCombat = playerManager.GetComponent<CharacterCombat>();
        if (playerCombat != null)
        {
            playerCombat.Attack(myStats);
        }
    }

    public void DoJumpBack(GameObject dir, int damage)
    {
        myStats.TakeDamage(damage);
        Vector3 direction = transform.position - dir.transform.position;
        direction = new Vector3(direction.x, 0, direction.z);
        transform.DOKill();
        transform.DOJump(direction * 2, 6, 1, 1)
            .OnComplete((() => transform.GetChild(0).GetComponent<Collider>().enabled = true));
    }

    public void TornadoStart(GameObject _tornado)
    {
        if (!_enemyStats.die)
        {
            navMeshAgent.enabled = false;
            collider.enabled = false;
            enemyController.enabled = false;
            FindObjectOfType<TornadoExit>().EnemyAdd(gameObject);
            animator.SetBool("tornado", true);
            transform.SetParent(_tornado.GetComponentInParent<Player>().transform.GetComponentInChildren<TornadoExit>().transform);
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
        Vector3 direction = transform.position - playerAttack.transform.position;
        rb.AddForce(direction * 50);
        animator.SetBool("tornado", false);
    }

    public void AddDomoveBack()
    {
        transform.DOKill();
        navMeshAgent.enabled = false;
        Vector3 direction = transform.position - playerAttack.transform.position;
        direction = new Vector3(direction.x, 0, direction.z);
        direction = Vector3.ClampMagnitude(direction, 2);
        transform.DOMove(transform.position+(direction), 1).OnComplete(() => navMeshAgent.enabled = true);
    }
}