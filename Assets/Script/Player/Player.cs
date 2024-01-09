using System;
using DG.Tweening;
using MoreMountains.Tools;
using Script.Player.PlayerStateMachine;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Player : MonoBehaviour
{
    [HideInInspector] public UiManager uiManager;
    [HideInInspector] public PlayerHealth _playerHealth;

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
    [HideInInspector] public float animValue = 1;
    [HideInInspector] public float animSpeed;
    public float speed;
    public float rotSpeed = 5;
    [HideInInspector] public float baseSpeed;
    [HideInInspector] public Animator _playerAnimator;
    public DynamicJoystick _fixedJoystick;
    [HideInInspector] public CharacterController _myController;
    [HideInInspector] public GameObject skillSword;
    public Transform dragT;
    
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

        _playerAttack = GetComponent<PlayerAttack>();
        uiManager = FindObjectOfType<UiManager>();
        _playerAnimator = GetComponentInChildren<Animator>();
        _playerHealth = GetComponent<PlayerHealth>();
        //_fixedJoystick = FindObjectOfType<FixedJoystick>();
        _myController = GetComponent<CharacterController>();
        StateMachine = new PlayerStateMachine();
        PlayerBox = new PlayerBox(this, StateMachine,gameObject);
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            if (_myController.isGrounded)
            {
                var boxObject = other.gameObject;
                float minDis = Vector3.Distance(transform.position,
                    boxObject.GetComponent<BoxItem>().playerDragPos[0].transform.position);
                int currentİndex = 0;
                for (int i = 0; i < boxObject.GetComponent<BoxItem>().playerDragPos.Length; i++)
                {
                    if (Vector3.Distance(transform.position,
                            boxObject.GetComponent<BoxItem>().playerDragPos[i].transform.position) < minDis)
                    {
                        minDis = Vector3.Distance(transform.position,
                            boxObject.GetComponent<BoxItem>().playerDragPos[i].transform.position);
                        currentİndex = i;
                    }
                }
                transform.DOMove(boxObject.GetComponent<BoxItem>().playerDragPos[currentİndex].transform.position, .1f)
                    .OnComplete((() =>
                    {
                        transform.GetChild(0).LookAt(new Vector3(boxObject.transform.position.x,transform.position.y,boxObject.transform.position.z));
                        PlayerBox = new PlayerBox(this, StateMachine,other.gameObject); 
                        StateMachine.ChangeState(PlayerBox);
                        boxObject.transform.parent = dragT;
                        boxObject.transform.localPosition = new Vector3(0, 0, 0);
                    }));
            }
          
        }

        if (other.CompareTag("RockPuzzle"))
        {
            other.gameObject.GetComponentInParent<PuzzleController>().DoneEnemyMission();
            other.isTrigger = false;
        }
    }

    public void BackDoMove(GameObject enemy)
    {
        Vector3 dir = transform.position - enemy.transform.position;
        dir = Vector3.ClampMagnitude(dir, 2);
        isMovement = false;
        _playerAttack.missAttackParticle.Play();
        transform.DOMove(transform.position + (dir*2), 1f).OnComplete(()=> isMovement = true);
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
}