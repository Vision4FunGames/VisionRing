using System;
using NaughtyAttributes;
using UnityEngine;

public class MapMaskManager : MonoBehaviour
{
    public int dungeonLevel;
    public RectTransform maskObj;
    public MapLevelSetting[] mapLevelSettings;

    [Button("LevelMapTest")]
    public void MapMaskUpdate()
    {
        maskObj.localPosition = mapLevelSettings[dungeonLevel].maskPos;
        maskObj.SetWidth(mapLevelSettings[dungeonLevel].maskScale.x);
        maskObj.SetHeight(mapLevelSettings[dungeonLevel].maskScale.y);
    }
}

 [Serializable]
public class MapLevelSetting
{
    public Vector3 maskPos;
    public Vector2 maskScale;
}
