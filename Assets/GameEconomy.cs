using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEconomy : MonoBehaviour
{
    public EconomyCurves[] EconomyCurves;
}
[System.Serializable]
public class EconomyCurves
{
    public string relatedName;
    public AnimationCurve curve;
}