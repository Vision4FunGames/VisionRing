using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  static class StaticFuncs
{
    public static string FormatNumber(int num)
    {
        if (num >= 100000000)
        {
            return (num / 1000000D).ToString("0.#M");
        }
        if (num >= 1000000)
        {
            return (num / 1000000D).ToString("0.##M");
        }
        if (num >= 100000)
        {
            return (num / 1000D).ToString("0.#K");
        }
        if (num >= 10000)
        {
            return (num / 1000D).ToString("0.##K");
        }

        return num.ToString("#,0");
    }

    public static float Map(float x, float in_min, float in_max, float out_min, float out_max)
    {
        return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
    }

}
