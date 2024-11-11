using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MeetShirley : MonoBehaviour
{
    private string dialogOne =
        "If you're looking for powerful potions and potent consumables, you're in the right place my friend.";

    public Button cltBtn;
    public GameObject conPanel;
    public UpgradeItem Fasulye;
    public UpgradeItem bone;
    public TextMeshProUGUI TextMeshProUGUI;
    private bool _speechDone;
    private int clickCount;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.shirley.GetComponent<Waypoint_Indicator>().enabled = true;
        FindObjectOfType<CameraController>().farmerTutorail = true;
        cltBtn.onClick.AddListener(CollectReward);
    }

    // Update is called once per frame
    void Update()
    {
        if (_speechDone && Input.GetMouseButtonDown(0))
        {
            SpeechStart();
        }
    }

    public void CollectReward()
    {
        EconomyManager.instance.EarnUpgradeItem(Fasulye);
        EconomyManager.instance.EarnUpgradeItem(Fasulye);
        EconomyManager.instance.EarnUpgradeItem(Fasulye);
    }
    public void SpeechStart()
    {
        _speechDone = false;

        if (clickCount == 0)
        {
            conPanel.SetActive(true);
            TextMeshProUGUI.DOText(dialogOne, 1).OnComplete((() =>
            {
                _speechDone = true;
               
            }));
        }

        if (clickCount == 1)
        {
            conPanel.SetActive(false);
            UiManager.instance.CloseAllUI();
            UiManager.instance.ShopUI();
        }

        clickCount++;
    }
}