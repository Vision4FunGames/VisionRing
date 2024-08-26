using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseInstinctSkill : MonoBehaviour
{
    private void OnEnable()
    {
        UiManager.instance.sonarBtn.gameObject.SetActive(true);
        FindObjectOfType<PlayerManager>().SolarSystem.solarSystemtutorial = true;
    }
}
