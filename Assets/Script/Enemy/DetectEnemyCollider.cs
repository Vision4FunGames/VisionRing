using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Random = UnityEngine.Random;

public class DetectEnemyCollider : MonoBehaviour
{
    private EnemyStats _enemyStats;
    private PlayerAttack _playerAttack;

    private void Awake()
    {
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
    }


    public void TornadoStart(GameObject _tornado)
    {
        GetComponent<EnemyController>().enabled = false;
        Vector3 target = transform.position - _tornado.transform.position;
        target = new Vector3(target.x, 10, target.z);
        //transform.DOMove(target * 4, Random.Range(1, 3));
        GetComponentInChildren<Animator>().SetTrigger("tornado");
        transform.SetParent(_tornado.GetComponentInParent<Player>().transform.GetChild(2));
        transform.DOMoveY(transform.position.y + 10, Random.Range(4, 10)).OnComplete((() =>
        {
        }));
    }
}