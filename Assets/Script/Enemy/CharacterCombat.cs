using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour
{
    public float attackRate = 1f;
    private float attackCountdown = 0f;
    public float attackDelay = .6f;
    public float attackSpeed = 1f;
    private float attackCooldown = 1f;
    public event System.Action OnAttack;
    
    CharacterStats myStats;
    CharacterStats enemyStats;
    
    void Start ()
    {
        myStats = GetComponent<CharacterStats>();
    }
    private void Update()
    {
        attackCountdown -= Time.deltaTime;
    }
    public void Attack (CharacterStats enemyStats)
    {
        if (attackCountdown <= 0f)
        {
            this.enemyStats = enemyStats;
            attackCountdown = 1f / attackRate;
            StartCoroutine(DoDamage(enemyStats,attackDelay));
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
