using System;
using UnityEngine;

public class BossSword : MonoBehaviour
{
    private BossMovement bossMovement;

    private void Awake()
    {
        bossMovement = GetComponentInParent<BossMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BossTrap"))
        {
            other.GetComponent<BossTrap>().Explosion();
            bossMovement.StunEnable();
        }
    }
}