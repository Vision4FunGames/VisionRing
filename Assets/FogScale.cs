using System;
using UnityEngine;
using DG.Tweening;
using Exoa.TutorialEngine;

public class FogScale : MonoBehaviour
{
    public Vector3 targetScale;
    private Vector3 startScale;
    private GameObject particle;

    public bool isOpen;

    public void Start()
    {
        startScale = new Vector3(0, 0, 0f);
    }

    public void StartScale()
    {
        if (!isOpen)
        {
            transform.DOKill();
            gameObject.SetActive(true);
            transform.localScale = startScale;
            transform.DOScale(targetScale, 3).SetDelay(.4f).SetEase(Ease.Linear).OnComplete(() =>
            {
                gameObject.SetActive(false);
                isOpen = true;
                if (GameManager.instance.tutorialSection== 0 && GameManager.instance.tutorialCounter == 6)
                {
                    GameManager.instance.TutorialLoad();
                }
            });
        }
        else
        {
            transform.DOKill();
            gameObject.SetActive(true);
            transform.DOScale(startScale, 2.5f).SetEase(Ease.Linear).OnComplete(() =>
            {
                gameObject.SetActive(false);
                isOpen = false;
                if (GameManager.instance.tutorialSection== 0 && GameManager.instance.tutorialCounter == 8)
                {
                    GameManager.instance.tutoCage.GetComponent<TutoCage>().cageZone.gameObject.SetActive(true);
                }
            });
        }
    }
}