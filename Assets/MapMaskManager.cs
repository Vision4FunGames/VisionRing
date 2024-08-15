using System;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapMaskManager : MonoBehaviour
{
    public int currentMapLevel;
    public MapLevelSetting[] mapLevelSettings;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("MapLevel"))
        {
            PlayerPrefs.SetInt("MapLevel", 0);
            currentMapLevel = PlayerPrefs.GetInt("MapLevel");
        }
        else
        {
            currentMapLevel = PlayerPrefs.GetInt("MapLevel") - 1;
        }
    }

    private void Start()
    {
        MapMaskUpdate();
    }

    [Button("LevelMapTest")]
    public void MapMaskUpdate()
    {
        for (int i = 0; i < mapLevelSettings.Length; i++)
        {
            if (currentMapLevel == i)
            {
                mapLevelSettings[i]._maskImage.GetComponent<CanvasMaskFade>().ImageFadeOpen();
            }
            else
            {
                mapLevelSettings[i]._maskImage.GetComponent<CanvasMaskFade>().ImageFadeClose();
                mapLevelSettings[i].levelButton.gameObject.SetActive(false);
            }

            if (currentMapLevel >= i)
                mapLevelSettings[i].levelButton.gameObject.SetActive(true);
        }
    }

    public void MapMaskSet()
    {
        for (int i = 0; i < mapLevelSettings.Length; i++)
        {
            if (currentMapLevel == i)
            {
                mapLevelSettings[i]._maskImage.GetComponent<CanvasMaskFade>().ImageOpen();
            }
            else
            {
                mapLevelSettings[i]._maskImage.GetComponent<CanvasMaskFade>().ImageClose();
                mapLevelSettings[i].levelButton.gameObject.SetActive(false);
            }

            if (currentMapLevel >= i)
                mapLevelSettings[i].levelButton.gameObject.SetActive(true);

            if (SceneManager.GetActiveScene().buildIndex == i)
                mapLevelSettings[i - 1].levelButton.gameObject.SetActive(false);
        }
    }
}

[Serializable]
public class MapLevelSetting
{
    public GameObject _maskImage;
    public Button levelButton;
}