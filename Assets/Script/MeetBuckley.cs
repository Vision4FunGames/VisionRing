using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class MeetBuckley : MonoBehaviour
{
    public GameObject blcPanel;
    private int clickCount;

    private string blc =
        "Hello, adventurer, welcome to my place. I'm Blacksmith Buckley, bring me your items that need polish.";
        
    private string blc1 =
        "It is not enough to have strong armour to fight. Powerful spells are also very important for your survival. Go to Marley the Wizard and get a spell.";

    private bool _speechDone;

    public TextMeshProUGUI mrcText;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.blacksmith.transform.DOScale(Vector3.one, 1);
        PlayerPrefs.SetInt("Blacksmith", 1);
        GameManager.instance.blacksmith.GetComponent<Waypoint_Indicator>().enabled = true;
        FindObjectOfType<CameraController>().blackSmithTurial = true;
    }

    public void SpeechStart()
    {
        _speechDone = false;
        if (clickCount == 0)
        {
            blcPanel.SetActive(true);
            mrcText.DOText(blc, 1).OnComplete((() =>
            {
                _speechDone = true;
                UiManager.instance.armorSlot.UseItem();
            }));
        }
        else if (clickCount == 1)
        {
            blcPanel.SetActive(false);
            UiManager.instance.BlackSmithUI();
        }
        else if (clickCount == 2)
        {
            blcPanel.SetActive(true);
            mrcText.DOText(blc1, 1).OnComplete((() =>
            {
                _speechDone = true;
                UiManager.instance.armorSlot.UseItem();
            }));
        }else if (clickCount == 3)
        {
            GetComponent<TaskPrefab>().isCompleted = true;
            GameManager.instance.merchant.GetComponent<Waypoint_Indicator>().enabled = false;
            Destroy(gameObject, .1f);
        }

        clickCount++;
    }

    // Update is called once per frame
    void Update()
    {
        if (_speechDone && Input.GetMouseButtonDown(0))
        {
            SpeechStart();
        }
    }
}