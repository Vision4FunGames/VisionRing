using DG.Tweening;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class DailyCheckinRewardItem : MonoBehaviour
{
    [ReadOnly] public Reward reward;
    [ReadOnly] public RewardDetail rewardDetail;

    public TextMeshProUGUI rewardAmountTxt, rewardNameTxt, dayTxt;
    public Image rewardImage, focusImage, bg;
    public GameObject claimedObject;
    int multiplier;
    public void SetDay(int day, Reward rewad, bool claimed, int rewardMultiplier)
    {
        multiplier = rewardMultiplier;
        this.reward = reward;
        this.rewardDetail = DailyCheckinManager.Instance.rewardList.GetRewardDetail(rewad.rewardType);
        claimedObject.SetActive(claimed);
        rewardImage.sprite = rewardDetail.sprite;
        rewardAmountTxt.text = (rewardDetail.amount * rewardMultiplier).ToString();
        rewardNameTxt.text = rewardDetail.rewardName;
        dayTxt.text = "Day " + (day + 1);
        bg.color = PlaytimeRewardsManager.instance.rewardList.GetTierColor(reward.rewardType);

        if (day == DailyCheckinManager.Instance.currentDay)
        {
            focusImage.color = PlaytimeRewardsManager.instance.rewardList.GetTierColor(reward.rewardType);
            focusImage.gameObject.SetActive(true);
            focusImage.DOFade(0, 1f).SetLoops(-1, LoopType.Yoyo);
        }
        else
        {
            focusImage.DOKill();
            focusImage.gameObject.SetActive(false);
        }
    }
    public void Claimed()
    {
        claimedObject.SetActive(true);
        RewardDisplay.Instance.EarnReward(reward.rewardType, rewardDetail.amount * multiplier);
    }

}
