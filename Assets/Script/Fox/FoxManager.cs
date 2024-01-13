using System;
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
    public Transform waterJumpPos;
    public bool tutorial;

    private void Awake()
    {
       
    }

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        // if (PlayerPrefs.HasKey("Edit"))
        // {
        //     transform.position = PlayerManager.instance.startPlayerPos + new Vector3(0, 0, 5f);
        // }
        if (!GameManager.instance.tutorial && GameManager.instance.tutorialSection ==0)
        {
            agent.Stop();
            agent.enabled = false;
        }
        player = Player.instance.transform;
        foxAnim = GetComponent<Animator>();
        foxBaseTransform = transform.position;
            // _movementPlayer = player.gameObject.GetComponent<PlayerMovement>();
        
        timer = wanderingTimer;
        foxHintCounter = 0;
    }

    void Update()
    {
        if (agent.isActiveAndEnabled  && !tutorial)
        {
            NavMeshStart();
        }
        else if (tutorial)
        {
            FinishTutorial();
        }

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
            if (GameManager.instance.gameState == GameState.Tutorial && GameManager.instance.tutorialCounter ==5)
            {
                GameManager.instance.TutorialLoad();
            }
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

    public void EnableAgent()
    {
        agent.enabled = true;
    }

    public void FinishTutorial()
    {
        agent.speed = 15f;
        tutorial = true;
        var position = waterJumpPos.position;
        distance = Vector3.Distance(transform.position, position);
        distance = (int)distance;
        if (distance > agent.stoppingDistance)
        {
            agent.SetDestination(position);
            foxAnim.SetBool("standupBool",true);
            foxAnim.SetBool("sitBool",false);
        }
        if(distance <= agent.stoppingDistance)
        {
            foxAnim.SetBool("standupBool",false);
            foxAnim.SetBool("sitBool",true);
            foxAnim.SetTrigger("jump");
        }
    }
}