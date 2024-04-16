using System;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public int currentLevel;
    public float currentExp;
    public float[] levelsExpPool;
    public float expBoost;
    public float expBaseBoost;
    private void Start()
    {
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

        UiManager.instance.playerLevel.text = "Level: " + currentLevel.ToString();
    }

    public void ExpCalculate(int expValue)
    {
        currentExp += (expBoost * expValue);
        CheckLevel();
    }

    public void CheckLevel()
    {
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
        UiManager.instance.playerLevel.text = "Level: " + currentLevel.ToString();
        if (currentExp > levelsExpPool[currentLevel - 1])
            LevelUp();
        var unlockObjects = FindObjectsOfType<UnlockButton>();
        for (int i = 0; i < unlockObjects.Length; i++)
        {
            unlockObjects[i].CheckPlayerLevelForUnlock();
        }
    }
}