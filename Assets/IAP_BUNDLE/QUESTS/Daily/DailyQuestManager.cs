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

    public DailyQuestType selectType;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        FirstControl();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FirstControl()
    {
        //newDay=...........
        //eðer yeni gün olmuþsa sýfýrlayacak.
        SetQuestList();
        if (newDay)
        {
            dailyStarCount = 0;
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

    [Button]
    public void AddStar()
    {
        AddStar(10);
    }

    public void AddStar(int amount)
    {
        dailyStarCount += amount;
        dailyStarSlider.value = dailyStarCount;
        dailyStarCountTxt.text = dailyStarCount.ToString();
        PlayerPrefs.SetInt("IapBundle_DailyStar", dailyStarCount);
        foreach (var item in chestList)
        {
            item.Control();
        }
    }


    [Button]
    public void SetQuestList()
    {
        for (int i = 0; i < dailyQuestUiList.Count; i++)
        {
            dailyQuestUiList[i].SetQuest(dailyQuestList.questList[i]);
        }
    }

    [Button]
    public void AddQuestEvent()
    {
        dailyQuestCount[(int)selectType]++;
        PlayerPrefs.SetInt("IapBundle_DailyQuestAmount" + (int)selectType, dailyQuestCount[(int)selectType]);
        dailyQuestUiList[(int)selectType].Control();
    }
}
