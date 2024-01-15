using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMovableBox : PuzzleConditionTrigger
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
            isConditionCompleted = true;
    }
}
