using System.Collections;
using System.Collections.Generic;
using Exoa.TutorialEngine;
using UnityEngine;

public class TutoCage : MonoBehaviour
{
    public GameObject[] enemies;
    private Animator anim;
    private int enemyCount;
    void Start()
    {
        enemyCount = enemies.Length;
        anim = GetComponent<Animator>();
    }

    public void EnemyDied()
    {
        enemyCount--;
        if (enemyCount == 0)
        {
            anim.SetTrigger("Open");
            GetComponent<Collider>().isTrigger = true;
            GameManager.instance.foxManager.EnableAgent();
        }
        
        if (enemyCount ==6)
        {
            TutorialLoader.instance.Load("Ring");    
        }

     
    }
    
}
