using DG.Tweening;
using TMPro;
using UnityEngine;

public class MeetRuthledge : MonoBehaviour
{
    private string dialogOne =
        "So you're the adventurer everyone's talking about. Godspeed!";

    private string dialogTwo =
        "Travellers and adventurers passing through here hand me the mystical keys. You can contact me when you want to enter a dungeon. Don't push yourself too hard.";

    public TextMeshProUGUI TextMeshProUGUI;

    private bool _speechDone;
    public GameObject conPanel;
    private int clickCount;

    void Start()
    {
        GameManager.instance.baskan.GetComponent<Waypoint_Indicator>().enabled = true;
        FindObjectOfType<CameraController>().baskanTutorial = true;
        PlayerPrefs.SetInt("Baskan", 1);
        GameManager.instance.baskan.transform.DOScale(Vector3.one, 1);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _speechDone)
        {
            SpeechStart();
        }
    }

    public void SpeechStart()
    {
        _speechDone = false;

        if (clickCount == 0)
        {
            GameManager.instance.baskan.GetComponent<Waypoint_Indicator>().enabled = false;
            TextMeshProUGUI.text = " ";
            conPanel.SetActive(true);
            TextMeshProUGUI.DOText(dialogOne, 1f).OnComplete((() => { _speechDone = true; }));
        }

        if (clickCount == 1)
        {
            TextMeshProUGUI.text = " ";
            TextMeshProUGUI.DOText(dialogTwo, 1f).OnComplete((() => { _speechDone = true; }));
        }

        if (clickCount == 2)
        {
            conPanel.SetActive(false);
            UiManager.instance.DungeonPanelOpen();
        }

        clickCount++;
    }
}