using DG.Tweening;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlaytimeReward : MonoBehaviour
{
    public Button button;
    public Image rewardImage, focusImage, bg;
    [ReadOnly] public Reward reward;
    [ReadOnly] public RewardDetail rewardDetail;
    public float requirementTime;
    public TextMeshProUGUI requirementTimeTxt, rewardNameTxt, rewardAmountTxt;
    public int rewardIndex;
    public bool isReady, rewardIsEmpty;
    public GameObject claimedObj;
    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        if (focusImage.gameObject.activeSelf)
        {
            focusImage.DOKill();
            focusImage.DOFade(1, 0.1f);
        }
    }


    public void SetReward(Reward reward, float requirementTime, int indx)
    {
        requirementTimeTxt.text = requirementTime.ToString() + " M";
        rewardDetail = PlaytimeRewardsManager.instance.rewardList.GetRewardDetail(reward.rewardType);
        this.reward = reward;
        this.requirementTime = requirementTime * 60;
        this.rewardIndex = indx;
        rewardAmountTxt.text = "X " + PlaytimeRewardsManager.instance.rewardList.GetAmount(reward.rewardType);
        rewardNameTxt.text = rewardDetail.rewardName;
        rewardImage.sprite = rewardDetail.sprite;
        rewardIsEmpty = false;
        claimedObj.SetActive(false);
        bg.color = PlaytimeRewardsManager.instance.rewardList.GetTierColor(reward.rewardType);
        focusImage.DOKill();
        focusImage.DOFade(0, 0.1f);
    }

    public void Control()
    {
        if (PlayerPrefs.GetInt("PlaytimeRewarded" + rewardIndex) == 1) rewardIsEmpty = true;
        if (rewardIsEmpty)
        {
            claimedObj.SetActive(true);
            return;
        }
        if (isReady) return;
        if (requirementTime <= PlaytimeRewardsManager.instance.dailyPlaytime)
        {
            isReady = true;
            focusImage.color = PlaytimeRewardsManager.instance.rewardList.GetTierColor(reward.rewardType);
            focusImage.gameObject.SetActive(true);
            focusImage.DOFade(0, 1f).SetLoops(-1, LoopType.Yoyo);
        }
    }

    public void SelectReward(bool display)
    {
        if (isReady)
        {
            PlayerPrefs.SetInt("PlaytimeRewarded" + rewardIndex, 1);
            if (display) RewardDisplay.Instance.EarnReward(reward.rewardType);
            Debug.Log("Earn: " + reward.rewardType + "    " + PlaytimeRewardsManager.instance.rewardList.GetAmount(reward.rewardType));
            isReady = false;
            rewardIsEmpty = true;
            focusImage.gameObject.SetActive(false);
            claimedObj.SetActive(true);
        }
    }
    public void Clear()
    {
        PlayerPrefs.SetInt("PlaytimeRewarded" + rewardIndex, 0);
    }


}
