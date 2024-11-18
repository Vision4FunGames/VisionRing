using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridItem : MonoBehaviour
{
    public GameObject selectGlow;
    public Image bg, icon;
    public Text amount;
    public Reward reward;

    public void SetReward(Reward reward)
    {
        this.reward = reward;
        bg.color = IapBundleManager.instance.rewardList.GetTierColor(reward.rewardType);
        icon.sprite = IapBundleManager.instance.rewardList.rewards[(int)reward.rewardType].sprite;
        amount.text = PlaytimeRewardsManager.instance.rewardList.GetAmount(reward.rewardType).ToString();
        if (!gameObject.activeSelf) gameObject.SetActive(true);
        if (selectGlow.activeSelf) selectGlow.SetActive(false);
    }

    public void Selected()
    {
        selectGlow.SetActive(true);
    }
    public void Deselect()
    {
        selectGlow.SetActive(false);
    }
    public void Deactive()
    {
        gameObject.SetActive(false);
    }
}
