using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

public class CanvasMaskFade : MonoBehaviour
{
    private Image Image;

    // Start is called before the first frame update
    void Start()
    {
        Image = GetComponent<Image>();
    }

    [Button("FadeClose")]
    public void ImageFadeClose()
    {
        Image.DOColor(new Color(1, 1, 1, 0), 2);
    }

    [Button("FadeOpen")]
    public void ImageFadeOpen()
    {
        Image.DOColor(new Color(1, 1, 1, 1), .2f);
    }
}