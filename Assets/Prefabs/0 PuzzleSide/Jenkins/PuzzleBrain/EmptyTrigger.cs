using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyTrigger : PuzzleConditionTrigger
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isConditionCompleted = true;
            MarkAsCompleted();
        }
    }

}
