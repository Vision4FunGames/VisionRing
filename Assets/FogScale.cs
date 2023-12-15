using System;
using UnityEngine;
using DG.Tweening;

public class FogScale : MonoBehaviour
{
    public Vector3 targetScale;
    private Vector3 startScale;
    private GameObject particle;


    public void Start()
    {
        startScale = transform.localScale;
    }

    public void StartScale()
    {
        gameObject.SetActive(true);
        transform.localScale = startScale;
        gameObject.GetComponent<ParticleSystem>().Play();
        transform.DOScale(targetScale, 12f).SetEase(Ease.Linear).OnComplete(() => { gameObject.SetActive(false); });
    }
}