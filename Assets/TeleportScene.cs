using System;
using UnityEngine;

public class TeleportScene : MonoBehaviour
{
    private TeleportManager tp;
    public int sceneName;

    private void Awake()
    {
        tp = FindObjectOfType<TeleportManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tp.DungeonScene(sceneName);
        }
    }
}
