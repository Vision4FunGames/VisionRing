using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class MeetMarley : MonoBehaviour
{
    public GameObject blcPanel;
    public int clickCount;
    public UpgradeItem bone;
    public UpgradeItem skelet;
    public UpgradeItem gem;
    private string blc =
        "Hello, adventurer, welcome to my place. I'm Blacksmith Buckley, bring me your items that need polish.";
        
    private string blc1 =
        "Powerful spells keep you alive in the dungeon. But they don't work as instantly as a potion that heals you.";

    private bool _speechDone;

    public TextMeshProUGUI mrcText;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.magician.transform.DOScale(Vector3.one, 1);
        PlayerPrefs.SetInt("Magician", 1);
        GameManager.instance.magician.GetComponent<Waypoint_Indicator>().enabled = true;
        FindObjectOfType<CameraController>().magicianTutorial = true;
        GameManager.instance.skillTutorial = true;
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
            }));
        }
        else if (clickCount == 1)
        {
            for (int i = 0; i < 10; i++)
            {
                EconomyManager.instance.EarnUpgradeItem(bone);
                EconomyManager.instance.EarnUpgradeItem(skelet);
                EconomyManager.instance.EarnUpgradeItem(gem);
            }
            
            blcPanel.SetActive(false);
            UiManager.instance.MagicianUI();
        }
        else if (clickCount == 2)
        {
            UiManager.instance.CloseAllUI();
            blcPanel.SetActive(true);
            mrcText.text = "";
            mrcText.DOText(blc1, 1).OnComplete((() =>
            {
                _speechDone = true;
                UiManager.instance.armorSlot.UseItem();
            }));
        }else if (clickCount == 3)
        {
            blcPanel.SetActive(false);
            UiManager.instance.GamePlayUI();
            GameManager.instance.magician.GetComponent<Waypoint_Indicator>().enabled = false;
            GetComponent<TaskPrefab>().isCompleted = true;
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
