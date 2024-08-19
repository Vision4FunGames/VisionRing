using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurifyObject : MonoBehaviour
{
    private Purify _purify;
    private void Awake()
    {
        _purify = GetComponentInParent<Purify>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
            _purify.DestroyObj();
            ParticleSystem c =Instantiate(ParticleManager.instance.purifyParticle);
            c.transform.position = transform.position + new Vector3(0, 1, 0);
            c.Play();
            Destroy(gameObject);
        }
    }
}
