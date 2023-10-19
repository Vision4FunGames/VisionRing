using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
  private void OnParticleCollision(GameObject other)
  {
    if (other.CompareTag("Enemy"))
    {
      print("pppppppppppppppppp");
    }
  }
}
