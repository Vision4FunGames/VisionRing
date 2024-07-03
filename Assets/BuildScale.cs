using System;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

public class BuildScale : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DRM"))
        {
            ScaleUp();
        }
    }

    [Button("LevelMapTest")]
    public void ScaleUp()
    {
        transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutBack);
    }
}