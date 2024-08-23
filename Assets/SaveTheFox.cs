using System;
using UnityEngine;

public class SaveTheFox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Solar"))
        {
            GetComponent<Waypoint_Indicator>().enabled = true;
        }
    }
}
