using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour,IDamageable
{
    #region Variables

    private float health;
    
    
    #endregion


    public void Damage(float damageAmount)
    {
        health -= damageAmount;
    }
}
