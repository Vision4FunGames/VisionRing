using UnityEngine;
using UnityEngine.AI;

public class FoxManager : MonoBehaviour
{
    public Transform player; // oyuncu referansı
    private NavMeshAgent agent;
    public float wanderingRadius; // gezinme yarıçapı
    public float wanderingTimer; // gezinme zamanlayıcısı
    private float timer;
    private bool stop;
    //private PlayerMovement _movementPlayer;
    private float distance;
    public bool isCallFox;
    public Vector3 foxBaseTransform;
    private Animator foxAnim;
    public int foxHintCounter;

    void Start()
    {
        player = Player.instance.transform;
        foxAnim = GetComponent<Animator>();
        foxBaseTransform = transform.position;
            // _movementPlayer = player.gameObject.GetComponent<PlayerMovement>();
        agent = GetComponent<NavMeshAgent>();
        timer = wanderingTimer;
        foxHintCounter = 0;
    }

    void Update()
    {
        NavMeshStart();
    }

    public void NavMeshStart()
    {
        var position = player.position;
        distance = Vector3.Distance(transform.position, position);
        distance = (int)distance;
        if ( Player.instance.isWalk && !stop)
        {
            if (distance > agent.stoppingDistance)
            {
                agent.SetDestination(position);
                foxAnim.SetBool("standupBool",true);
                foxAnim.SetBool("sitBool",false);
            }
        }
        if(distance <= agent.stoppingDistance)
        {
            foxAnim.SetBool("standupBool",false);
            foxAnim.SetBool("sitBool",true);
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, wanderingRadius);
    }
    public void GoToPlayer()
    {
        stop = true;
        agent.enabled = false;
        Invoke("GoToPlayer2",3);
    }

    public void GoToPlayer2()
    {
        transform.position = player.transform.position;
        agent.enabled = true;
        stop = false;
    }
}