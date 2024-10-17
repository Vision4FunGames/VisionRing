using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class TalkFoxCollectReward : MonoBehaviour
{
    private int clickCount;
    private bool speechDone;
    public TextMeshProUGUI foxTxt;
    public string foxSpeechOne = "You are great! You prove yourself.";
    public string foxSpeechTwo = "I found a key in the dungeon. You deserve it.";

    void Start()
    {
        FindObjectOfType<FoxManager>().GetComponent<Waypoint_Indicator>().enabled = true;
    }

    private void OnMouseDown()
    {
        SpeechFox();
    }

    public void SpeechFox()
    {
        if (clickCount == 0)
        {
            speechDone = false;
            foxTxt.DOText(foxSpeechOne, 2).OnComplete(() => speechDone = true);
            clickCount++;
        }
        else if (clickCount == 1)
        {
            speechDone = false;
            foxTxt.DOText(foxSpeechOne, 2).OnComplete(() => speechDone = true);
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