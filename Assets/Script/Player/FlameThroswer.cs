using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThroswer : MonoBehaviour
{
   private void OnDestroy()
   {
      Player player = FindObjectOfType<Player>();
      player.speed = player.baseSpeed;
      player._playerAnimator.SetBool("Flame",false);
   }
}
