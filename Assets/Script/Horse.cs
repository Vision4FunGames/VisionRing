using System;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.AI;

public class Horse : MonoBehaviour
{
    public float speed;
    public bool callHorse, playerAttach,jumpPlayer;
    private Player _player;
    private NavMeshAgent _navMeshAgent;
    private RandomPointNavmesh randomPointNavmesh;
    private Vector3 vposCamera;
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        _player = FindObjectOfType<Player>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
        randomPointNavmesh = GetComponent<RandomPointNavmesh>();
        _navMeshAgent.enabled = true;
    }

    [Button("Call Horse")]
    public void CallHorse()
    {
        if (!playerAttach)
        {
            HorsePosition();
            _animator.SetFloat("HorseSpeed", 1);
            callHorse = true;
            jumpPlayer = false;
        }
        else
        {
            playerAttach = false;
            _player.horse = false;
            _player.speed = _player.baseSpeed;
            _player._playerAnimator.SetBool("horse",false);
            _player.StateMachine.ChangeState(_player.PlayerMovementState);
            _navMeshAgent.SetDestination(vposCamera);
            _animator.SetFloat("HorseSpeed", 1);
        }
    }

    public void HorsePosition()
    {
        Vector3 pos = randomPointNavmesh.RandomPoint();

        if (Vector3.Distance(_player.transform.position, pos) > 40 &&
            Mathf.Abs(_player.transform.position.y - pos.y) < 2)
        {
            _navMeshAgent.enabled = false;
            transform.position = pos;
            vposCamera = pos;
            _navMeshAgent.enabled = true;
        }
        else
        {
            HorsePosition();
        }
    }

    private void LateUpdate()
    {
        if (callHorse)
        {
            _navMeshAgent.SetDestination(_player.transform.position);
            if (Vector3.Distance(_player.transform.position, transform.position) < 30 && !jumpPlayer)
            {
                jumpPlayer = true;
                _player.StateMachine.ChangeState(_player.PlayerHorseState);
            }

            if (Vector3.Distance(_player.transform.position, transform.position) < 2)
            {
                _player.speed = _player.baseSpeed * 2;
                callHorse = false;
                playerAttach = true;
                _player.horse = true;
            }
        }
        if (playerAttach)
        {
            _animator.SetFloat("HorseSpeed",
                Mathf.Abs(_player._fixedJoystick.Vertical) + Mathf.Abs(_player._fixedJoystick.Horizontal));
            transform.position = _player.transform.position;
            transform.rotation = _player.transform.GetChild(0).rotation;
        }
    }
}