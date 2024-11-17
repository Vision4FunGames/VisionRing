using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlaytimeRewardsPanel : MonoBehaviour
{
    public TextMeshProUGUI dailyPlaytimeTxt;
    float lastControlTime;
    TimeSpan timeSpan;
    bool ready = false;
    private void OnEnable()
    {
        ready = true;
        StartCoroutine(ControlTime());
    }
    private void OnDisable()
    {
        ready = false;
    }


    void Update()
    {
        if (Time.time >= lastControlTime + 1)
        {
            lastControlTime = Time.time;
            timeSpan = TimeSpan.FromSeconds(PlaytimeRewardsManager.instance.dailyPlaytime);
            dailyPlaytimeTxt.text = timeSpan.Minutes + ":" + timeSpan.Seconds;
        }

    }


    IEnumerator ControlTime()
    {
        while (ready)
        {
            Control();
            yield return new WaitForSeconds(1);
        }
    }


    public void Control()
    {
        PlaytimeRewardsManager.instance.RewardControl();
    }


}
