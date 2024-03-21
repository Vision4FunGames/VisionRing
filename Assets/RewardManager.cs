using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NaughtyAttributes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RewardManager : WorldTimeAPIController
{
    private TaskCompletionSource<bool> _completion = new TaskCompletionSource<bool>();
    private WorldTimeAPIController _worldTimeAPIController;
    public DateTime globalTimeLast;
    public DateTime dailyDrawTime;
    public List<UpgradeItem> upgradeItems;

    [Header("Daily")]
    private DailyRewardManager dailyRewardManager;
    public TextMeshProUGUI dailyDrawTxtLeft;
    public TextMeshProUGUI dailyTxtLeft;
    public double _drawCount;
    private double currentDraw; 
    private void Awake()
    {
        _worldTimeAPIController = FindObjectOfType<WorldTimeAPIController>();
        dailyRewardManager = FindObjectOfType<DailyRewardManager>();

       
        if (PlayerPrefs.HasKey("DailyDraw"))
        {
            dailyDrawTime = DateTime.Parse(PlayerPrefs.GetString("DailyDraw"));
            InvokeRepeating("CheckDailyDrawReward", 1f, 1f);
        }
            
    }
    [Button("CollectDaily")]
    public async Task CollectDaily()
    {
        if (_drawCount > 0)
        {
            _drawCount--;
            if (_drawCount < 0)
            {
                await _worldTimeAPIController.GetGlobalTime();
                globalTimeLast = _worldTimeAPIController.globalTimeLast;
                dailyDrawTime = globalTimeLast.AddHours(24);
                PlayerPrefs.SetString("DailyDraw",dailyDrawTime.ToString());
                InvokeRepeating("CheckDailyDrawReward", 1f, 1f);
                Debug.Log(globalTimeLast);
            }
        }
    }

    public void CollectDailyReward()
    {
        CollectDaily();
        dailyRewardManager.Collect(false);

    }

    public void CollectDailyDecimal()
    {
        for (int i = 0; i < 10; i++)
        {
            CollectDaily();
        }
        dailyRewardManager.Collect(true); 
    }
    public void CheckDailyDrawReward()
    {
        currentDraw = (dailyDrawTime-DateTime.Now).TotalSeconds;
        TimeSpan t = TimeSpan.FromSeconds(currentDraw);
        dailyDrawTxtLeft.text = string.Format("{0:D2}h:{1:D2}m:{2:D2}s", 
            t.Hours, 
            t.Minutes, 
            t.Seconds);
    }
}