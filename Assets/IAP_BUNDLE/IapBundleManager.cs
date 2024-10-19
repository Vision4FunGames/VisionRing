using EasyUI.PickerWheelUI;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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

    public void ShowLuckySpin(RewardPackType rewardsPackType,int duration, UnityAction<Reward> action)
    {
        luckySpin.SetActive(true);
        pickerWheel.SetRewards(rewardsPackType, duration, action);

    }


    public void Result(Reward action)
    {
        Debug.Log("Win  " + action.rewardType.ToString());
    }
}
