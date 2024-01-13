using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCrystalAnimation : PuzzleWaitUntil
{
    public void Start()
    {
        transform.GetChild(0).CloseBounce(0f);
    }
    public override void OnStepComplete()
    {
        transform.GetChild(0).Bounce(0.3f);
    }
}
