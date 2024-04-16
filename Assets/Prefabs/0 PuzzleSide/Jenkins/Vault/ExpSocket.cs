using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Exp Socket", menuName = "Experience Economy/New Socket", order = 1)]
public class ExpSocket : ScriptableObject
{
    public int[] experience;
    public float expMultipler;
    public float level;
    public float GetExp(int level) => experience[level] * expMultipler * this.level;
}
