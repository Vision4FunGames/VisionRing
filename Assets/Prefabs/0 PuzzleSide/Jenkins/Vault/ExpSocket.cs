using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Exp Socket", menuName = "Experience Economy/New Socket", order = 1)]
public class ExpSocket : ScriptableObject
{
    public int[] requiredExp;
    public float expMultipler;
    public float level;
    public float GetExp(int level) => requiredExp[level] * expMultipler * this.level;
}
