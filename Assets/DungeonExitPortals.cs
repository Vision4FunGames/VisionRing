using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonExitPortals : MonoBehaviour
{
    public GameObject exitPortal;
    
    public int taskCount;
    private int currentTaskCount;

    public void dungeonTaskCheck()
    {
        currentTaskCount++;
        if (currentTaskCount >= taskCount)
        {
            exitPortal.gameObject.SetActive(false);
            exitPortal.GetComponent<Waypoint_Indicator>().enabled = true;
            exitPortal.GetComponent<Collider>().enabled = true;
            exitPortal.GetComponent<TeleportScene>().task = true;
        }
    }
}
