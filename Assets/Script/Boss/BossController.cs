using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Update = UnityEngine.PlayerLoop.Update;

public class BossController : MonoBehaviour
{
    private CharacterStats myStats;
    private Animator bossAnim;
    private void Start()
    {
        myStats = GetComponent<CharacterStats>();
        bossAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (myStats.currentHealth <= 50)
        {
            bossAnim.SetTrigger("SkeletSpawn");
        }
        
    }
}
