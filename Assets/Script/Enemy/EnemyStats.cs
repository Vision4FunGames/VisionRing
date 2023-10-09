using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{
   
   public event System.Action OnDie;
   private void Start()
   {
      
   }

   public override void Die()
   {
      if (OnDie !=null)
      {
         OnDie();
         
      }
      base.Die();
   }
   
}
