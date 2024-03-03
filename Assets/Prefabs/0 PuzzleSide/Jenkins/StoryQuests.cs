using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "QuestLine", menuName = "Quests/QuestLine", order = 1)]
public class StoryQuests : ScriptableObject
{
    public List<StoryInfoLine> questLine = new List<StoryInfoLine>();
}
[System.Serializable]
public class StoryInfoLine
{
    public string header;
    [Multiline(8)] public string info;
    public bool hasReward;
    public RewardType rewardType;
    public Sprite rewardIcon;
    public int rewardAmount;
}

public enum RewardType
{
    None,
    Gold,
    Gem,
    Item
}
