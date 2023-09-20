using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour , IMovement
{
    public float speed;

    private PlayerHealth _playerHealth;
    private Vector3 _playerVelocity;
    private FixedJoystick _fixedJoystick;
    private CharacterController _myController;
    

    private bool İsWalk { get;  set; }
    
    private void Awake()
    {
        Initialize();
        İsWalk = true;
    }

    public void Initialize()
    {
        _playerHealth = GetComponent<PlayerHealth>();
        _fixedJoystick = FindObjectOfType<FixedJoystick>();
        _myController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        if (İsWalk)
            _myController.Move(PlayerDirection() * (Time.deltaTime * speed));
    }

    Vector3 PlayerDirection()
    {
        return new Vector3(_fixedJoystick.Horizontal, _playerVelocity.y, _fixedJoystick.Vertical);
    }

    public void DisableMovement()
    {
        İsWalk = false;
    }   
    public void EnableMovement()
    {
        İsWalk = true;
    }
    private void DisableMovement(GameState obj)
    {
        if (obj == GameState.Pause)
        {
            DisableMovement();
        }else if (obj == GameState.Play)
        {
            EnableMovement();
        }
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