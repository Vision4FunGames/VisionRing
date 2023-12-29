using System;
using UnityEngine;
using UnityEngine.AI;

public class DamageManager : MonoBehaviour
{
    public EnemyStats characterStats;
    private DropChest dropChest;
    private EnemyController enemyController;

    private void Start()
    {
        if (GetComponent<SphereCollider>())
            GetComponent<SphereCollider>().enabled = false;
        enemyController = GetComponentInParent<EnemyController>();
        dropChest = GetComponentInParent<DropChest>();
        characterStats = GetComponentInParent<EnemyStats>();
    }

    public void PlayerDamage()
    {
        enemyController.target.GetComponent<PlayerHealth>().DamageAnimation(characterStats.damage.GetValue());
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

    public void StopAnim()
    {
        GetComponentInParent<EnemyStats>().die = true;
        enemyController.GetComponent<NavMeshAgent>().speed = 0;
        enemyController.GetComponentInChildren<Animator>().speed = 0;
        Invoke("StartAnim", 2);
    }

    public void StartAnim()
    {
        enemyController.GetComponentInChildren<Animator>().speed = 1;
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
        Destroy(gameObject, 5);
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