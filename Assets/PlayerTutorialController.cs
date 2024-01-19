using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Numerics;
using NaughtyAttributes;
using UnityEditor;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class PlayerTutorialController : MonoBehaviour
{
   public GameObject indicator;
   private bool isActive;
   private Transform target;
   
 
   public void IndicatorOpen(Transform target)
   {
      if (target == null)
      {
         target = GameManager.instance.magician.transform;
      }
      this.target = target;
      indicator.gameObject.SetActive(true);
      Debug.Log("Indicator Entry");
      isActive = true;
   }
   [Button("Test")]
   public void IndicatorOpenTest()
   {
      if (target == null)
      {
         target = GameManager.instance.magician.transform;
      }
      this.target = target;
      indicator.gameObject.SetActive(true);
      Debug.Log("Indicator Entry");
      isActive = true;
   }

   public void IndicatorClose()
   {
      indicator.gameObject.SetActive(false);
   }

   // private void Update()
   // {
   //   // Debug.Log(isActive);
   //    if (isActive )
   //    {
   //       var rotation = Quaternion.LookRotation(indicator.transform.position - target.transform.position);
   //       indicator.transform.localRotation = new Quaternion(90, rotation.z,0,0);
   //    }
   // }
}
