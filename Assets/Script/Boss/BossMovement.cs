using UnityEngine;
using UnityEngine.AI;

public class BossMovement : MonoBehaviour
{
    private BossManager bossManager;
    private float rateOfFire = 3;
    [HideInInspector] public float currentTime;
    [HideInInspector] public bool attackBoss = false;
    [HideInInspector] public NavMeshAgent navMeshAgent;
    [HideInInspector] public bool isStun;
    private BossCombat bossCombat;
    private Animator animator;
    private Player player;
    public float detectPlayerRange;
    private float currentAnimSpeed;
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
        if (distance < detectPlayerRange && !attackBoss && !isStun)
        {
            MovementTarget();
        }

        if (distance < 10 && !attackBoss && currentTime > rateOfFire && !isStun)
        {
            Attack();
        }
    }

    public void MovementTarget()
    {
        currentAnimSpeed = navMeshAgent.velocity.magnitude / (navMeshAgent.speed);
        navMeshAgent.SetDestination(player.transform.position);
        animator.SetFloat("Blend", currentAnimSpeed);
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
        animator.SetBool("stun",true);
        animator.Play("Stun");
        CancelInvoke("StunDisable");
        Invoke("StunDisable",7);
    }

    public void StunDisable()
    {
        navMeshAgent.speed = 2;
        bossManager.stunParticle.Stop();
        isStun = false;
        attackBoss = false;
        animator.SetBool("stun",false);
        
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectPlayerRange);
    }
}