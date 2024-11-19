using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MeetShirley : MonoBehaviour
{
    private string dialogOne =
        "If you're looking for powerful potions and potent consumables, you're in the right place my friend.";

    private string dialogTwo =
        "You look fully prepared for battle now. Meet Ruhletge and buy a dungeon key from him.";

    public Button cltBtn;
    public GameObject conPanel;
    public UpgradeItem Fasulye;
    public TextMeshProUGUI TextMeshProUGUI;
    private bool _speechDone;
    private int clickCount;
    public GameObject rewardPanel;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.shirley.GetComponent<Waypoint_Indicator>().enabled = true;
        FindObjectOfType<CameraController>().farmerTutorail = true;
        PlayerPrefs.SetInt("Farmer", 1);
        GameManager.instance.shirley.transform.DOScale(Vector3.one, 1);
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
        rewardPanel.transform.DOScale(Vector3.zero, .2f);
        SpeechStart();
    }

    public void SpeechStart()
    {
        _speechDone = false;

        if (clickCount == 0)
        {
            conPanel.SetActive(true);
            TextMeshProUGUI.DOText(dialogOne, 1f).OnComplete((() => { _speechDone = true; }));
        }

        if (clickCount == 1)
        {
            conPanel.SetActive(false);
            rewardPanel.transform.DOScale(Vector3.one, .2f);
        }

        if (clickCount == 2)
        {
            conPanel.SetActive(true);
            TextMeshProUGUI.text = " ";
            TextMeshProUGUI.DOText(dialogTwo, 1f).OnComplete((() => { _speechDone = true; }));
        }

        if (clickCount == 3)
        {
            conPanel.SetActive(false);
            GameManager.instance.shirley.GetComponent<Waypoint_Indicator>().enabled = false;
            GetComponent<TaskPrefab>().isCompleted = true;
            Destroy(gameObject, .2f);
        }

        clickCount++;
    }
}