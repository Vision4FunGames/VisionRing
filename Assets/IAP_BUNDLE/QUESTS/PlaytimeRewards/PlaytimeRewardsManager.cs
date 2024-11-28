using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
public class PlaytimeRewardsManager : MonoBehaviour
{

    public RewardList rewardList;
    public List<PlaytimeReward> playtimeRewards;
    public List<Reward> rewards;
    public List<int> rewardsRequirementMinutes;
    public static PlaytimeRewardsManager instance;
    /*[ReadOnly]*/ public float dailyPlaytime;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        dailyPlaytime = PlayerPrefs.GetFloat("DailyPlaytime", 0);
        for (int i = 0; i < playtimeRewards.Count; i++)
        {
            playtimeRewards[i].SetReward(rewards[i], rewardsRequirementMinutes[i], i);
        }
        StartCoroutine(SavePlaytime());
    }
    void Update()
    {
        dailyPlaytime += Time.deltaTime;
    }

    public void DayReset()
    {
        dailyPlaytime = 0;
        PlayerPrefs.SetFloat("DailyPlaytime", dailyPlaytime);
        for (int i = 0; i < playtimeRewards.Count; i++)
        {
            playtimeRewards[i].SetReward(rewards[i], rewardsRequirementMinutes[i], i);
        }
    }



    IEnumerator SavePlaytime()
    {
        while (true)
        {
            PlayerPrefs.SetFloat("DailyPlaytime", dailyPlaytime);
            yield return new WaitForSeconds(10);
        }
    }
    public void RewardControl()
    {
        foreach (var item in playtimeRewards)
        {
            item.Control();
        }
    }

    public void ClaimAllBUtton()
    {
        foreach (var item in playtimeRewards)
        {
            item.SelectReward();
        }
    }


}
