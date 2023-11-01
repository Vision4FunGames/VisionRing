using System;
using UnityEngine;

public class BossSword : MonoBehaviour
{
    private BossCombat bossCombat;

    private void Awake()
    {
        bossCombat = GetComponentInParent<BossCombat>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BossTrap"))
        {
            other.GetComponent<BossTrap>().Explosion();
            bossCombat.StunEnable();
        }
    }
}