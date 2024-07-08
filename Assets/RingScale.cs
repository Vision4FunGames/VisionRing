using DG.Tweening;
using UnityEngine;

public class RingScale : MonoBehaviour
{
    public Vector3 targetScale;
    public void ScaleUp()
    {
        transform.DOScale(targetScale, .5f).SetEase(Ease.OutBack).OnComplete((() =>
        {
        }));
    }
    
    public void ScaleDown()
    {
        transform.DOScale(new Vector3(0, 0, 0), .5f).SetEase(Ease.OutBack).OnComplete((() =>
        {
        }));
    }
}
