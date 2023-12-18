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
        startScale = new Vector3(1.5f, 1.5f, 3f);
    }

    public void StartScale()
    {
        if (!isOpen)
        {
            gameObject.SetActive(true);
            transform.localScale = startScale;
            gameObject.GetComponent<ParticleSystem>().Play();
           // transform.DOScale(targetScale, 12f).SetEase(Ease.Linear).OnComplete(() => { gameObject.SetActive(false); });
           transform.DOScale(targetScale, 12f).SetEase(Ease.Linear);
           isOpen = true;
        }
        else
        {
            // transform.DOScale(targetScale, 12f).SetEase(Ease.Linear).OnComplete(() => { gameObject.SetActive(false); });
            transform.DOScale(new Vector3(.5f, .5f, 1f), 4f).SetEase(Ease.Linear).OnComplete(() =>
            {
                gameObject.GetComponent<ParticleSystem>().Stop();
                gameObject.SetActive(false);
            
                isOpen = false; 
            });
            
        }
        
    }
}