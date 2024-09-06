using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Cinemachine;
using GameAnalyticsSDK.Setup;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class value : MonoBehaviour
{
    public Slider Slider;
    private void Start()
    {
        
    }

    // Start is called before the first frame update
    public void UpdateValue()
    {
        //GetComponent<TextMeshProUGUI>().text = Slider.value.ToString();
    }

    public void updateX()
    {
        // var cm = GameManager.instance.playerVCam;
        // var cmf = cm.GetComponent<CinemachineTransposer>();
        // cmf.m_BindingMode = CinemachineTransposer.BindingMode.WorldSpace;
        // cmf.m_FollowOffset = new Vector3(Slider.value,0,0);
    }
}
