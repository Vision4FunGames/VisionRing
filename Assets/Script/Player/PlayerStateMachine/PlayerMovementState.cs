using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementState : PlayerState
{
    private static readonly int RunSpeed = Animator.StringToHash("RunSpeed");
    private float gravityValue = -9.81f;
    private float jumpHeight = 2;
    private const string playerJumpAnimationString = "Jump";
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
        if (_player._myController.isGrounded)
        {
            _player._playerVelocity.y = -0.5f;
        }

        Movement();

        _player._playerVelocity.y += gravityValue * Time.deltaTime;
        _player._myController.Move(_player._playerVelocity * Time.deltaTime);
    }

    private void Jump()
    {
        if (_player._myController.isGrounded)
        {
            _player._playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            ChangeAnimationState(playerJumpAnimationString);
        }
    }

    public void Movement()
    {
        _player._myController.Move(PlayerDirection() * (Time.deltaTime * _player.speed));
        _player._playerAnimator.SetFloat(RunSpeed,
            Mathf.Abs(_player._fixedJoystick.Horizontal) + Mathf.Abs(_player._fixedJoystick.Vertical));
        _player.transform.GetChild(0).LookAt(_player.transform.GetChild(0).position +
                                             new Vector3(_player._fixedJoystick.Horizontal, 0f,
                                                 _player._fixedJoystick.Vertical) *
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

    public override void ChangeAnimationState(string newAnim)
    {
        base.ChangeAnimationState(newAnim);
        _player._playerAnimator.Play(newAnim);
    }

    Vector3 PlayerDirection()
    {
        return new Vector3(_player._fixedJoystick.Horizontal, _player._playerVelocity.y,
            _player._fixedJoystick.Vertical);
    }
}