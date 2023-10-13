using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{
    private void OnDestroy()
    {
        FindObjectOfType<TornadoExit>().TornadoExitFunc();
    }

    private void OnDisable()
    {
        FindObjectOfType<TornadoExit>().TornadoExitFunc();
    }
}
