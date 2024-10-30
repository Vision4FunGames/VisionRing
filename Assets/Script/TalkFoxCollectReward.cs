using System;
using Cinemachine;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TalkFoxCollectReward : MonoBehaviour
{
    private int clickCount;
    private bool speechDone;
    public TextMeshProUGUI foxTxt;
    public string foxSpeechOne = "You are great! You prove yourself.";
    public string foxSpeechTwo = "I found a key in the dungeon. You deserve it.";
    public GameObject _canvas;
    public GameObject spinReward;
    public GameObject equipPanel;
    public Equipment swordMap1;
    public Button equipSword;
  
    
    void Start()
    {
        //  if (FindObjectOfType<FoxManager>().GetComponent<Waypoint_Indicator>())
     
        GameManager.instance.fox.GetComponent<Waypoint_Indicator>().enabled = true;
        equipSword.onClick.AddListener(EquipSwordMap);
    }

    public void EquipSwordMap()
    {
        EquipmentManager.instance.Equip(swordMap1);
        GetComponent<TaskPrefab>().isCompleted = true;
        Destroy(gameObject);
    }

    public void Result(Reward action)
    {
        equipPanel.transform.DOScale(Vector3.one, 1);
    }

    public void SpeechFox()
    {
        if (clickCount == 0)
        {
            foxTxt.text = "";
            GameManager.instance.fox.GetComponent<Waypoint_Indicator>().enabled = false;
            _canvas.SetActive(true);
            speechDone = false;
            foxTxt.DOText(foxSpeechOne, 2).OnComplete(() => speechDone = true);
            clickCount++;
        }
        else if (clickCount == 1)
        {
            foxTxt.text = "";
            speechDone = false;
            foxTxt.DOText(foxSpeechTwo, 2).OnComplete((() =>
            {
               
               GameManager.instance.playerVCam.gameObject.SetActive(false);
               GameManager.instance.coleziumCam.gameObject.SetActive(true);
               
                //spinReward.SetActive(true);
                _canvas.SetActive(false);
                Invoke("BackCameraPos",2f);
                //GetComponentInChildren<IapBundleManager>().ShowLuckySpin(RewardPackType.Map1, 5, Result);
            }));
        }
    }

    public void BackCameraPos()
    {
        FindObjectOfType<DailyWheelBase>().transform.DOScale(new Vector3(.5f, .5f, .5f), 1).SetEase(Ease.OutBack).OnComplete((() =>
        {
            Invoke("BackCameraPos2",1);
        }));
    }

    public void BackCameraPos2()
    {
        FindObjectOfType<DailyWheelBase>().GetComponent<Waypoint_Indicator>().enabled = true;
        GameManager.instance.playerVCam.gameObject.SetActive(true);
        GameManager.instance.coleziumCam.gameObject.SetActive(false);
    }
    public void Update()
    {
        if (speechDone && _canvas.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SpeechFox();
            }
        }

       
    }
}