using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "Skill/SkillUpgrade", order = 1)]
public class SkillEvolution:ScriptableObject
{
    public int skillDamage;
    public int skillUpgradeDamage;
    public float skillUpgradeCooldown;
    public int upgradeCost;
    public int evolutionCost;
}
