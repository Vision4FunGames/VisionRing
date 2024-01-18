using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMovableBox : PuzzleConditionTrigger
{
    public float distance;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            //isConditionCompleted = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            distance = Vector3.Distance(transform.position, other.transform.position);
            if (Vector3.Distance(transform.position, other.transform.position) < 1f)
                isConditionCompleted = true;
        }
    }
}