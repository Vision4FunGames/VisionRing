using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PingPongMover : MonoBehaviour
{
    public bool move;
    public float distance;
    public float speed = 5;

    public void OnEnable()
    {
        if (speed <= 0) speed = Mathf.Abs(speed);
        if (speed == 0) speed += 1;
        var t = Mathf.Abs(distance) / speed;
        transform.DOMoveX(distance, t).SetRelative().SetLoops(-1, LoopType.Yoyo);
    }
}
