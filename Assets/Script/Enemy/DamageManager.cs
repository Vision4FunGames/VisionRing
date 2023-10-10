using System;
using System.Collections;
using System.Collections.Generic;
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
        _playerHealth.DamageAnimation(characterStats.damage.GetValue());
    }

    public void PlayerCharge()
    {
        //buraya yazacan ne yazacaksan
    }
}
