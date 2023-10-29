using UnityEngine;

public class BossDetect : MonoBehaviour
{
    private BossManager bossManager;
    private PlayerAttack playerAttack;
    private void Awake()
    {
        playerAttack = FindObjectOfType<PlayerAttack>();
        bossManager = GetComponent<BossManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
            bossManager.BossTakeSwordDamage(playerAttack.damage);
        }
    }
}
