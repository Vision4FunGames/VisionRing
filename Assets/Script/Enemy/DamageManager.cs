using UnityEngine;

public class DamageManager : MonoBehaviour
{
    private PlayerHealth _playerHealth;
    public EnemyStats characterStats;
    private DropChest dropChest;

    private void Start()
    {
        dropChest = GetComponentInParent<DropChest>();
        characterStats = GetComponentInParent<EnemyStats>();
        _playerHealth = Player.instance.GetComponent<PlayerHealth>();
    }

    public void PlayerDamage()
    {
        Debug.Log("Start Function");
        _playerHealth.DamageAnimation(characterStats.damage.GetValue());
    }

    public void PlayerCharge()
    {
        _playerHealth.DamageAnimation(characterStats.damage.GetValue() * 14 / 10);
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