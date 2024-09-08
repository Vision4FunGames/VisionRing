using System;
using DG.Tweening;
using TaskSystem;
using TMPro;
using UnityEngine;

public class MerchantTutorial : MonoBehaviour
{
    public bool handBool;
    public GameObject hand;
    public Canvas canvas;
    public TextMeshProUGUI mrcTxt;
    public TextMeshProUGUI playerTxt;
    public GameObject mrcPanel;
    public GameObject playerPanel;

    private string mrcTextOne =
        "We need stronger weapons and armor to survive. Why were you in these dangerous dungeons?";

    private string playerTextOne =
        "I need to solve a mystery my parents left me. You'll learn when we're best friends.";

    private string mrcTextTwo = "Let's find my other captured friend. She'll help you get stronger.";

    public void Start()
    {
        if(handBool)
            HandScaleAnimation();
    }
    
    public void DiesEnemies()
    {
        var box = TaskPanelController.instance.GetLastMainTask();
        box.infoText.text = "Talk with Aaliyah";
    }
    
    void OnMouseDown()
    {
        print (name);	
    }

    public void Update()
    {
        HandAnimation();
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
            hand.transform.position = goldpos+new Vector3(10,0,10);
        }
    }
}