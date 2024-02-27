using System;
using System.Threading.Tasks;
using NaughtyAttributes;
using TMPro;
using UnityEngine;

public class RewardManager : WorldTimeAPIController
{
    private TaskCompletionSource<bool> _completion = new TaskCompletionSource<bool>();
    private WorldTimeAPIController _worldTimeAPIController;
    public DateTime globalTimeLast;
    
    
    
    [Header("Daily")] 
    public TextMeshProUGUI dailyDrawTxtLeft;
    public TextMeshProUGUI dailyTxtLeft;
    public int _drawCount;

    private void Awake()
    {
        _worldTimeAPIController = FindObjectOfType<WorldTimeAPIController>();
    }
    [Button("CollectDaily")]
    public async Task CollectDaily()
    {
        if (_drawCount > 0)
        {
            _drawCount--;
            await _worldTimeAPIController.GetGlobalTime();
            globalTimeLast = _worldTimeAPIController.globalTimeLast;
            Debug.Log(globalTimeLast);
        }
    }
}