using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class HideOutFox : MonoBehaviour
{
    public Canvas hideoutCanvas;
    public TextMeshProUGUI foxTxt;

    public TextMeshProUGUI playerTxt;

    public GameObject foxPanel;

    public GameObject playerPanel;

    private string foxTextOne =
        "We need stronger weapons and armor to survive. Why were you in these dangerous dungeons?";

    private string playerTextOne =
        "I need to solve a mystery my parents left me. You'll learn when we're best friends.";

    private string foxTextTwo = "Let's find my other captured friend. She'll help you get stronger.";


    private bool speechDone;
    private int speechCount;

    private void Awake()
    {
        SpeechStart();
    }

    public void SpeechStart()
    {
        speechDone = false;
        foxTxt.text = "";
        switch (speechCount)
        {
            case 0:
                foxPanel.SetActive(true);
                playerPanel.SetActive(false);
                foxTxt.DOText(foxTextOne, 2f).OnComplete((() => speechDone = true));
                break;
            case 1:
                foxPanel.SetActive(false);
                playerPanel.SetActive(true);
                playerTxt.DOText(playerTextOne, 2f).OnComplete((() => speechDone = true));
                break;
            case 2:
                foxPanel.SetActive(true);
                playerPanel.SetActive(false);
                foxTxt.DOText(foxTextTwo, 2f).OnComplete((() =>
                {
                    speechDone = true;
                }));
                break;
            case 3:
                hideoutCanvas.gameObject.SetActive(false);
                FindObjectOfType<TaskReward>().tutorialComplete = true;
                FindObjectOfType<TaskReward>().rewardPanel.transform.DOScale(new Vector3(1, 1, 1), .5f);
                break;
        }

        speechCount++;
    }

    private void Update()
    {
        if (speechDone)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SpeechStart();
            }
        }
    }
}