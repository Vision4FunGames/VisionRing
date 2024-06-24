using System;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

public class MapMaskManager : MonoBehaviour
{
    public int dungeonLevel;
    public MapLevelSetting[] mapLevelSettings;


    private void Start()
    {
        dungeonLevel = 0;
        MapMaskUpdate();
    }

    [Button("LevelMapTest")]
    public void MapMaskUpdate()
    {
        for (int i = 0; i < mapLevelSettings.Length; i++)
        {
            if (dungeonLevel == i)
            {
                mapLevelSettings[i]._maskImage.SetActive(true);
                mapLevelSettings[i].levelButton.gameObject.SetActive(true);
            }
            else
            {
                mapLevelSettings[i]._maskImage.SetActive(false);
                mapLevelSettings[i].levelButton.gameObject.SetActive(false);
            }
        }
    }
}

[Serializable]
public class MapLevelSetting
{
    public GameObject _maskImage;
    public Button levelButton;
}