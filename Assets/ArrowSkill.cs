using System;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class ArrowSkill : MonoBehaviour
{
    private ParticleSystem _particleSystem;
    private List<ParticleCollisionEvent> _collisionEvents;

    private void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
        _collisionEvents = new List<ParticleCollisionEvent>();
    }
    
    [Button("Arrow Start")]
    public void ArrowSkilStart()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy");

        for (int i = 0; i < gameObjects.Length; i++)
        {
            _particleSystem.trigger.AddCollider(gameObjects[i].GetComponent<Collider>());
        }
      
    }
    
}