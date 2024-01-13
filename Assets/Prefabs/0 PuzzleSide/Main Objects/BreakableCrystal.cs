using System;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
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
            crashParticle.gameObject.transform.SetParent(null, true);
            crashParticle.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
    [Button]
    public void Test()
    {
        crashParticle.gameObject.transform.SetParent(null, true);
        crashParticle.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
