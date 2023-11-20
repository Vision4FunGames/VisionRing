using UnityEngine;
using DamageNumbersPro;

public class PlayerHealth : CharacterHealth
{
    Material _playerMaterial;
    [HideInInspector] public GameObject _damageNumbersPro;
    private void Awake()
    {
        health = 100;
        _playerMaterial = Resources.Load("PlayerMaterial/boy1") as Material;
        _damageNumbersPro = Resources.Load("Spread Up") as GameObject;
    }

    public void DamageAnimation(int damage)
    {
        if (!useShield)
        {
            TakeDamage(damage);
            DamageText(damage);
            PlayerManager.instance.DamageHitParticle();
        }
    }

    public void DamageText(int damage)
    {
        DamageNumber newDamageNumber =
            _damageNumbersPro.GetComponent<DamageNumber>().Spawn(
                new Vector3(transform.position.x, transform.position.y, transform.position.z),
                damage);
    }
}