using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public ParticleSystem questCompleteConfetti;
    public ParticleSystem playerQuestParticle;
    public ParticleSystem purifyParticle;
    public ParticleSystem smokeDeath;
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
