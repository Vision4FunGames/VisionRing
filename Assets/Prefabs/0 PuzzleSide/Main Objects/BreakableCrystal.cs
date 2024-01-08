using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BreakableCrystal : MonoBehaviour
{
    public int level;
    public ParticleSystem crashParticle;
    public int GoldAmount => EconomyManager.instance.GetGemAmount(level);

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            crashParticle.gameObject.SetActive(true);
        }
    }
}
