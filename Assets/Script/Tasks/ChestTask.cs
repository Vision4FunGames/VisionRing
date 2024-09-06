using System;
using TaskSystem;
using UnityEngine;

public class ChestTask : MonoBehaviour
{
    private Player player;
    private bool partOne;
    private void OnEnable()
    {
        player = FindObjectOfType<Player>();
        GetComponentInChildren<Waypoint_Indicator>().enabled = true;
        GetComponentInChildren<Waypoint_Indicator>().task = true;
    }


    private void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 50 && !partOne) // burası değiscek sandığa yaklasmaya devam etmemiz gerek açılmasın hemen
        {
            partOne = true;
            var box = TaskPanelController.instance.GetLastMainTask();
            box.infoText.text = "OpenTheChest";
        }

        if (Vector3.Distance(player.transform.position, transform.position) < 10 && partOne)
        {
             GetComponent<TaskPrefab>().isCompleted = true;
             Destroy(transform.gameObject, 3f);
        }
    }
}
