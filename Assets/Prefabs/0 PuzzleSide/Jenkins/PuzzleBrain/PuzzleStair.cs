using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PuzzleStair : PuzzleWaitUntil
{
    public AnimationType animationType;
    public Transform[] stairs;
    public void Start() => ModifyStairs();
    public override void OnStepComplete() => DropStairs();

    public Vector3[] initialTransform;

    public void DropStairs()
    {
        var operationCount = stairs.Length;
        for (int i = 0; i < operationCount; i++)
        {
            stairs[i].transform.Bounce(0.1f);
            stairs[i].transform.DOMove(initialTransform[i], 0.5f).SetDelay(i * 0.1f);
        }
    }

    public void ModifyStairs()
    {
        var operationCount = stairs.Length;
        initialTransform = new Vector3[operationCount];
        for (int i = 0; i < operationCount; i++)
        {
            initialTransform[i] = stairs[i].transform.position;
            if (animationType == AnimationType.TopToDown)
            {
                stairs[i].transform.position += Vector3.up * 20f;
                stairs[i].transform.CloseBounce(0f);
            }
            else if (animationType == AnimationType.DownToTop)
            {
                stairs[i].transform.position -= Vector3.up * 20f;
                stairs[i].transform.CloseBounce(0f);
            }
        }
    }
}

public enum AnimationType
{
    TopToDown,
    DownToTop
}
