using System.Collections;
using DG.Tweening;
using Exoa.TutorialEngine;
using GameAnalyticsSDK;
using Lofelt.NiceVibrations;
using Script.Player.PlayerStateMachine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using Image = UnityEngine.UI.Image;

public class Player : MonoBehaviour
{
    [HideInInspector] public PlayerSound playerSound;
    [HideInInspector] public UiManager uiManager;
    [HideInInspector] public PlayerHealth _playerHealth;
    [HideInInspector] public bool ring;
    private NavMeshAgent agent;
    public bool tutorial;

    #region Singleton

    public static Player instance;

    #endregion

    public enum AnimationTriggerType
    {
        Jump,
        DJump,
        Movement,
        Idle,
        Attack
    }

    #region StateMachine Variable

    public PlayerAttack _playerAttack;
    public PlayerStateMachine StateMachine { get; set; }
    public PlayerIdleState PlayerIdleState { get; set; }
    public PlayerMovementState PlayerMovementState { get; set; }

    public PlayerSkillState PlayerSkillState { get; set; }

    public PlayerBox PlayerBox { get; set; }

    #endregion

    #region Movement Variable

    public CurrentArrowType _baseCurrentArrowType;
    public CurrentGunType _baseCurrentGunType;
    public bool isMovement = true;
    public bool isWalk;
    public bool isSwim;
    [HideInInspector] public float animValue = 1;
    [HideInInspector] public float animSpeed;
    public float speed;
    public float rotSpeed = 5;
    [HideInInspector] public float baseSpeed;
    public Animator _playerAnimator;
    public DynamicJoystick _fixedJoystick;
    [HideInInspector] public CharacterController _myController;
    [HideInInspector] public GameObject skillSword;
    public Transform dragT;
    public float boxforce;
    private bool isWallPassed;

    private void DisableMovement()
    {
        //StateMachine.ChangeState(PlayerIdleState);
    }

    private void DisableMovement(GameState obj)
    {
        if (obj == GameState.Pause)
        {
            DisableMovement();
        }
        else if (obj == GameState.Play)
        {
            //StateMachine.ChangeState(PlayerMovementState);
        }
    }

    #endregion

    #region Initiliaze

    private void Awake()
    {
        baseSpeed = speed;
        if (instance == null)
        {
            instance = this;
        }

        playerSound = GetComponent<PlayerSound>();
        _playerAttack = GetComponent<PlayerAttack>();
        uiManager = FindObjectOfType<UiManager>();
        _playerAnimator = GetComponentInChildren<Animator>();
        _playerHealth = GetComponent<PlayerHealth>();
        //_fixedJoystick = FindObjectOfType<FixedJoystick>();
        _myController = GetComponent<CharacterController>();
        StateMachine = new PlayerStateMachine();
        PlayerBox = new PlayerBox(this, StateMachine, gameObject);
        PlayerIdleState = new PlayerIdleState(this, StateMachine);
        PlayerMovementState = new PlayerMovementState(this, StateMachine, false);
        _skillCoolDown = FindObjectOfType<SkillCoolDown>();
        dashSprite = Resources.Load<Sprite>("SkillSprite/Dash");
        attackSprite = uiManager.attackJoystick.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite;
        skillSword = GetComponentInChildren<SwordSkill>().gameObject;
        DashInıtiliaze();
    }

    private void DashInıtiliaze()
    {
        for (int i = 0; i < uiManager.ButtonType.Length; i++)
        {
            int j = i;
            uiManager.ButtonType[i].skillButton.onClick.AddListener((() =>
            {
                PlayerSkillState = new PlayerSkillState(this, StateMachine, uiManager.ButtonType[j].mySkillType);
                StateMachine.ChangeState(PlayerSkillState);
            }));
        }

        uiManager.JumpBtn.onClick.AddListener(() =>
            {
                PlayerMovementState.jumpPressed = true;
                StateMachine.ChangeState(PlayerMovementState);
            }
        );
    }

    private void Start()
    {
        StateMachine.Initialize(PlayerMovementState);
    }

    #endregion

