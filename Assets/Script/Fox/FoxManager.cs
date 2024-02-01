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
        foxAnim = GetComponent<Animator>();
        if (!GameManager.instance.tutorial && GameManager.instance.tutorialSection ==0)
        {
            agent.Stop();
            agent.enabled = false;
            foxAnim.SetBool("sitBool",true);
        }
        player = Player.instance.transform;
       
        foxBaseTransform = transform.position;
            // _movementPlayer = player.gameObject.GetComponent<PlayerMovement>();
        
        timer = wanderingTimer;
        foxHintCounter = 0;
    }

    void FixedUpdate()
    {
        if (agent.enabled)
        {
            if (!tutorial)
            {
                NavMeshStart();  
            }
            else
            {
                FinishTutorial();
            }
        }

    }

    public void NavMeshStart()
    {
        //print("navmesh start");
        var position = player.position;
        distance = Vector3.Distance(transform.position, position);
        distance = (int)distance;
        if ( Player.instance.isWalk && !stop)
        {
            if (distance > agent.stoppingDistance)
            {
                agent.SetDestination(position);
               // print("Navmesh startt Destination:" +position);
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
                Invoke(GameManager.instance.TutorialLoad(),2f);
                //GameManager.instance.TutorialLoad();
                agent.enabled = false;
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, wanderingRadius);
    }
    public void EnableAgent()
    {
        agent.enabled = true;
    }

    public void FinishTutorial()
    {
        //agent.speed = 15f;
        if (!tutorial)
        {
            agent.enabled = true;
            tutorial = true;
            agent.SetDestination(waterJumpPos.position);
            foxAnim.SetBool("sitBool",true);
        }
        if(distance <= agent.stoppingDistance)
        {
            foxAnim.SetBool("sitBool",false);
            //foxAnim.SetTrigger("jump");
        }
      
    }
}