using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelItem : MonoBehaviour
{
    public Image bg, icon;
    public Text label, amount;

    public Reward reward;
    public void SetReward(Reward reward)
    {
        this.reward = reward;
        bg.color = IapBundleManager.instance.rewardList.GetTierColor(reward.rewardType);
        icon.sprite = IapBundleManager.instance.rewardList.rewards[(int)reward.rewardType].sprite;
        label.text = IapBundleManager.instance.rewardList.rewards[(int)reward.rewardType].rewardName;
        amount.text = reward.amount.ToString();
    }
}
