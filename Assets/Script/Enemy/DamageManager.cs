using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public EnemyStats characterStats;
    private DropChest dropChest;
    private EnemyController enemyController;
    private void Start()
    {
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

    public void DeathEnemy()
    {
        Destroy(transform.parent.gameObject, 3);
    }

    //Coffin for Boss
    public void SkeletSpawn()
    {
    }
}