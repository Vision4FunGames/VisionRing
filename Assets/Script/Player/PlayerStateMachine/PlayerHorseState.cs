using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHorseState : PlayerState
{
    private float gravityValue = -9.81f;
    public Vector3 _playerVelocity;
    public PlayerHorseState(Player player, PlayerStateMachine playerStateMachine) : base(player, playerStateMachine)
    {
    }

    public override void EnterState()
    {
        _player._playerAnimator.SetBool("horse",true);
        base.EnterState();
    }

    public void Movement()
    {
        _player.animSpeed = (Mathf.Abs(_player._fixedJoystick.Horizontal) +
                             Mathf.Abs(_player._fixedJoystick.Vertical)) * _player.animValue;
        _player._myController.Move(PlayerDirection() * (Time.deltaTime * _player.speed));
        _player._playerAnimator.SetFloat("RunSpeed", _player.animSpeed);
        _player.transform.GetChild(0).LookAt(_player.transform.GetChild(0).position +
                                             new Vector3(_player._fixedJoystick.Horizontal, 0f,
                                                 _player._fixedJoystick.Vertical) *
                                             (_player.rotSpeed * Time.deltaTime));
    }
    Vector3 PlayerDirection()
    {
        return new Vector3(_player._fixedJoystick.Horizontal, _playerVelocity.y,
            _player._fixedJoystick.Vertical);
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void FrameUpdate()
    {
        Movement();
        _playerVelocity.y += gravityValue * Time.deltaTime;
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
