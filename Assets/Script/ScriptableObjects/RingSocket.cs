using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RingSocket", menuName = "Ring/New Ring", order = 1)]
public class RingSocket : ScriptableObject
{
    public int maxLevel;
    public int[] stoneCost;
    public float HPMultiplier,ATKMultiplier,DEFMultiplier;
}
