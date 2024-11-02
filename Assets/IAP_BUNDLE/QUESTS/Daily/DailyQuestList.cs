using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DailyQuestType { KillCreatures, ClearDungeon, UpgradeOneItem, OpenChest, WatchAd, UpgradeArtifacts, UpgradeRing, DailyLogin, SpinDailyWheel, UpgradeAbility, EatBeans, CompleteDailyTasks }
[CreateAssetMenu(fileName = "DailyQuestList", menuName = "ScriptableObjects/DailyQuestList", order = 4)]
public class DailyQuestList : ScriptableObject
{
    public List<DailyQuestItem> questList;
    private void OnValidate()
    {
        int c = 0;
        foreach (var item in questList)
        {
            item.questType = (DailyQuestType)c;
            c++;
        }
    }

}
[Serializable]
public class DailyQuestItem
{  public string title, content;
    public DailyQuestType questType;
    public int requirementAmount, star;
  
}
