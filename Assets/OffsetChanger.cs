using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class OffsetChanger : MonoBehaviour
{
   public Slider SliderX,SliderY,SliderZ;
   private Vector3 _basePosition;
   public CinemachineTransposer cmf;
   private void Start()
   { 
      cmf = GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTransposer>(); 
      _basePosition = cmf.m_FollowOffset;
   }

   public void UpdateX()
   {
     
      cmf.m_FollowOffset = new Vector3(SliderX.value,SliderY.value,SliderZ.value);
   }

 
}
