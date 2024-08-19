
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;
    private EnemyStats _enemyStats; 
    public Transform target;
    private Transform startTarget;
    NavMeshAgent agent;
    CharacterCombat combatManager;
    private float distance,playerDistance;
    private GameManager _gameManager;
    private float retrieveDistance = 3f;
    public bool attack;
    [HideInInspector] public bool bombActiveted;
    [HideInInspector] public bool bombexp;
    private Enemy enemy;
    private CharacterAnimator characterController;
    public bool isAttackStaff;
    
    public float patrolRange = 10f; // Dolaşma alanının yarıçapı
    public float patrolInterval = 3f; // Yeni hedefe gitme aralığı
    private float timer;

    void Start()
    {
       
        enemy = GetComponent<Enemy>();
        _gameManager = FindObjectOfType<GameManager>();
        _enemyStats = GetComponent<EnemyStats>();
        if (!isAttackStaff)
        {
            target = Player.instance.transform;
        }
        startTarget = target;
        agent = GetComponent<NavMeshAgent>();
        combatManager = GetComponent<CharacterCombat>();
        characterController = GetComponent<CharacterAnimator>();
    }

    void Update()
    {
        // Get the distance to the player
        if (target)
        {
            distance = Vector3.Distance(target.position, transform.position);
            playerDistance = Vector3.Distance(Player.instance.transform.position, transform.position);
            if (playerDistance<= lookRadius)
            {
                target = Player.instance.transform;
                isAttackStaff = false;
            }
            else
            {
                isAttackStaff = true;
                target = startTarget;
            }
        }
        else
        {
           
        }

        timer -= Time.deltaTime;
       

        


        // If inside the radius
        if (distance <= lookRadius && agent != null && !_enemyStats.die && _gameManager.gameState != GameState.GameOver)
        {
            if (_enemyStats.enemyType == EnemyType.Ghost)
            {
                if (target)
                {
                    if (distance < enemy.radius)
                    {
                        agent.isStopped = false;
                        attack = false;
                        Vector3 geriCekilmeYonu = transform.position - Player.instance.transform.position;
                        geriCekilmeYonu = geriCekilmeYonu.normalized * retrieveDistance;
                        Vector3 yeniHedef = transform.position + geriCekilmeYonu;
                        agent.SetDestination(yeniHedef);
                    }
                    else
                    {
                        agent.isStopped = true; // Agent'ı durdur
                        agent.velocity = Vector3.zero; // Hareketi sıfırla
                        attack = true; // Ateş etmeye başla
                        // Geri çekilme mesafesi kadar geriye doğru git
                        if (!isAttackStaff)
                        {
                            combatManager.Attack(Player.instance.GetComponent<PlayerStats>());
                        }
                        else
                        {
                            combatManager.Attack();
                        }
                        
                        FaceTarget();
                    }
                }
               
                
            }
            else
            {
//                print("Enemys");
                if (target && agent.enabled)
                    agent.SetDestination(target.position);
                else
                {
                    target = Player.instance.transform;
                    agent.SetDestination(target.position);
                }

                if (distance <= agent.stoppingDistance && !characterController.shied)
                {
                    // Attack
                    if (!isAttackStaff)
                    {
                        combatManager.Attack(Player.instance.GetComponent<PlayerStats>());
                    }
                    else
                    {
                        combatManager.Attack();
                    }
                    FaceTarget();
                }
            }
        }
        else if (distance > lookRadius && agent != null && agent.enabled && !_enemyStats.die && _gameManager.gameState != GameState.GameOver)
        { 
            if (timer <= 0)
            {
                SetRandomDestination();
            }
           
        }
    }

    void SetRandomDestination()
    {
        timer = patrolInterval;
        Vector3 randomDirection = Random.insideUnitSphere * patrolRange;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, patrolRange, 1);
        Vector3 finalPosition = hit.position;
        agent.SetDestination(finalPosition);
        
    }
    // Point towards the player
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}