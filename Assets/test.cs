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
            other.GetComponent<Collider>().enabled =false;
            other.GetComponentInParent<Enemy>().DoJumpBack(gameObject,playerAttack.earthSkillDamage);
        }
    }
}