using DG.Tweening;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyQuestManager : MonoBehaviour
{
    public DailyQuestList dailyQuestList;
    public bool newDay;
    public int dailyStarCount;
    public static DailyQuestManager Instance;
    public Slider dailyStarSlider;
    public List<DailyQuestChest> chestList;
    public TextMeshProUGUI dailyStarCountTxt;

    public List<DailyQuestItemUi> dailyQuestUiList;
    public int[] dailyQuestCount;

    public Transform targetStarImg;
    public Transform starParent;
    public GameObject starPrefab;

    //public DailyQuestType selectType;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        FirstControl();

    }

    public void FirstControl()
    {

        SetQuestList();
        if (newDay)
        {
            dailyStarCount = 0;
            dailyStarSlider.value = 0;
            PlayerPrefs.SetInt("IapBundle_DailyStar", 0);
            foreach (var item in chestList)
            {
                item.Clear();
            }
            foreach (var item in dailyQuestUiList)
            {
                item.Clear();
            }

        }
        else
        {
            dailyStarCount = PlayerPrefs.GetInt("IapBundle_DailyStar", 0);
            foreach (var item in chestList)
            {
                item.Control();
            }
            for (int i = 0; i < dailyQuestUiList.Count; i++)
            {
                dailyQuestCount[i] = PlayerPrefs.GetInt("IapBundle_DailyQuestAmount" + i, 0);
                dailyQuestUiList[i].Control();
            }

        }
        dailyStarSlider.value = dailyStarCount;
        dailyStarCountTxt.text = dailyStarCount.ToString();
    }
    public void AddStar(int amount, Vector3 pos)
    {
        dailyStarCount += amount;
        dailyStarSlider.value = dailyStarCount;
        dailyStarCountTxt.text = dailyStarCount.ToString();
        PlayerPrefs.SetInt("IapBundle_DailyStar", dailyStarCount);
        foreach (var item in chestList)
        {
            item.Control();
        }
        if (amount >= 10) amount = 10;
        for (int i = 0; i < amount; i++)
        {
            GameObject newImage = Instantiate(starPrefab, pos, Quaternion.identity, starParent);
            float r = Random.Range(0.2f, 0.5f);
            newImage.transform.DOMove(new Vector2(pos.x + Random.Range(-100, 100), pos.y + Random.Range(-100, 100)), r).SetUpdate(true).OnComplete(() => newImage.transform.DOMove(targetStarImg.position, 0.9f).SetUpdate(true).OnComplete(() =>
            {
                Destroy(newImage);
            }));
        }
    }


    [Button]
    public void SetQuestList()
    {
        for (int i = 0; i < dailyQuestUiList.Count; i++)
        {
            dailyQuestUiList[i].SetQuest(dailyQuestList.questList[i]);
        }

        // DailyQuestManager.Instance.AddQuestEvent(DailyQuestType.ClearDungeon,1);
    }
    [Button]
    public void AddQuestEvent()
    {
        AddQuestEvent((DailyQuestType)Random.Range(0, dailyQuestUiList.Count), 1);
    }



    public void AddQuestEvent(DailyQuestType selectType, int amount)
    {
        dailyQuestCount[(int)selectType] += amount;
        PlayerPrefs.SetInt("IapBundle_DailyQuestAmount" + (int)selectType, dailyQuestCount[(int)selectType]);
        dailyQuestUiList[(int)selectType].Control();
    }

    public void DayReset()
    {
        newDay = true;
        FirstControl();
        newDay = false;
    }


}
