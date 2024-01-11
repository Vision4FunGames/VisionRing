using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SpiderAnimatorController : MonoBehaviour
{
    private Spider spider;

    public GameObject spiderShootPoint;

    // Start is called before the first frame update
    void Start()
    {
        spider = GetComponentInParent<Spider>();
    }

    public void SpawnMini()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(Resources.Load<GameObject>("SpiderMini"), transform.position, Quaternion.identity, null);
        }

        spider.attack = false;
        spider.navMeshAgent.isStopped = false;
        spider.currentAttackTimer = 0;
    }

    public void AttackNearEnd()
    {
    }

    public void AttackNear()
    {
        spider.attack = false;
        if (!spider.mini)
            spider.player.GetComponent<PlayerHealth>().DamageAnimation(10);
        else
        {
            spider.player.GetComponent<PlayerHealth>().DamageAnimation(2);
        }
        spider.navMeshAgent.isStopped = false;
        spider.currentAttackTimer = 0;
    }

    public void AttackFar()
    {
        GameObject currentWeb = spider.GetWeb();
        currentWeb.SetActive(true);
        currentWeb.transform.position = spiderShootPoint.transform.position;
        currentWeb.GetComponent<spiderWeb>().SetParent(spider);
        currentWeb.transform.DOMove(spider.player.transform.position, 1f).OnComplete((() =>
        {
            GetComponentInChildren<ParticleSystem>().Play();
        }));
        spider.currentAttackTimer = 0;
        spider.attack = false;
        spider.navMeshAgent.isStopped = false;
    }
    public void DeathEnemy()
    {
        Destroy(transform.parent.gameObject, 3);
    }
}