using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using NaughtyAttributes;
public class AchievementUiItem : MonoBehaviour
{
    public Image bg;
    public Sprite greenSprite, graySprite;
    public TextMeshProUGUI content, requirement, reward;
    [ReadOnly] public AchievementItem achievement;
    public Slider slider;
    public Button claimButton, goButton;
    public GameObject tick;

    public void Clear()
    {
        slider.maxValue = achievement.GetRequirementAmount();
        slider.value = 0;
        content.text = achievement.content;
        reward.text = achievement.rewardAmount.ToString();
        requirement.text = "0/" + achievement.GetRequirementAmount();
        claimButton.interactable = false;
        tick.SetActive(false);
        goButton.interactable = false;
    }


    public void Control()
    {
        slider.maxValue = achievement.GetRequirementAmount();
        slider.DOValue(AchievementManager.Instance.achievementCount[(int)achievement.achievementType], 0.5f);
        requirement.text = AchievementManager.Instance.achievementCount[(int)achievement.achievementType] + "/" + achievement.GetRequirementAmount();

        if (AchievementManager.Instance.achievementCount[(int)achievement.achievementType] >= achievement.GetRequirementAmount())//ödül kazanýldý alýnmadý henüz
        {
            claimButton.gameObject.SetActive(true);
            claimButton.interactable = true;
            goButton.gameObject.SetActive(false);
            bg.sprite = greenSprite;
            transform.SetSiblingIndex(0);

        }
        else//ödül kazanýlmadý
        {

            bg.sprite = graySprite;
            if (achievement.availableGoEvent)
            {
                claimButton.gameObject.SetActive(false);
                goButton.gameObject.SetActive(true);
            }
            else
            {
                claimButton.interactable = false;
                claimButton.gameObject.SetActive(true);
                goButton.gameObject.SetActive(false);
            }
            transform.SetSiblingIndex(transform.parent.childCount - 1);
        }

    }



    public void SetQuest(AchievementItem achievementItem)
    {
        achievement = achievementItem;
        slider.maxValue = achievement.GetRequirementAmount();
        slider.value = 0;
        content.text = achievement.content;
        reward.text = achievement.rewardAmount.ToString();
        requirement.text = "0/" + achievement.GetRequirementAmount();

    }
    public void Claim()
    {
        claimButton.gameObject.SetActive(false);
        Debug.Log("Earn " + achievement.rewardAmount + "  Gem");
        RewardDetail newReward = new RewardDetail();
        RewardDisplay.Instance.EarnReward(RewardItemType.GemBlue, achievement.rewardAmount);
        AchievementManager.Instance.achievementCount[(int)achievement.achievementType] -= achievement.GetRequirementAmount();
        PlayerPrefs.SetInt("Iap_Bundle_AchievementAmount" + (int)achievement.achievementType, AchievementManager.Instance.achievementCount[(int)achievement.achievementType]);
        achievement.LevelUp();
        Control();
    }
    public void Go()
    {
        if (achievement.availableGoEvent) AchievementRouting.instance.SendMessage(achievement.goEvent);
    }
}
