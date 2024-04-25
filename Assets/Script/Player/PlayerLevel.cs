using System;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public int currentLevel;
    public float currentExp;
    public int[] levelsExpPool;
    public float expBoost;
    public float expBaseBoost;
    public ExpSocket playerexp;
    private int _percent;
    private void Start()
    {
        levelsExpPool = playerexp.experience;
        if (!PlayerPrefs.HasKey("CurrentLevel"))
        {
            currentLevel = 1;
            currentExp = 0;
            PlayerPrefs.SetInt("CurrentLevel", 1);
            PlayerPrefs.SetFloat("CurrentExp", 0);
        }
        else
        {
            currentLevel = PlayerPrefs.GetInt("CurrentLevel");
            currentExp = PlayerPrefs.GetFloat("CurrentExp");
        }

        PercenCalculate();
        UiManager.instance.playerLevel.text = "Level: " + currentLevel.ToString() +"i%"+_percent;
    }

    public void ExpCalculate(float expValue)
    {
        currentExp += (expBoost * expValue);
        CheckLevel();
    }

    public void PercenCalculate()
    {
        Debug.Log("percenttt"+(int)((currentExp / levelsExpPool[currentLevel - 1]) * 100));
        _percent = (int)((currentExp / levelsExpPool[currentLevel - 1]) * 100); 
        UiManager.instance.playerLevel.text = "Level: " + currentLevel.ToString() +"i%"+_percent;
    }
    public void CheckLevel()
    {
        PercenCalculate();
        if (levelsExpPool[currentLevel] < currentExp && currentLevel < levelsExpPool.Length)
            LevelUp();
    }

    public void LevelUp()
    {
        float extraexp = currentExp - levelsExpPool[currentLevel - 1];
        currentLevel += 1;
        currentExp = extraexp;
        PlayerPrefs.SetFloat("CurrentExp", currentExp);
        PlayerPrefs.SetInt("CurrentLevel", currentLevel);
        PercenCalculate();
        UiManager.instance.playerLevel.text = "Level: " + currentLevel.ToString() +"i%"+_percent;
        if (currentExp > levelsExpPool[currentLevel - 1])
            LevelUp();
        var unlockObjects = FindObjectsOfType<UnlockButton>();
        for (int i = 0; i < unlockObjects.Length; i++)
        {
            unlockObjects[i].CheckPlayerLevelForUnlock();
        }
    }
}