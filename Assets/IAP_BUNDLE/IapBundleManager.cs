using EasyUI.PickerWheelUI;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IapBundleManager : MonoBehaviour
{
    public RewardList rewardList;
    [SerializeField] private GameObject luckySpin;
    [SerializeField] private PickerWheel pickerWheel;


    public static IapBundleManager instance;

    private void Awake()
    {
        instance = this;
    }


    [Button]
    public void ShowLuckySpin()
    {
        luckySpin.SetActive(true);
        pickerWheel.SetRewards(RewardPackType.Forest, 3, Result);
        
    }



    public void Result(Reward action)
    {
        Debug.Log("Win  " + action.rewardType.ToString());
    }
}
