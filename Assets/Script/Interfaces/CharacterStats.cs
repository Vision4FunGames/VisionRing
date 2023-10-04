
using System;
using DamageNumbersPro;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public Stat damage;
    public Stat armor;
    public DamageNumber prefab;
    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth -= damage;
        DamageVFX(damage);
        Debug.Log(transform.name + "takes " + damage + "damage.");
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void DamageVFX(int damage)
    {
        DamageNumber newDamageNumber =
            prefab.Spawn(new Vector3(transform.position.x, transform.position.y, transform.position.z),
                damage);
        prefab.followedTarget = transform;
    }

public virtual void Die()
    {
       
    }
}
