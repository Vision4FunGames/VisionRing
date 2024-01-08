using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAnimatorController : MonoBehaviour
{
    private Spider spider;
    // Start is called before the first frame update
    void Start()
    {
        spider = GetComponentInParent<Spider>();
    }

    public void AttackNearEnd()
    {
        
    }

    public void AttackNear()
    {
        spider.attack = false;
        spider.player.GetComponent<PlayerHealth>().DamageAnimation(10);
        spider.navMeshAgent.isStopped = false;
        spider.currentAttackTimer = 0;
    }

    public void AttackFar()
    {
        spider.currentAttackTimer = 0;
        spider.attack = false;
        spider.navMeshAgent.isStopped = false;
    }
    
}
