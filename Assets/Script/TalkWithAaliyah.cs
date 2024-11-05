using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using GameAnalyticsSDK.Setup;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TalkWithAaliyah : MonoBehaviour
{
    private CameraController cameraController;
    public GameObject mrcPanel;
    private int clickCount;
    private string mrc1 = "Thank you for saving me. I am a merchant who sells weapons and armour left to me by some adventurers.";
    private string mrc2 = "Don't forget to visit by my shop whenever you want to equip new weapons and armour.";
    private bool _speechDone;
    public TextMeshProUGUI mrcText;
    public GameObject rewardPanel;
    public Button rewardCollectBtn;
    private void Start()
    {
        GameManager.instance.merchant.GetComponent<Waypoint_Indicator>().enabled = true;
        cameraController = FindObjectOfType<CameraController>();
        cameraController.merchantTutorial = true;
        rewardCollectBtn.onClick.AddListener(RewardCoin);
    }

    public void RewardCoin()
    {
        rewardPanel.SetActive(false);
        EconomyManager.instance.SetGold(1000);
        GetComponent<TaskPrefab>().isCompleted = true;
        Destroy(gameObject,.4f);
    }
    public void SpeechStart()
    {
        _speechDone = false;
        if (clickCount == 0)
        {
            mrcPanel.SetActive(true);
            mrcText.DOText(mrc1, 1).OnComplete((() =>
            {
                _speechDone = true;
            }));
        }else if (clickCount == 1)
        {
            mrcText.text = "";
            mrcText.DOText(mrc2, 1).OnComplete((() =>
            {
                _speechDone = true;
            }));
        }else if (clickCount == 2)
        {
           mrcPanel.SetActive(false);
           rewardPanel.transform.DOScale(Vector3.one, 1);
        }
        clickCount++;
    }
    private void Update()
    {
        if (_speechDone && Input.GetMouseButtonDown(0))
        {
            SpeechStart();
        }
    }
}
