using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class SolarSystem : MonoBehaviour
{
    public bool solarSystemtutorial;
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
       if (solarSystemtutorial)
       {
           PlayerPrefs.SetInt("solarTuto",1);
           solarSystemtutorial = false;
           Invoke("TutorialSolarPopUp",3);
       }
       gameObject.SetActive(true);
       transform.DOKill();
       transform.localScale = new Vector3(0.52f, 0.73f, 0.62f);
       transform.DOScale(new Vector3(30, 35, 30), .6f).SetEase(SolarAnimationCurve).OnComplete((() =>
       {
           DOTween.To(() =>  lensDistortion.intensity.value , x =>  lensDistortion.intensity.value  = x,  50, 0.1f).OnComplete((() =>
               DOTween.To(() =>  lensDistortion.intensity.value , x =>  lensDistortion.intensity.value  = x,  0, 0.05f)));
           transform.DOScale(new Vector3(1000.52f,1200.38f,1000.52f), 4).OnComplete((() =>
           {
               transform.localScale = new Vector3(1000.52f,1200.38f,1000.52f);
               gameObject.SetActive(false);
           }));
       }));
   }

    public void TutorialSolarPopUp()
    {
        UiManager.instance.TaskSolarPopUp.transform.DOScale(Vector3.one, .5f).OnComplete((() =>
        {
            UiManager.instance.TaskSolarPopUp.GetComponentInChildren<Button>().transform.DOScale(Vector3.one, .25f)
                .SetDelay(2f);
        }));
    }
}
