using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public ParticleSystem playerDashParticle;

    public static ParticleManager instance;

    private void Awake()
    {
        instance = this;
    }
}
