using System;
using UnityEngine;

public class ChestTask : MonoBehaviour
{
    private Player player;
    private void OnEnable()
    {
        player = FindObjectOfType<Player>();
        GetComponentInChildren<Waypoint_Indicator>().enabled = true;
        GetComponentInChildren<Waypoint_Indicator>().task = true;
    }


    private void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 50) // burası değiscek sandığa yaklasmaya devam etmemiz gerek açılmasın hemen
        {
           // GetComponent<TaskPrefab>().isCompleted = true;
           // Destroy(transform.gameObject, 1f);
        }
    }
}
