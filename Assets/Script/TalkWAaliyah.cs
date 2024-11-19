using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class TalkWAaliyah : MonoBehaviour
{
    private CameraController cameraController;
    public GameObject mrcPanel;
    private int clickCount;
    private string mrc1 = "Great, I've invited some friends who can help you, take your new armour to Buckley and ask him to upgrade it.";
    private string mrc2 = "Don't forget to visit by my shop whenever you want to equip new weapons and armour.";
    private bool _speechDone;
    public TextMeshProUGUI mrcText;
 
    
    private void Start()
    {
        GameManager.instance.merchant.GetComponent<Waypoint_Indicator>().enabled = true;
        GameManager.instance.merchant.transform.DOScale(Vector3.one, 1);
        cameraController = FindObjectOfType<CameraController>();
        cameraController.merchantTutorial = true;
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
            mrcPanel.SetActive(false);
            GameManager.instance.merchant.GetComponent<Waypoint_Indicator>().enabled = false;
            GetComponent<TaskPrefab>().isCompleted = true;
            Destroy(gameObject,.1f);
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
