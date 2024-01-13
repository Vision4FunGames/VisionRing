using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleArrayModifier : MonoBehaviour
{
    public Vector3 side;
    public bool refresh;

    public void OnValidate()
    {
        if (!refresh) return;
        for (int i = 0; i < transform.childCount; i++)
        {
            var target = transform.GetChild(i);

            var targetPos = Vector3.zero + side * i;

            target.transform.localPosition = targetPos;
        }
    }
}
