using EasyUI.PickerWheelUI;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class IapBundleManager : MonoBehaviour
{
    public int refreshTime;
    public TextMeshProUGUI rewardPackName;
    public RewardList rewardList;
    [SerializeField] private GameObject luckySpin;
    [SerializeField] private PickerWheel pickerWheel;
    [SerializeField]
    private List<GridItem> gridItems;

    public static IapBundleManager instance;
    [SerializeField, ReadOnly] private List<int> tempIndexList;
    [SerializeField, ReadOnly] private List<int> selectedIndex;
    [SerializeField, ReadOnly] private List<Reward> selectedRewards;

    private void Awake()
    {
        instance = this;
    }

    [Button]
    public void ShowLuckySpin()
    {
        ShowLuckySpin(RewardPackType.Forest, 3, Result);

    }

    public void ShowLuckySpin(RewardPackType rewardsPackType, int duration, UnityAction<Reward> action)
    {
        luckySpin.SetActive(true);
        rewardPackName.text = rewardsPackType.ToString() + " Pack";

        for (int i = 0; i < rewardList.spinRewardPacks[(int)rewardsPackType].rewards.Count; i++)
        {
            gridItems[i].SetReward(rewardList.spinRewardPacks[(int)rewardsPackType].rewards[i]);
        }

        if (rewardList.spinRewardPacks[(int)rewardsPackType].rewards.Count < gridItems.Count)
        {
            for (int i = rewardList.spinRewardPacks[(int)rewardsPackType].rewards.Count; i < gridItems.Count; i++)
            {
                gridItems[i].Deactive();
            }
        }

        tempIndexList.Clear();
        selectedRewards.Clear();
        selectedIndex.Clear();
        for (int i = 0; i < rewardList.spinRewardPacks[(int)rewardsPackType].rewards.Count; i++)
        {
            tempIndexList.Add(i);
        }

        for (int i = 0; i < 8; i++)
        {
            int r = UnityEngine.Random.Range(0, tempIndexList.Count);
            selectedIndex.Add(tempIndexList[r]);
            tempIndexList.RemoveAt(r);
        }

        for (int i = 0; i < selectedIndex.Count; i++)
        {
            selectedRewards.Add(rewardList.spinRewardPacks[(int)rewardsPackType].rewards[selectedIndex[i]]);
            gridItems[selectedIndex[i]].Selected();
        }

        pickerWheel.SetRewards(selectedRewards, duration, action);

    }


    public void Result(Reward action)
    {
        Debug.Log("Earn  " + action.rewardType.ToString() + "   " + action.amount);
    }
}
