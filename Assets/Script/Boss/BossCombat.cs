using DG.Tweening;
using UnityEngine;

public class BossCombat : MonoBehaviour
{
    public bool attackBos;
    private Animator animator;
    private BossMovement bossMovement;
    public GameObject circleParentObj;
    public GameObject chargeParentObj;
    private BossManager bossManager;
    public Collider circleCollider, swordCollider;
    public float rateOfFire = 3;
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        bossMovement = GetComponent<BossMovement>();
        bossManager = GetComponent<BossManager>();
    }


    public void FootSpriteAnimation()
    {
        circleParentObj.SetActive(true);
        circleParentObj.transform.GetChild(1).transform.localScale = new Vector3(0, 0, 0);
        circleParentObj.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 1.5f)
            .OnComplete((() => circleParentObj.SetActive(false)));
    }

    public void ChargeSpriteAnimation()
    {
        chargeParentObj.SetActive(true);
        chargeParentObj.transform.GetChild(1).transform.localScale = new Vector3(0, 0, 0);
        chargeParentObj.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 1.5f)
            .OnComplete(() => chargeParentObj.SetActive(false));
    }

    public void AttackBoss()
    {
        int rand = Random.Range(0, 21);

        if (rand <= 7) // foot
        {
            FootSpriteAnimation();
            animator.Play("Attack1");
        }
        else if (rand > 7 && rand <= 14) // charge 1
        {
            ChargeSpriteAnimation();
            animator.Play("Attack2");
        }
        else if (rand > 14 && rand <= 21) // charge 2
        {
            ChargeSpriteAnimation();
            animator.Play("Attack3");
        }
    }

    public void StunEnable()
    {
        bossManager.stunParticle.Play();
        bossMovement.isStun = true;
        animator.SetBool("stun", true);
        animator.Play("Stun");
        CancelInvoke("StunDisable");
        Invoke("StunDisable", 7);
    }

    public void StunDisable()
    {
        if (!bossManager.isSkeletsLive)
        {
            bossManager.navMeshAgent.speed = 2;
            bossManager.stunParticle.Stop();
            bossMovement.isStun = false;
            attackBos = false;
            animator.SetBool("stun", false);
        }
    }
}