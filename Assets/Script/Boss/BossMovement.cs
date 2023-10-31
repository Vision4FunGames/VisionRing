using UnityEngine;
using UnityEngine.AI;

public class BossMovement : MonoBehaviour
{
    private BossManager bossManager;
    private float rateOfFire = 3;
    [HideInInspector] public float currentTime;
    public bool attackBoss = false;
    public NavMeshAgent navMeshAgent;
    public bool isStun;
    private BossCombat bossCombat;
    private Animator animator;
    private Player player;
    public float detectPlayerRange;
    public float currentAnimSpeed;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        bossManager = GetComponent<BossManager>();
        bossCombat = GetComponent<BossCombat>();
        animator = GetComponentInChildren<Animator>();
        player = FindObjectOfType<Player>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        distance = Vector3.Distance(player.transform.position, transform.position);
        currentAnimSpeed = navMeshAgent.velocity.magnitude;
        animator.SetFloat("Blend", currentAnimSpeed);
        if (distance < detectPlayerRange && !attackBoss && !isStun && navMeshAgent && !bossManager.isSkeletsLive)
        {
            MovementTarget();
        }

        if (distance < 10 && !attackBoss && currentTime > rateOfFire && !isStun && !bossManager.isSkeletsLive)
        {
            Attack();
        }
    }

    public void MovementTarget()
    {
        navMeshAgent.SetDestination(player.transform.position);
    }

    public void Attack()
    {
        attackBoss = true;
        navMeshAgent.speed = 0;
        bossCombat.AttackBoss();
    }

    public void StunEnable()
    {
        bossManager.stunParticle.Play();
        isStun = true;
        animator.SetBool("stun", true);
        animator.Play("Stun");
        CancelInvoke("StunDisable");
        Invoke("StunDisable", 7);
    }

    public void StunDisable()
    {
        if (!bossManager.isSkeletsLive)
        {
            navMeshAgent.speed = 2;
            bossManager.stunParticle.Stop();
            isStun = false;
            attackBoss = false;
            animator.SetBool("stun", false);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectPlayerRange);
    }
}