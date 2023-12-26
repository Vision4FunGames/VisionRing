using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private PlayerAttack playerAttack;

    private void Start()
    {
        playerAttack = FindObjectOfType<PlayerAttack>();
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<BoxCollider>().enabled =false;
            other.GetComponentInParent<Enemy>().DoJumpBack(gameObject,playerAttack.earthSkillDamage);
        }

        if (other.CompareTag("Boss"))
        {
            if (other.GetComponent<Golem1>())
            {
                other.GetComponent<Golem1>().TakeDamage(playerAttack.earthSkillDamage/10);
            }
            if (other.GetComponent<Golem2>())
            {
                other.GetComponent<Golem2>().TakeDamage(playerAttack.earthSkillDamage/10);
            }
            if (other.GetComponent<BirlesikGolem>())
            {
                other.GetComponent<BirlesikGolem>().TakeDamage(playerAttack.earthSkillDamage/10);
            }
            if (other.GetComponent<BossManager>())
            {
                other.GetComponent<BossManager>().BossTakeSwordDamage(playerAttack.earthSkillDamage/10);
            }
        }
    }
}