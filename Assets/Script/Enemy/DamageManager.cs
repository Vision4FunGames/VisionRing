using System;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class DamageManager : MonoBehaviour
{
    public GameObject bomb;
    public EnemyStats characterStats;
    private DropChest dropChest;
    private EnemyController enemyController;
    private GhostAnimator ghostAnimator;
    private ParticleSystem ballParticleSystem;

    private void Start()
    {
        if (GetComponent<SphereCollider>())
            GetComponent<SphereCollider>().enabled = false;
        enemyController = GetComponentInParent<EnemyController>();
        dropChest = GetComponentInParent<DropChest>();
        characterStats = GetComponentInParent<EnemyStats>();
        if (GetComponent<GhostAnimator>())
        {
            ghostAnimator = GetComponent<GhostAnimator>();
            ballParticleSystem = ghostAnimator.transform.GetComponentInChildren<ParticleSystem>();
        }
     
    }

    public void ShieldAttack()
    {
        Player.instance.BackDoMove(gameObject);
    }
    public void PlayerDamage()
    {
        if (Player.instance.isDamageable)
        {
            enemyController.target.GetComponent<PlayerHealth>().DamageAnimation(characterStats.damage.GetValue());
        }
        
    }

    public void PlayerCharge()
    {
        enemyController.target.GetComponent<PlayerHealth>().DamageAnimation(characterStats.damage.GetValue() * 14 / 10);
    }

    public void ChestDrop()
    {
        if (dropChest != null)
            dropChest.ChestDrop(transform.position);
    }

    public void WaitBall()
    {
        enemyController.GetComponentInChildren<Animator>().speed = 0;
        ballParticleSystem.Play();
        ballParticleSystem.transform.DOKill();
        
        ballParticleSystem.transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), 1f).OnComplete((() => StartAnim()));
        enemyController.GetComponent<NavMeshAgent>().speed = 0;
        //enemyController.GetComponentInChildren<Animator>().speed = 0;
        
    }
    public void StopAnim()
    {
        GetComponentInParent<EnemyStats>().die = true;
        enemyController.GetComponent<NavMeshAgent>().speed = 0;
        enemyController.GetComponentInChildren<Animator>().speed = 0;
        GameObject circleParentObj = transform.root.GetChild(1).gameObject;
        circleParentObj.SetActive(true);
        circleParentObj.transform.GetChild(1).transform.localScale = new Vector3(0, 0, 0);
        circleParentObj.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 2f)
            .OnComplete((() =>Destroy(circleParentObj.gameObject)));
        Invoke("StartAnim", 2);
    }

    public void StartAnim()
    {
        enemyController.GetComponentInChildren<Animator>().speed = 1;
       
    }

    public void closeBallPart()
    {
        if (ballParticleSystem)
        {
            ballParticleSystem.transform.localScale=Vector3.zero;
            ballParticleSystem.Stop();
            enemyController.GetComponent<NavMeshAgent>().speed = 6;
        }
    }

    public void DeathEnemy()
    {
        Destroy(transform.parent.gameObject, 3);
    }

    public void BombExp()
    {
        
        GetComponent<SphereCollider>().enabled = true;
        ParticleSystem bombParticle = Instantiate(ParticleManager.instance.bombparticle);
        bombParticle.transform.localScale = new Vector3(6, 6, 6);
        bombParticle.gameObject.transform.position = transform.position;
        Invoke("closeTrigger",.1f);
        bomb.SetActive(false);
        Destroy(gameObject, 5);
    }

    public void closeTrigger()
    {
        GetComponent<SphereCollider>().enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerDamage();
        }
    }

    //Coffin for Boss
    public void SkeletSpawn()
    {
    }
}