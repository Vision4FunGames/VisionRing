using UnityEngine;
using UnityEngine.AI;

public class BossMovement : MonoBehaviour
{
    private float rateOfFire = 3;
    [HideInInspector]public float currentTime;
    [HideInInspector]public bool attackBoss = false;
    [HideInInspector]public NavMeshAgent navMeshAgent;
    private BossCombat bossCombat;
    private Animator animator;
    private Player player;
    public float detectPlayerRange;
    private float currentAnimSpeed;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        bossCombat = GetComponent<BossCombat>();
        animator = GetComponentInChildren<Animator>();
        player = FindObjectOfType<Player>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        distance = Vector3.Distance(player.transform.position,transform.position);
        if (distance < detectPlayerRange && !attackBoss)
        {
            MovementTarget();
        }

        if (distance < 10 && !attackBoss && currentTime > rateOfFire)
        {
            attackBoss = true;
            navMeshAgent.speed = 0;
            bossCombat.AttackBoss();
        }
    }

    public void MovementTarget()
    {
        currentAnimSpeed = navMeshAgent.velocity.magnitude / (navMeshAgent.speed);
        navMeshAgent.SetDestination(player.transform.position);
        animator.SetFloat("Blend", currentAnimSpeed);
    }
    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectPlayerRange);
    }
}