using DG.Tweening;
using UnityEngine;

public class CanvasLookAt : MonoBehaviour
{
   public Camera mainCamera;
   private Canvas canvas;
   [SerializeField]private bool isIndicator,isStarted;
   private void OnEnable()
   {
      mainCamera = Camera.main;
      canvas = GetComponent<Canvas>();
      canvas.worldCamera = mainCamera;
   }

   private void Update()
   {
      transform.rotation = Quaternion.LookRotation(transform.position - mainCamera.transform.position);
      if (isIndicator && !isStarted)
      {
         Indicator();
      }
      
   }

   private void Indicator()
   {
      if (!isStarted)
      {
         transform.GetComponent<RectTransform>().transform.DOLocalMove(new Vector3(0, 0.77f, 0),1f).SetLoops(-1,LoopType.Yoyo);
         isStarted = true;
      }
     
   }
}
