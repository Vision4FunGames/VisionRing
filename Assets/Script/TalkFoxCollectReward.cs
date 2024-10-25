using System;
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
                speechDone = true;
                spinReward.SetActive(true);
                _canvas.SetActive(false);
                GetComponentInChildren<IapBundleManager>().ShowLuckySpin(RewardPackType.Map1, 5, Result);
            }));
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