using DamageNumbersPro;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    public ParticleSystem stunParticle;
    private bool isStunned;
    public float bossHealth;
    [HideInInspector] public GameObject _damageNumbersPro;

    private void Awake()
    {
        _damageNumbersPro = Resources.Load("Spread Up") as GameObject;
    }


    public void BossTakeSwordDamage(int damage)
    {
        if (isStunned)
        {
            bossHealth -= damage;
            ShowDamageText(damage*100);
        }
        else
        {
            bossHealth -= (damage / 10);
            ShowDamageText(damage*10);
        }
      
    }

    public void ShowDamageText(int damage)
    {
        DamageNumber newDamageNumber =
            _damageNumbersPro.GetComponent<DamageNumber>().Spawn(
                new Vector3(transform.position.x, transform.position.y, transform.position.z),
                damage);
    }
}
