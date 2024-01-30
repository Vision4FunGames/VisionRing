using System;
using UnityEngine;
using DG.Tweening;

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
            });
        }
    }
}