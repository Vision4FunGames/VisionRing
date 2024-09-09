using System;
using AmazingAssets.DynamicRadialMasks;
using DG.Tweening;
using GameAnalyticsSDK.Setup;
using TaskSystem;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MerchantTutorial : MonoBehaviour
{
    public GameObject enemyShield;
    public bool handBool;
    public GameObject hand;
    public Canvas canvas;
    public TextMeshProUGUI mrcTxt;
    public TextMeshProUGUI playerTxt;
    public TextMeshProUGUI foxTxt;
    public GameObject mrcPanel;
    public GameObject foxPanel;
    public GameObject playerPanel;
    private int _speechCount = 0;
    public bool _speechDone;
    private bool foxSpeech;

    private string mrcTextOne =
        "Thanks for the try saving me. They are created a barrier it is created with dark magic.";

    private string mrcTextTwo =
        "Only those who can see these mystical powers can break through the barrier. My situation is hopeless. Give up.";

    private string playerTextOne =
        "I need to solve a mystery my parents left me. You'll learn when we're best friends.";

    private string foxTextString =
        "Unbealiveable! You can feel the dark magic. How can you do this? Where did you get this powers?";

    public void DiesEnemies()
    {
        var box = TaskPanelController.instance.GetLastMainTask();
        box.infoText.text = "Talk with Aaliyah";
        canvas.gameObject.SetActive(true);
        HandScaleAnimation();
        handBool = true;
        hand.SetActive(true);
    }

    void OnMouseDown()
    {
        mrcPanel.SetActive(true);
        hand.gameObject.SetActive(false);
        handBool = false;
        SpeechStart();
    }

    public void SpeechStart()
    {
        _speechDone = false;
        mrcTxt.text = " ";
        if (_speechCount == 0)
        {
            mrcTxt.DOText(mrcTextOne, 2f).OnComplete((() => _speechDone = true));
        }

        else if (_speechCount == 1)
        {
            mrcTxt.DOText(mrcTextTwo, 2f).OnComplete((() => _speechDone = true));
        }
        else if (_speechCount == 2)
        {
            canvas.gameObject.SetActive(false);
            var box = TaskPanelController.instance.GetLastMainTask();
            box.infoText.text = "Use Ring";
            FindObjectOfType<Player>().playerDrm.task = true;
        }

        _speechCount++;
    }

    public void Update()
    {
        HandAnimation();
        if (_speechDone && !foxSpeech&&Input.GetMouseButtonDown(0))
        {
            SpeechStart();
        }

        if (_speechDone && foxSpeech && Input.GetMouseButtonDown(0))
        {
            FoxSpeech();
        }
    }

    public void HandScaleAnimation()
    {
        hand.transform.DOScale(new Vector3(1.5f, 1.5f, 1.5f), 1f).OnComplete((() =>
        {
            hand.transform.DOScale(new Vector3(1f, 1f, 1f), 1f).OnComplete((() => HandScaleAnimation()));
        }));
    }

    public void HandAnimation()
    {
        if (Camera.main != null && handBool)
        {
            Vector3 goldpos = Camera.main.WorldToScreenPoint(this.transform.position);
            hand.transform.position = goldpos + new Vector3(50, -50, 0);
        }
    }

    public void BarrierOpen()
    {
        enemyShield.GetComponent<ParticleSystem>().Play();
        if (!foxSpeech)
        {
            foxSpeech = true;
            _speechCount = 0;
            foxPanel.SetActive(true);
            FoxSpeech();
        }
    }

    public void FoxSpeech()
    {
        canvas.gameObject.SetActive(true);
        mrcPanel.gameObject.SetActive(false);
        _speechDone = false;
        foxTxt.text = " ";
        foxPanel.SetActive(true);
        if (_speechCount == 0)
        {
            foxTxt.DOText(foxTextString, 2f).OnComplete((() => _speechDone = true));
        }

        if (_speechCount == 1)
        {
            canvas.gameObject.SetActive(false);
            var box = TaskPanelController.instance.GetLastMainTask();
            box.infoText.text = "Destroy Barrier";
            GetComponentInChildren<Shield>().enabled = true;
        }

        _speechCount++;
    }

    public void BarrierClose()
    {
        enemyShield.GetComponent<ParticleSystem>().Stop();
    }
}