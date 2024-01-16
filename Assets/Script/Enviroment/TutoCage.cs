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
            UiManager.instance.ringBtn.gameObject.SetActive(true);
            TutorialLoader.instance.Load("Ring");
            PlayerPrefs.SetInt("Ring",1);
        }
    }

    public void AllEnemyDie()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i] != null)
            {
            enemies[i].GetComponent<EnemyStats>().Die();              
            }
        }
    }
    
}
