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

    public void ImageClose()
    {
        Image = GetComponent<Image>();
        Image.DOKill();
        Image.color = new Color(1, 1, 1, 0);
    }
    public void ImageOpen()
    {
        Image = GetComponent<Image>();
        Image.DOKill();
        Image.color = new Color(1, 1, 1, 1);
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