using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAutoMove : PlayerState
{
    private NavMeshAgent navMeshAgent;

    public PlayerAutoMove(Player player, PlayerStateMachine playerStateMachine) : base(player, playerStateMachine)
    {
    }

    public override void EnterState()
    {
        navMeshAgent = _player.AddComponent<NavMeshAgent>();
        _player.transform.GetChild(0).eulerAngles = Vector3.zero;
        base.EnterState();
    }

    public override void ExitState()
    {
        _player.autoMove = false;
        Destroy(_player.GetComponent<NavMeshAgent>());
        UiManager.instance.autoMoveBtn.gameObject.SetActive(false);
        base.ExitState();
    }

    public override void FrameUpdate()
    {
        navMeshAgent.speed = 10;
        navMeshAgent.SetDestination(_player.autoMoveTarget.position);
        _player._playerAnimator.SetFloat("RunSpeed", navMeshAgent.velocity.magnitude);
        if (Vector3.Distance(_player.transform.position, _player.autoMoveTarget.position) < 4)
        {
            _player.StateMachine.ChangeState(_player.PlayerMovementState);
        }

        Vector3 directions = new Vector3(_player._fixedJoystick.Horizontal, 0,
            _player._fixedJoystick.Vertical);
        if (directions.magnitude > 0.5f)
        {
            _player.StateMachine.ChangeState(_player.PlayerMovementState);
        }

        base.FrameUpdate();
    }

    public override void PhysicUpdate()
    {
        base.PhysicUpdate();
    }

    public override void AnimationTriggerEvent(Player.AnimationTriggerType triggerType)
    {
        base.AnimationTriggerEvent(triggerType);
    }

    public override void ChangeAnimationState(string newAnim)
    {
        base.ChangeAnimationState(newAnim);
    }
}