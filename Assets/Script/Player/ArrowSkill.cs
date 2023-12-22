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
        ArrowSkilStart();
    }

    [Button("Arrow Start")]
    public void ArrowSkilStart()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy");

        GameObject[] boss = GameObject.FindGameObjectsWithTag("Boss");
        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (gameObjects[i].GetComponent<BoxCollider>())
                _particleSystem.trigger.AddCollider(gameObjects[i].GetComponent<BoxCollider>());
        }

        for (int i = 0; i < boss.Length; i++)
        {
            if (boss[i].GetComponent<BoxCollider>())
                _particleSystem.trigger.AddCollider(boss[i].GetComponent<BoxCollider>());
        }
    }
}