    private SkillCoolDown _skillCoolDown;
    private Sprite dashSprite, attackSprite;

    private void AnimationTriggerEvent(AnimationTriggerType triggerType)
    {
        StateMachine.CurrentPlayerState.AnimationTriggerEvent(triggerType);
    }

    private void Update()
    {
        if (tutorial)
        {
            agent.SetDestination(GameManager.instance.foxManager.transform.position);
        }

        StateMachine.CurrentPlayerState.FrameUpdate();
        if (uiManager.attackJoystick.input.magnitude > 0.98f && _skillCoolDown.CanUse(0))
        {
            PlayerSkillState = new PlayerSkillState(this, StateMachine, SkillType.Dash);
            StateMachine.ChangeState(PlayerSkillState);
        }

        if (uiManager.attackJoystick.input.magnitude > 0.98f)
        {
            uiManager.attackJoystick.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = dashSprite;
        }
        else
        {
            uiManager.attackJoystick.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = attackSprite;
        }

        // if (Input.GetKeyDown(KeyCode.B))
        // {
        //     PlayerBox = new PlayerBox(this, StateMachine);
        //     StateMachine.ChangeState(PlayerBox);
        // }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            StateMachine.ChangeState(PlayerMovementState);
        }

        if (other.CompareTag("water"))
        {
            ParticleManager.instance.swimParticle.Stop();
            speed = 12;
            _playerAnimator.SetTrigger("base");
            isSwim = false;
            print("aaaaaaaasssssassas");
        }
    }

    private float boxTime;
    private Rigidbody currentboxrb;
    private static readonly int RunSpeed = Animator.StringToHash("RunSpeed");

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            Vector3 boxpos = other.transform.position;
            Vector3 playerPosition = _playerAttack.transform.position;

            Vector3 directionToPlayer = boxpos - playerPosition;

            float angle = Vector3.Angle(transform.GetChild(0).forward, directionToPlayer);


            if (angle < 90 && isWalk)
            {
                boxTime += Time.deltaTime;
                if (boxTime > 0.2f)
                {
                    boxTime = 0;
                    HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact);
                }

                currentboxrb = other.GetComponent<Rigidbody>();
                Vector3 dir = other.transform.position - transform.position;
                dir.y = 0;
                dir.Normalize();
                currentboxrb.AddForceAtPosition(dir * boxforce * Time.deltaTime, transform.position, ForceMode.Impulse);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            if (_myController.isGrounded)
            {
                PlayerBox = new PlayerBox(this, StateMachine, other.gameObject);
                StateMachine.ChangeState(PlayerBox);
            }
        }

        if (other.CompareTag("RockPuzzle"))
        {
            other.gameObject.GetComponentInParent<PuzzleController>().DoneEnemyMission();
            other.isTrigger = false;
        }

        if (other.CompareTag("WallPassed"))
        {
            if (GameManager.instance.tutorialCounter == 4 && !isWallPassed)
            {
                isWallPassed = true;
                // GameManager.instance.TutorialLoad();
                GameManager.instance.tutorialCollider1.gameObject.SetActive(false);
                GameManager.instance.tutorialCollider2.gameObject.SetActive(false);
            }
        }

        if (other.gameObject.CompareTag("VillageEntry"))
        {
            GameManager.instance.TutorialLoad();
            other.gameObject.GetComponent<Collider>().enabled = false;
        }

        if (other.gameObject.CompareTag("PuzzleArea"))
        {
            isMovement = false;
            transform.position = other.transform.parent.transform.position;
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Fail, "Puzzle",
                other.transform.parent.transform.name);
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Puzzle",
                other.transform.parent.transform.name);
            Invoke("IsMovementAgain", 1f);
        }

        if (other.gameObject.CompareTag("TutorialIncreaser"))
        {
            if (GameManager.instance.tutorialSection == 0 && GameManager.instance.tutorialCounter is 2)
            {
                GameManager.instance.TutorialLoad();
            }
            else if (GameManager.instance.tutorialCounter is 3 or 4)
            {
                if (!GameManager.instance.isBox)
                {
                    GameManager.instance.tutorialCounter = 2;
                    GameManager.instance.TutorialLoad();
                }
                else
                {
                    other.gameObject.GetComponent<Collider>().enabled = false;
                    GameManager.instance.TutorialLoad();
                }
            }
        }

        if (other.CompareTag("water"))
        {
            isSwim = true;
            ParticleManager.instance.swimParticle.Play();
            speed = 5;
            _playerAnimator.ResetTrigger("base");
            _playerAnimator.SetTrigger("swim");
        }

        if (other.gameObject.CompareTag("colosseumTutorial"))
        {
            if (!GameManager.instance.isColosseum)
            {
                GameManager.instance.CinematicCamEnable(GameManager.instance.colosseum.transform);
                GameManager.instance.isColosseum = true;
                TutorialLoader.instance.Load("Colosseum");
                PlayerPrefs.SetInt("Colosseum", 1);
            }
        }
    }

    public void IsMovementAgain()
    {
        isMovement = true;
    }

    public void BackDoMove(GameObject enemy)
    {
        Vector3 dir = transform.position - enemy.transform.position;
        dir = Vector3.ClampMagnitude(dir, 2);
        isMovement = false;
        _playerAttack.missAttackParticle.Play();
        transform.DOMove(transform.position + (dir * 2), 1f).OnComplete(() => isMovement = true);
    }

    public void DisableSkill(float skilltime)
    {
        Invoke("DisableSkillTime", skilltime);
    }

    public void DisableSkillTime()
    {
        UiManager.instance.EnableButton();
        _playerAttack.flameTFloor.Stop();
        _playerAnimator.SetFloat("AttackSpeed", 1);
        _playerHealth.useShield = false;
        _playerAttack.myCurrentGunType = _baseCurrentGunType;
        _playerAttack.myCurrentArrowType = _baseCurrentArrowType;
    }

    private void FixedUpdate()
    {
        StateMachine.CurrentPlayerState.PhysicUpdate();
    }


    private void OnEnable()
    {
        GameManager.onGameStateChanged += DisableMovement;
        _playerHealth.OnDie += DisableMovement;
    }

    private void OnDisable()
    {
        GameManager.onGameStateChanged -= DisableMovement;
        _playerHealth.OnDie -= DisableMovement;
    }

    public void FinishTutorial()
    {
        tutorial = true;
        isMovement = false;

        StateMachine.ChangeState(PlayerIdleState);
        transform.GetChild(0).transform.rotation = new Quaternion(0, 0, 0, 0);
        GameManager.instance.playerVCam.m_LookAt = null;
        transform.AddComponent<NavMeshAgent>();
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 6f;
        GetComponent<CharacterController>().enabled = false;
        _playerAnimator.SetFloat(RunSpeed, 1);
        UiManager.instance.CloseAllUI();
        Invoke("CloseCam", 7f);
    }

    public void TurnB()
    {
        Invoke("TurnBackFromTutorial", 2f);
    }

    public void TurnBackFromTutorial()
    {
        isMovement = true;
        StateMachine.ChangeState(PlayerMovementState);
        GameManager.instance.playerVCam.m_LookAt = transform;
        GameManager.instance.playerVCam.m_Follow = transform;
        GetComponent<CharacterController>().enabled = true;
        UiManager.instance.GamePlayUI();
        PlayerManager.instance.pet.GetComponent<FoxManager>().tutorial = false;
        _playerAnimator.speed = 1f;
    }

    public void CloseCam()
    {
        GameManager.instance.playerVCam.m_Follow = null;
        Invoke("EndOfTheCinema", 3f);
    }

    public void EndOfTheCinema()
    {
        GameManager.instance.EndOfTheCinematic();
    }

    IEnumerator FinishCinematic()
    {
        yield return new WaitForSeconds(5f);
        GameManager.instance.EndOfTheCinematic();
    }

    public void SavePosition(Transform pos)
    {
        PlayerPrefs.SetFloat("x", pos.position.x);
        PlayerPrefs.SetFloat("y", pos.position.y);
        PlayerPrefs.SetFloat("z", pos.position.z);
    }
}