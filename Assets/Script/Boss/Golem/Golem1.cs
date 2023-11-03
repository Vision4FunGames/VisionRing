using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Golem1 : MonoBehaviour
{
    public float detectRadius;
    private Animator _animator;
    private Player _player;
    private float _distance;
    private bool _sleep = true;
    [HideInInspector] public bool _attack;
    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        _player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        _distance = Vector3.Distance(_player.transform.position, transform.position);
        if (!_sleep && _distance < detectRadius)
        {
            _sleep = true;
        }

        if (_sleep && !_attack)
        {
            Attack();
        }
    }

    public void Attack()
    {
        _attack = true;
        transform.DOLookAt(_player.transform.position, .5f);
        _animator.Play("AttackHazirlik");
    }

    public void MovementAttack()
    {
       print("İleri");
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectRadius);
    }
}