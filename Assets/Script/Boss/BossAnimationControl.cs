using UnityEngine;

public class BossAnimationControl : MonoBehaviour
{
    private BossMovement bossMovement;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        bossMovement = GetComponentInParent<BossMovement>();
    }

    public void AnimationSlowed(float animspeed)
    {
        animator.speed = animspeed;
    }

    public void AnimationResetSpeed()
    {
        animator.speed = 1;
    }

    public void EndAttack()
    {
        PlayerManager.instance.CameraShakeCombo(1f, .8f);
        bossMovement.attackBoss = false;
        bossMovement.currentTime = 0;
        bossMovement.navMeshAgent.speed = 2;
    }
}