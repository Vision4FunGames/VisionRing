using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outlineManager : MonoBehaviour
{
    [Range(0,1)] public float faded;
    public static event Action<float> outlineChaner;

    public void OnValidate()
    {
        if (outlineChaner != null) outlineChaner(faded);
    }
}
