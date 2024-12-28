using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyCheckinManager : MonoBehaviour
{
    public RewardList rewardList;
    public List<DailyCheckinRewardItem> rewardItems;
    public List<Reward> rewards;
    public int rewardMultiplier = 1;
    [ReadOnly] public int currentDay, rewardIsReady;
    public static DailyCheckinManager Instance;
    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentDay = PlayerPrefs.GetInt("DailyCheckinDay", 0);
        rewardMultiplier = 1 + (currentDay / 10);
        SetRewards();
    }

    public void RewardControl()
    {
        rewardIsReady = PlayerPrefs.GetInt("DailyCheckinReady", 1);
    }

    public void NextDay()
    {
        rewardIsReady = 1;
        PlayerPrefs.SetInt("DailyCheckinReady", rewardIsReady);
        currentDay = PlayerPrefs.GetInt("DailyCheckinDay", 0);
        rewardMultiplier = 1 + (currentDay / 10);
        SetRewards();
    }


    public void SetRewards()
    {
        for (int i = 0; i < rewardItems.Count; i++)
        {
            rewardItems[i].SetDay(i + ((rewardMultiplier - 1) * 10), rewards[i], i + ((rewardMultiplier - 1) * 10) < currentDay ? true : false, rewardMultiplier);
        }
    }


    public void Checkin()
    {
        if (rewardItems[currentDay % 10].claimedObject.activeSelf) return;
        RewardControl();
        if (rewardIsReady > 0)
        {
            rewardIsReady = 0;
            PlayerPrefs.SetInt("DailyCheckinReady", rewardIsReady);
            rewardItems[currentDay % 10].Claimed();
            currentDay++;
            PlayerPrefs.SetInt("DailyCheckinDay", currentDay);
        }
    }


}
