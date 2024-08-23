using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterThePortal : MonoBehaviour
{
    private void OnEnable()
    {
        FindObjectOfType<TeleportManager>().isTutorial = true;
    }
}
