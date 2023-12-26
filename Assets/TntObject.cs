using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TntObject : MonoBehaviour
{
    public ParticleSystem startParticle;
    public ParticleSystem explosionParticle;
    private bool hit;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
            Hit();
        }
    }

    public void Hit()
    {
        if (!hit)
        {
            startParticle.Play();
            hit = true;
        }
        else
        {
            explosionParticle.Play();
            Destroy(gameObject,.5f);
        }
    }

  

}
