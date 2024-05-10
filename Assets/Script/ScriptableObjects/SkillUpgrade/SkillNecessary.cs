using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Skill", menuName = "Necessary", order = 3)]
public partial class SkillNecessary : ScriptableObject
{
    public List<UpgradeItem> ItemList;
    public List<int> itemCount;
    public int evolutionCost;
    public int upgradeCost;

}