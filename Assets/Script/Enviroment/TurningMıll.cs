using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningMıll : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.GetChild(0).Rotate(new Vector3(transform.localRotation.x + Time.deltaTime *20f,0,0));
        transform.GetChild(1).Rotate(new Vector3(transform.localRotation.x + Time.deltaTime *20f,0,0));
    }
}
