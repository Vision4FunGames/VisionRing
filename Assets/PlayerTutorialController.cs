using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Numerics;
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
      this.target = target;
      indicator.gameObject.SetActive(true);
      Debug.Log("Indicator Entry");
      isActive = true;
   }

   public void IndicatorClose()
   {
      indicator.gameObject.SetActive(false);
   }

   private void Update()
   {
     // Debug.Log(isActive);
      if (isActive )
      {
         transform.rotation = Quaternion.LookRotation(transform.position - target.transform.position);
      }
   }
}
