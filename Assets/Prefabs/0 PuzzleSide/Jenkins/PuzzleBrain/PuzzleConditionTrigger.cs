using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PuzzleConditionTrigger : MonoBehaviour
{
    public bool isConditionCompleted;
    public void MarkAsCompleted()
    {
        isConditionCompleted = true;
        PuzzleEventManager.OnNewRespawnPointObtained.Invoke(transform.position);
        gameObject.SetActive(false);
    }
}
