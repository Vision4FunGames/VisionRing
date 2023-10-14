using System;
using System.Collections.Generic;
using UnityEngine;

public class TornadoExit : MonoBehaviour
{
    public List<GameObject> enemies;

    private void Awake()
    {
        enemies = new List<GameObject>();
    }

    public void TornadoExitFunc()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            enemies[i].GetComponentInChildren<DetectEnemyCollider>().TornadoFinish();
        }
    }
}