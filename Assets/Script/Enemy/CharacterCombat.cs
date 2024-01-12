using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour
{
    private PlayerHealth _player;
    public float attackRate = 1f;
    public float attackCountdown = 0f;
    private float attackCooldown = 1f;
    public event System.Action OnAttack;
    
    CharacterStats myStats;
    CharacterStats enemyStats;
    
    void Start ()
    {
        _player = FindObjectOfType<PlayerHealth>();
        myStats = GetComponent<CharacterStats>();
    }
    private void Update()
    {
        attackCountdown -= Time.deltaTime;
    }
    public void Attack (CharacterStats enemyStats)
    {
        if (attackCountdown <= 0f && myStats.currentHealth > 0)
        {
            attackCountdown = attackRate;
            this.enemyStats = enemyStats;
            if (OnAttack != null) {
                OnAttack ();
            }
        }
    }

    public void Attack()
    {
        if (attackCountdown <= 0f && myStats.currentHealth > 0)
        {
            attackCountdown = attackRate;
            if (OnAttack != null) {
                OnAttack ();
            }
        }
    }
    
    IEnumerator DoDamage(CharacterStats stats, float delay) {
        print ("Start");
        yield return new WaitForSeconds (delay);
        Debug.Log (transform.name + " swings for " + myStats.damage.GetValue () + " damage");
        enemyStats.TakeDamage (myStats.damage.GetValue ());
    }
}
