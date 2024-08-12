using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class SolarSystem : MonoBehaviour
{
    private Player player;
    private PostProcessVolume _processVolume;
    LensDistortion lensDistortion;
    private AmbientOcclusion _ambientOcclusion;
    public AnimationCurve SolarAnimationCurve;
    public void Start()
    {
        _processVolume = FindObjectOfType<PostProcessVolume>();
       
        _processVolume.profile.TryGetSettings(out lensDistortion);
        lensDistortion.intensity.value = 10f;
    }

   

    public void SlorThrow()
   {
       gameObject.SetActive(true);
       transform.DOKill();
       transform.localScale = new Vector3(0.52f, 0.73f, 0.62f);
       transform.DOScale(new Vector3(30, 35, 30), .6f).SetEase(SolarAnimationCurve).OnComplete((() =>
       {
           DOTween.To(() =>  lensDistortion.intensity.value , x =>  lensDistortion.intensity.value  = x,  50, 0.1f).OnComplete((() =>
               DOTween.To(() =>  lensDistortion.intensity.value , x =>  lensDistortion.intensity.value  = x,  0, 0.05f)));
           transform.DOScale(new Vector3(215.52f,259.38f,215.52f), 1).OnComplete((() =>
           {
               transform.localScale = new Vector3(215.52f, 259.38f, 215.52f);
               gameObject.SetActive(false);
           }));
       }));
       
   }
}
