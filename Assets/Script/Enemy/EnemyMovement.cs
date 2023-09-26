using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum enemySpawnType
{
    tabut,
    yerden,
    normal
}

public enum enemyType
{
    King,
    Mini,
    Standart
}
public class EnemyMovement : MonoBehaviour
{
    #region variables

    public bool walk;
    private Animator animator;
    private List<SkinnedMeshRenderer> _skinList = new List<SkinnedMeshRenderer>();
    [HideInInspector] public NavMeshAgent navMeshAgent;
    #endregion
    public enemySpawnType myenemySpawnType;
    public enemyType myEnemyType;


    private void Start()
    {
        
        #region  Initialize

        animator = GetComponentInChildren<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        #endregion
        if (myenemySpawnType == enemySpawnType.tabut)
        {
            walk = true;
            animator.SetBool("spawType", false);
        }
        else if (myenemySpawnType == enemySpawnType.yerden)
        {
            if ((myEnemyType == enemyType.Mini) || (myEnemyType == enemyType.King))
            {
                for (int i = 0; i < transform.GetChild(0).transform.childCount; i++)
                {
                    if (transform.GetChild(0).transform.GetChild(i).GetComponent<SkinnedMeshRenderer>() != null)
                    {
                        _skinList.Add(transform.GetChild(0).transform.GetChild(i).GetComponent<SkinnedMeshRenderer>());
                    }
                }

                foreach (var skinmesh in _skinList)
                {
                    skinmesh.enabled = false;
                }
            }
            else
            {
                GetComponentInChildren<SkinnedMeshRenderer>().enabled = false;
                if (GetComponentInChildren<MeshRenderer>() != null)
                    GetComponentInChildren<MeshRenderer>().enabled = false;
            }

            animator.SetBool("spawType", true);
            animator.speed = 0;
        }
        else
        {
            walk = true;
            animator.SetBool("spawType", false);
        }
        navMeshAgent.enabled = false;
        navMeshAgent.enabled = true;
    }
}
