using System;
using DG.Tweening;
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
        // if (!GameManager.instance.tutorial && GameManager.instance.tutorialSection ==0)
        // {
        //     agent.Stop();
        //     agent.enabled = false;
        //     foxAnim.SetBool("sitBool",true);
        // }
        player = Player.instance.transform;

        foxBaseTransform = transform.position;
        // _movementPlayer = player.gameObject.GetComponent<PlayerMovement>();

        timer = wanderingTimer;
        foxHintCounter = 0;
        //PlayerPrefs.SetInt("Fox", 1);
        if (PlayerPrefs.GetInt("Fox") == 1)
        {
            gameObject.SetActive(true);
        }
       // else
            //gameObject.SetActive(false);
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
        if (Player.instance.isWalk && !stop)
        {
            if (distance > agent.stoppingDistance)
            {
                agent.SetDestination(position);
                // print("Navmesh startt Destination:" +position);
                foxAnim.SetBool("standupBool", true);
                foxAnim.SetBool("sitBool", false);
            }
        }

        if (distance <= agent.stoppingDistance)
        {
            foxAnim.SetBool("standupBool", false);
            foxAnim.SetBool("sitBool", true);
            if (GameManager.instance.gameState == GameState.Tutorial && GameManager.instance.tutorialCounter == 8)
            {
                GameManager.instance.TutorialLoad();
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


    private void OnMouseDown()
    {
        if (FindObjectOfType<TalkFoxCollectReward>())
        {
            FindObjectOfType<TalkFoxCollectReward>().SpeechFox();
        }
    }

    public void TutorialFoxFinish()
    {
        Vector3 pos = transform.localPosition + new Vector3(0, 0, 7f);
        foxAnim.SetBool("sitBool", false);
        transform.DOLocalMove(pos, 1f).SetDelay(1).OnComplete(EnableAgent);
        //Invoke("EnableAgent",1f);
    }

    public void FinishTutorial()
    {
        //agent.speed = 15f;
        if (!tutorial)
        {
            agent.enabled = true;
            tutorial = true;
            GameManager.instance.tutoCage.GetComponent<NavMeshObstacle>().enabled = true;
            agent.SetDestination(waterJumpPos.position);
            foxAnim.SetBool("sitBool", true);
            UiManager.instance.CinematicCanvasOpen();
        }

        if (distance <= agent.stoppingDistance)
        {
            foxAnim.SetBool("sitBool", false);
            //foxAnim.SetTrigger("jump");
        }
    }
}