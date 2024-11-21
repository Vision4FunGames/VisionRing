using MoreMountains.Tools;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AchievementType { DefeatMonsters, Login, WatchAd, UpgradeEquipments, UseSkill, UseRing, CompleteDungeon, OpenChests, UpgradeArtifacts, DailyWheelSpin, LevelUp, PlayTime, MakeIap, IncreaseAttackWithBeans, IncreaseDefenceWithBeans, IncreaseHealthWithBeans }
[CreateAssetMenu(fileName = "AchievementList", menuName = "ScriptableObjects/AchievementList", order = 4)]

public class AchievementList : ScriptableObject
{
    public List<AchievementItem> achievementList;
    private void OnValidate()
    {
        int c = 0;
        foreach (var item in achievementList)
        {
            item.achievementType = (AchievementType)c;
            c++;
        }
    }

}
[Serializable]
public class AchievementItem
{
    public string content;
    public AchievementType achievementType;
    public int baseAmount, offset, limit, rewardAmount;
    public bool availableGoEvent;
    [ShowIf(EConditionOperator.And, "availableGoEvent", "availableGoEvent")]
    [AllowNesting]
    public string goEvent;
    public int GetRequirementAmount()
    {
        int level = PlayerPrefs.GetInt("Iap_BundleAchievemet" + achievementType.ToString() + "Level", 0);
        if (baseAmount == 1)
        {
            if (level == 0 && offset > 0) return baseAmount + (level * offset);
            else if (offset == 0) return baseAmount;
            else return level * offset;
        }
        else return baseAmount + (level * offset);
    }
    public void LevelUp()
    {
        PlayerPrefs.SetInt("Iap_BundleAchievemet" + achievementType.ToString() + "Level", PlayerPrefs.GetInt("Iap_BundleAchievemet" + achievementType.ToString() + "Level", 0) + 1);
    }
}