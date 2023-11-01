using UnityEngine;
using UnityEngine.AI;

public class BossMovement : MonoBehaviour
{
    private BossManager bossManager;
    private BossCombat bossCombat;
    private Animator animator;
    private Player player;
    [HideInInspector] public float detectPlayerRange;
    [HideInInspector] public float currentAnimSpeed;
    [HideInInspector] public float currentTime;
    private float distance;
    public bool isStun;


    void Start()
    {
        bossManager = GetComponent<BossManager>();
        bossCombat = GetComponent<BossCombat>();
        animator = GetComponentInChildren<Animator>();
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        distance = Vector3.Distance(player.transform.position, transform.position);
        currentAnimSpeed = bossManager.navMeshAgent.velocity.magnitude;
        animator.SetFloat("Blend", currentAnimSpeed);
        if (distance < detectPlayerRange && !bossCombat.attackBos && !isStun && bossManager.navMeshAgent &&
            !bossManager.isSkeletsLive)
        {
            MovementTarget();
        }

        if (distance < 10 && !bossCombat.attackBos && currentTime > bossCombat.rateOfFire && !isStun &&
            !bossManager.isSkeletsLive)
        {
            Attack();
        }
    }

    public void MovementTarget()
    {
        bossManager.navMeshAgent.SetDestination(player.transform.position);
    }

    public void Attack()
    {
        bossCombat.attackBos = true;
        bossManager.navMeshAgent.speed = 0;
        bossCombat.AttackBoss();
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectPlayerRange);
    }
}