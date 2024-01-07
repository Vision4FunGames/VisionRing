using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableCrystal : MonoBehaviour
{
    public int level;

    public int GoldAmount => EconomyManager.instance.GetGemAmount(level);


}
