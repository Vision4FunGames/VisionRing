using DG.Tweening;
using TaskSystem;
using TMPro;
using UnityEngine;

public class MerchantTutorial : MonoBehaviour
{
    public Waypoint_Indicator WaypointIndicator;
    public ParticleSystem shieldExp;
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
    private int clickCount;
    public bool _speechDone;
    private bool foxSpeech;
    private bool finalSpeech;

    private string mrcTextOne =
        "Thanks for the try saving me. They are created a barrier it is created with dark magic.";

    private string mrcTextTwo =
        "Only those who can see these mystical powers can break through the barrier. My situation is hopeless. Give up.";

    private string mrcTextThree = "Thank you! I'd lost faith that I'd ever get out of here.";

    private string playerTextOne =
        "I need to solve a mystery my parents left me. You'll learn when we're best friends.";

    private string playerTextTwo =
        "You look like unchained right now, Ha hah!";

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
        if (clickCount == 0)
        {
            mrcPanel.SetActive(true);
            hand.gameObject.SetActive(false);
            handBool = false;
            SpeechStart();
            GetComponent<Collider>().enabled = false;
        }
        else if (clickCount == 1)
        {
            GetComponent<Collider>().enabled = false;
            _speechCount = 0;
            FinalSpeech();
            finalSpeech = true;
        }

        clickCount++;
    }

    public void FinalSpeech()
    {
        _speechDone = false;
        canvas.gameObject.SetActive(true);
        

        if (_speechCount == 0)
        {
            mrcPanel.gameObject.SetActive(false);
            playerPanel.SetActive(true);
            foxPanel.SetActive(false);
            playerTxt.text = "";
            playerTxt.DOText(playerTextTwo, 2f).OnComplete((() => _speechDone = true));
        }
        else if (_speechCount == 1)
        {
            mrcPanel.gameObject.SetActive(true);
            playerPanel.SetActive(false);
            foxPanel.SetActive(false);
            mrcTxt.text = "";
            mrcTxt.DOText(mrcTextThree, 2f).OnComplete((() => _speechDone = true));
        } else if (_speechCount == 2)
        {
            canvas.gameObject.SetActive(false);
            GetComponentInChildren<MerchantFollow>().enabled = true;
            GetComponent<TaskPrefab>().isCompleted = true;
        }

        _speechCount++;
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
        if (_speechDone && !foxSpeech && Input.GetMouseButtonDown(0) && !finalSpeech)
        {
            SpeechStart();
        }

        if (_speechDone && foxSpeech && Input.GetMouseButtonDown(0) && !finalSpeech)
        {
            FoxSpeech();
        }

        if (_speechDone && Input.GetMouseButtonDown(0) && finalSpeech)
        {
            FinalSpeech();
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
            GetComponentInChildren<Shield>().enabledShield = true;
        }

        _speechCount++;
    }

    public void ShieldBroken()
    {
        var box = TaskPanelController.instance.GetLastMainTask();
        box.infoText.text = "Talk With Aaliyah";
        shieldExp.Play();
        WaypointIndicator.enabled = true;
        WaypointIndicator.onScreenSpriteHide = false;
        GetComponentInChildren<Animator>().SetBool("standup", true);
        GetComponent<Collider>().enabled = true;
    }

    public void BarrierClose()
    {
        enemyShield.GetComponent<ParticleSystem>().Stop();
    }
}