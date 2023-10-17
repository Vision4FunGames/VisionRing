using UnityEngine;

public class CanvasLookAt : MonoBehaviour
{
   public Camera mainCamera;
   private Canvas canvas;
   private void OnEnable()
   {
      mainCamera = Camera.main;
      canvas = GetComponent<Canvas>();
      canvas.worldCamera = mainCamera;
   }

   private void Update()
   {
      transform.rotation = Quaternion.LookRotation(transform.position - mainCamera.transform.position);
   }
}
