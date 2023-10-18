using UnityEngine;

public class DamageManager : MonoBehaviour
{
    private PlayerHealth _playerHealth;
    public EnemyStats characterStats;
    private void Start()
    {
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
    
    public void DeathEnemy()
    {
        Destroy(transform.parent.gameObject,3);
    }
}
