using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.AI;

public class Spider : MonoBehaviour
{
    public GameObject prefabSpiderWeb;
    private Animator animator;
    [HideInInspector] public NavMeshAgent navMeshAgent;
    [HideInInspector] public Player player;
    [HideInInspector] public float currentAttackTimer;
    public float distance;
    public bool attack;
    public float rateOfFire;
    private float currentFlameTimer;
    private CharacterStats characterStats;
    private Rigidbody rb;
    private Enemy enemy;
    public bool tornodo;
    public List<GameObject> spiderWebPool;
    public event System.Action OnDie;

    public bool mini;

    // Start is called before the first frame update
    void Start()
    {
        if (!mini)
        {
            for (int i = 0; i < 10; i++)
            {
                spiderWebPool.Add(Instantiate(prefabSpiderWeb));
            }
        }


        rb = GetComponent<Rigidbody>();
        enemy = GetComponent<Enemy>();
        characterStats = GetComponent<CharacterStats>();
        animator = GetComponentInChildren<Animator>();
        player = FindObjectOfType<Player>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        characterStats.mmProgressBar ??=
            Instantiate(Resources.Load<Canvas>("EnemyHealthBar"),
                new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity,
                transform).GetComponentInChildren<MMProgressBar>();

        characterStats.OnDie += DieSpider;
    }

    public GameObject GetWeb()
    {
        GameObject currentWeb = spiderWebPool[0];
        spiderWebPool.RemoveAt(0);
        return currentWeb;
    }

    public void AddSpiderWeb(GameObject currentWeb)
    {
        currentWeb.SetActive(false);
        currentWeb.GetComponent<Collider>().enabled = true;
        spiderWebPool.Add(currentWeb);
    }

    // Update is called once per frame
    void Update()
    {
        currentFlameTimer += Time.deltaTime;
        distance = Vector3.Distance(player.transform.position, transform.position);

        animator.SetFloat("runspeed", navMeshAgent.velocity.magnitude / navMeshAgent.speed, .1f, Time.deltaTime);
        currentAttackTimer += Time.deltaTime;
        if (!characterStats.die && !tornodo)
        {
            if (distance < 10 && !mini)
            {
                FaceTarget();
                if (currentAttackTimer > rateOfFire && !attack)
                    AttackNear();
            }
            if (distance < 5 && mini)
            {
                FaceTarget();
                if (currentAttackTimer > rateOfFire && !attack)
                    AttackNear();
            }

            if (distance is > 5 and < 30 && mini)
            {
                FaceTarget();
                if (!attack)
                {
                    animator.SetFloat("runspeed", navMeshAgent.velocity.magnitude / navMeshAgent.speed, .1f,
                        Time.deltaTime);
                    navMeshAgent.SetDestination(player.transform.position);
                }
            }

            if (distance is > 10 and < 30 && !mini)
            {
                FaceTarget();
                if (currentAttackTimer > rateOfFire * 2)
                {
                    int rand = Random.Range(0, 40);
                    if (rand < 0)
                    {
                        if (!attack)
                            AttackFar();
                    }
                    else
                    {
                        if (!attack)
                            SpawnMini();
                    }
                }
                else
                {
                    if (!attack)
                    {
                        animator.SetFloat("runspeed", navMeshAgent.velocity.magnitude / navMeshAgent.speed, .1f,
                            Time.deltaTime);
                        navMeshAgent.SetDestination(player.transform.position);
                    }
                }
            }
        }
    }

    public void SpawnMini()
    {
        attack = true;
        navMeshAgent.isStopped = true;
        animator.Play("Spawn");
    }

    public void FaceTarget()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    public void AttackNear()
    {
        attack = true;
        navMeshAgent.isStopped = true;
        animator.Play("AttackNear");
    }

    public void AttackFar()
    {
        attack = true;
        navMeshAgent.isStopped = true;
        animator.Play("AttackFar");
    }

    public void DieSpider()
    {
        GetComponent<Collider>().enabled = false;
        animator.Play("Death");
        navMeshAgent.speed = 0;
        characterStats.mmProgressBar.gameObject.SetActive(false);
        if (GetComponentInParent<TornadoExit>())
        {
            GetComponent<Enemy>().TornadoFinish();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tornado"))
        {
            enemy.TornadoStart(other.gameObject);
        }

        if (other.CompareTag("RotateFire"))
        {
            characterStats.TakeDamage(Player.instance.GetComponent<PlayerAttack>().CalculateDamage());
            ChechHealth();
        }

        if (other.CompareTag("SwordCollider"))
        {
            characterStats.TakeDamage(Player.instance.GetComponent<PlayerAttack>().CalculateDamage(),
                Player.instance.GetComponent<PlayerAttack>().critChance);
            ChechHealth();
        }

        if (other.CompareTag("Floor"))
        {
            rb.isKinematic = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Flame"))
        {
            if (currentFlameTimer > Player.instance.GetComponent<PlayerAttack>().flameDamageRateOfFire)
            {
                currentFlameTimer = 0;
                enemy.AddDomoveBack();
                characterStats.TakeDamage(Player.instance.GetComponent<PlayerAttack>().flameDamage);
                ChechHealth();
            }
        }
    }

    public void ChechHealth()
    {
        if (characterStats.die)
        {
            DieSpider();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.name == "ArrowRain")
        {
            print("aa");
            characterStats.TakeDamage(10);
            ChechHealth();
        }
    }
}