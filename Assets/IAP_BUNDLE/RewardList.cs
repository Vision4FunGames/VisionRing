using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RewardItemType { Gold, Diamond, GemBlue, GemPurple, GemGreen }
public enum RewardPackType { Forest, Dungeon, Chest, Skull }
[CreateAssetMenu(fileName = "RewardList", menuName = "ScriptableObjects/RewardList", order = 3)]
public class RewardList : ScriptableObject
{
    public AudioClip openClip, idleClip, firstClip;

    public AudioClip doubleSound, claimSound;
    public List<RewardDetail> rewards;
    public List<RewardPack> spinRewardPacks;

    private void OnValidate()
    {
        int c = 0;
        foreach (var reward in rewards)
        {
            reward.rewardType = (RewardItemType)c;
            reward.rewardName = reward.rewardType.ToString();
            c++;
        }
        foreach (var item in spinRewardPacks)
        {
            item.packName = item.packType.ToString();
        }

    }

    public List<Reward> GetRewards(RewardPackType packType)
    {
        foreach (var item in spinRewardPacks)
        {
            if (item.packType == packType) return item.rewards;
        }
        return null;
    }
}
[Serializable]
public class RewardDetail
{
    [ReadOnly] public string rewardName;
    public RewardItemType rewardType;
    [ShowAssetPreview(50, 50)]
    public GameObject prefab;
    [ShowAssetPreview(50, 50)]
    public Sprite sprite;
}

[Serializable]
public class RewardPack
{
    [ReadOnly] public string packName;
    public RewardPackType packType;

    public List<Reward> rewards;
}

[Serializable]
public class Reward
{
    public RewardItemType rewardType;
    public int minAmount, maxAmount;
    [Range(0f, 100f)]
    public float Chance = 100f;
    [HideInInspector] public int Index;
    [HideInInspector] public double _weight = 0f;
}