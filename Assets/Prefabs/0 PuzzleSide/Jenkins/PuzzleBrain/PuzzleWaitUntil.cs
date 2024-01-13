using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public abstract class PuzzleWaitUntil : MonoBehaviour
{
    public bool waitStart;
    public bool waitEnd;
    public PuzzleConditionTrigger[] connectedTrigger;
    public abstract void OnStepComplete();

    public void Awake()
    {
        StartCoroutine(WaitUntilCondition());
    }


    public IEnumerator WaitUntilCondition()
    {
        waitStart = true;
        Debug.LogWarning(gameObject.name + "WaitStarted", this);
        yield return new WaitUntil(() => connectedTrigger.All(trigger => trigger.isConditionCompleted));
        waitEnd = true;
        OnStepComplete();
    }
}
