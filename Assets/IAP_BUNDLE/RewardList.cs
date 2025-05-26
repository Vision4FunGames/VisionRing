using NaughtyAttributes;
using System;
using System.Collections.Generic;
using UnityEngine;

public enum RewardItemType { Gold, Diamond, GemBlue, GemPurple, GemGreen, Sword1Map1 }
public enum Tier { Tier1, Tier2, Tier3, Tier4, Tier5, Tier6, Tier7, Tier8, Tier9 }
public enum RewardPackType { Forest, Dungeon, Chest, Skull, Map1 }
public enum ChestRewardPackType { DefaultChest,DailyChest }
[CreateAssetMenu(fileName = "RewardList", menuName = "ScriptableObjects/RewardList", order = 3)]
public class RewardList : ScriptableObject
{
    public AudioClip openClip, idleClip, firstClip;

    public AudioClip doubleSound, claimSound;
    public List<TierColor> tierColors;
    public List<RewardDetail> rewards;
    public List<RewardPack> spinRewardPacks;
    public List<ChestRewardPack> chestRewardPacks;

    private void OnValidate()
    {
        int c = 0;
        foreach (var reward in rewards)
        {
            reward.rewardType = (RewardItemType)c;
            if (reward.rewardName == "") reward.rewardName = reward.rewardType.ToString();
            c++;
        }
        c = 0;
        foreach (var item in spinRewardPacks)
        {
            item.packType = (RewardPackType)c;
            if (item.packName == "") item.packName = item.packType.ToString();
            c++;
        }
        c = 0;

        foreach (var item in tierColors)
        {
            item.tier = (Tier)c;
            c++;
        }

    }
    public Color GetTierColor(RewardItemType rewardItemType)
    {
        return tierColors[(int)rewards[(int)rewardItemType].tier].color;
    }

    public List<Reward> GetRewards(RewardPackType packType)
    {
        foreach (var item in spinRewardPacks)
        {
            if (item.packType == packType) return item.rewards;
        }
        return null;
    }
    public RewardDetail GetRewardDetail(RewardItemType rewardType)
    {
        return rewards[(int)rewardType];
    }
    public ChestRewardPack GetRewardDetail(ChestRewardPackType chestType)
    {
        return chestRewardPacks[(int)chestType];
    }

    public int GetAmount(RewardItemType rewardType)
    {
        return rewards[(int)rewardType].amount;
    }

}
[Serializable]
public class RewardDetail
{
    public string rewardName;
    public RewardItemType rewardType;
    [ShowAssetPreview(50, 50)]
    public GameObject prefab;
    [ShowAssetPreview(50, 50)]
    public Sprite sprite;
    public Tier tier;
    public int amount;
}


[Serializable]
public class ChestRewardPack
{
    public string packName;
    public ChestRewardPackType packType;
    public List<RewardDetail> rewards;
}


[Serializable]
public class RewardPack
{
    public string packName;
    public RewardPackType packType;
    public List<Reward> rewards;
}

[Serializable]
public class Reward
{
    public RewardItemType rewardType;
    [Range(0f, 100f)]
    public float Chance = 100f;
    [HideInInspector] public int Index;
    [HideInInspector] public double _weight = 0f;
}
[Serializable]
public class TierColor
{
    public Tier tier;
    public Color color;
}
