using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TalkFoxCollectReward : MonoBehaviour
{
    private int clickCount;
    private bool speechDone;
    public TextMeshProUGUI foxTxt;
    public string foxSpeechOne = "You are great! You prove yourself.";
    public string foxSpeechTwo = "I found a key in the dungeon. You deserve it.";
    public GameObject _canvas;

  
    void Start()
    {
      //  if (FindObjectOfType<FoxManager>().GetComponent<Waypoint_Indicator>())
      //      FindObjectOfType<FoxManager>().GetComponent<Waypoint_Indicator>().enabled = true;
        GetComponentInChildren<IapBundleManager>().ShowLuckySpin(RewardPackType.Map1, 5, Result);
    }

    public void Result(Reward action)
    {
        Debug.Log("Earn  " + action.rewardType.ToString() + "   " + action.amount);
    }
    public void SpeechFox()
    {
        _canvas.SetActive(true);
        if (clickCount == 0)
        {
            speechDone = false;
            foxTxt.DOText(foxSpeechOne, 2).OnComplete(() => speechDone = true);
            clickCount++;
        }
        else if (clickCount == 1)
        {
            foxTxt.text = "";
            speechDone = false;
            foxTxt.DOText(foxSpeechTwo, 2).OnComplete(() => speechDone = true);
        }
    }

    private void Update()
    {
        if (speechDone)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SpeechFox();
            }
        }
    }
}