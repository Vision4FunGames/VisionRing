using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RewardDisplayItem : MonoBehaviour
{

    public Image tierImage,rewardImage;
    public TextMeshProUGUI rewardAmount;
    public RewardDetail reward;

   public void SetReward(RewardDetail newReard)
    {
        reward = newReard;
        tierImage.color = PlaytimeRewardsManager.instance.rewardList.GetTierColor(reward.rewardType);
        rewardAmount.text =RewardDisplay.Instance.rewardList.GetAmount(reward.rewardType).ToString();
        rewardImage.sprite = newReard.sprite;
        tierImage.enabled = true;
        rewardAmount.enabled = true;
        rewardImage.enabled = true;
    }
}
