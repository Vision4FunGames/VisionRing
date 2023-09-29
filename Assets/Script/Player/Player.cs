using Script.Player.PlayerStateMachine;
using UnityEngine;

public class Player : MonoBehaviour
{
    public UiManager uiManager;
    private PlayerHealth _playerHealth;

    public enum AnimationTriggerType
    {
        Jump,
        DJump,
        Movement,
        Idle,
        Attack
    }

    #region StateMachine Variable

    public PlayerStateMachine StateMachine { get; set; }
    public PlayerIdleState PlayerIdleState { get; set; }
    public PlayerMovementState PlayerMovementState { get; set; }

    public PlayerSkillState PlayerSkillState { get; set; }

    #endregion

    #region Movement Variable

    public float animValue = 1;
    public float animSpeed;
    public float speed;
    [HideInInspector] public Animator _playerAnimator;
    [HideInInspector] public FixedJoystick _fixedJoystick;
    [HideInInspector] public CharacterController _myController;

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
        uiManager = FindObjectOfType<UiManager>();
        _playerAnimator = GetComponentInChildren<Animator>();
        _playerHealth = GetComponent<PlayerHealth>();
        _fixedJoystick = FindObjectOfType<FixedJoystick>();
        _myController = GetComponent<CharacterController>();
        StateMachine = new PlayerStateMachine();
        PlayerIdleState = new PlayerIdleState(this, StateMachine);
        PlayerMovementState = new PlayerMovementState(this, StateMachine);
        uiManager.DashBtn.onClick.AddListener((() =>
        {
            PlayerSkillState = new PlayerSkillState(this, StateMachine, SkillType.dash);
            StateMachine.ChangeState(PlayerSkillState);
        }));
        
    }

    private void Start()
    {
        StateMachine.Initialize(PlayerMovementState);
    }

    #endregion


    private void AnimationTriggerEvent(AnimationTriggerType triggerType)
    {
        StateMachine.CurrentPlayerState.AnimationTriggerEvent(triggerType);
    }

    private void Update()
    {
        StateMachine.CurrentPlayerState.FrameUpdate();
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