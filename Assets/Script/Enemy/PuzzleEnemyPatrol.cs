using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

public class PuzzleEnemyPatrol : MonoBehaviour
{
    [FormerlySerializedAs("NavMeshAgent")] public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        
    }
}
