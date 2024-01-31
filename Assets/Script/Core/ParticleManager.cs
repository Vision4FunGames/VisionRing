using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ParticleManager : MonoBehaviour
{
    public ParticleSystem swimParticle;
    public ParticleSystem bombparticle;
    public ParticleSystem playerDashParticle;
     public ParticleSystem playerEnvanterParticleSystem;
    public static ParticleManager instance;
    
    private void Awake()
    {
        instance = this;
    }
}
