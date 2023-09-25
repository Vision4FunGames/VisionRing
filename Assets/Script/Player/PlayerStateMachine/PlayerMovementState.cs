using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementState : PlayerState
{
    private static readonly int RunSpeed = Animator.StringToHash("RunSpeed");

    public PlayerMovementState(Player player, PlayerStateMachine playerStateMachine) : base(player, playerStateMachine)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void FrameUpdate()
    {
        base.FrameUpdate();
        _player._myController.Move(PlayerDirection() * (Time.deltaTime * _player.speed));
        _player._playerAnimator.SetFloat(RunSpeed,Mathf.Abs(_player._fixedJoystick.Horizontal)+Mathf.Abs(_player._fixedJoystick.Vertical));
        _player.transform.GetChild(0).LookAt(_player.transform.GetChild(0).position +
                                             new Vector3(_player._fixedJoystick.Horizontal, 0f, _player._fixedJoystick.Vertical) *
                                             (_player.speed * Time.deltaTime));
    }

    public override void PhysicUpdate()
    {
        base.PhysicUpdate();
        
    }

    public override void AnimationTriggerEvent(Player.AnimationTriggerType triggerType)
    {
        base.AnimationTriggerEvent(triggerType);
    }

    Vector3 PlayerDirection()
    {
        return new Vector3(_player._fixedJoystick.Horizontal, _player._playerVelocity.y,
            _player._fixedJoystick.Vertical);
    }
}