using DG.Tweening;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{
    public AchievementList achievementList;
    public List<AchievementUiItem> achievementUiList;
    public int[] achievementCount, achievementLevels;


    public static AchievementManager Instance;
    private void Awake()
    {
        if (Instance == null) Instance = this;
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
        SetQuestList();
        for (int i = 0; i < achievementUiList.Count; i++)
        {
            achievementCount[i] = PlayerPrefs.GetInt("Iap_Bundle_AchievementAmount" + i, 0);
            achievementUiList[i].Control();
        }


    }
    [Button]
    public void SetQuestList()
    {
        for (int i = 0; i < achievementUiList.Count; i++)
        {
            achievementUiList[i].SetQuest(achievementList.achievementList[i]);
        }

       // AchievementManager.Instance.AddAchievementEvent(AchievementType.LevelUp,1);
    }
    [Button]
    public void AddQuestEvent()
    {
        AddAchievementEvent((AchievementType)Random.Range(0, achievementUiList.Count), 1);
    }



    public void AddAchievementEvent(AchievementType selectType, int amount)
    {
        achievementCount[(int)selectType] += amount;
        PlayerPrefs.SetInt("Iap_Bundle_AchievementAmount" + (int)selectType, achievementCount[(int)selectType]);
        achievementUiList[(int)selectType].Control();
    }

}
