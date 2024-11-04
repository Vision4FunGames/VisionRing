using DG.Tweening;
using JetBrains.Annotations;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyQuestItemUi : MonoBehaviour
{
    public Image bg;
    public Sprite greenSprite, graySprite;
    public TextMeshProUGUI title, content, requirement, star;
    [ReadOnly] public DailyQuestItem quest;
    public Slider slider;
    public Button button;
    public GameObject tick,starImage;

    public void Clear()
    {
        slider.maxValue = quest.requirementAmount;
        slider.value = 0;
        title.text = quest.title;
        content.text = quest.content;
        star.text = quest.star.ToString();
        requirement.text = "0/" + quest.requirementAmount;
        button.interactable = false;
        tick.SetActive(false);
        PlayerPrefs.SetInt("DailyQuestClaim" + quest.questType, 0);
    }


    public void Control()
    {
        slider.DOValue(DailyQuestManager.Instance.dailyQuestCount[(int)quest.questType], 0.5f);
        requirement.text = DailyQuestManager.Instance.dailyQuestCount[(int)quest.questType] + "/" + quest.requirementAmount;
        if (PlayerPrefs.GetInt("DailyQuestClaim" + quest.questType, 0) == 1)//ödül alýndý
        {
            bg.sprite = greenSprite;
            button.gameObject.SetActive(false);
            tick.SetActive(true);
        }
        else
        {
            if (DailyQuestManager.Instance.dailyQuestCount[(int)quest.questType] >= quest.requirementAmount)//ödül kazanýldý alýnmadý henüz
            {
                button.interactable = true;
                bg.sprite = greenSprite;
                transform.SetSiblingIndex(0);

            }
            else//ödül kazanýlmadý
            {
                button.interactable = false;
            }
        }
    }



    public void SetQuest(DailyQuestItem questItem)
    {
        quest = questItem;
        slider.maxValue = quest.requirementAmount;
        slider.value = 0;
        title.text = quest.title;
        content.text = quest.content;
        star.text = quest.star.ToString();
        requirement.text = "0/" + quest.requirementAmount;

    }
    public void Claim()
    {
        tick.SetActive(true);
        button.gameObject.SetActive(false);
        DailyQuestManager.Instance.AddStar(quest.star, starImage.transform.position);
        PlayerPrefs.SetInt("DailyQuestClaim" + quest.questType, 1);
    }

}
