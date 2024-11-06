using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyAnArmour : MonoBehaviour
{
    public GameObject Maskcanvas;
    private void Start()
    {
        UiManager.instance.buyanarmortutorial = true;
    }

    public void OpenMask()
    {
        Maskcanvas.SetActive(true);
    }
}
