using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBox : PlayerState
{
    private static readonly int Box = Animator.StringToHash("box");
    private static readonly int RunSpeed = Animator.StringToHash("RunSpeed");
    public Vector3 _playerVelocity;
    public GameObject box;
    public Transform DragT;
    public PlayerBox(Player player, PlayerStateMachine playerStateMachine,GameObject box) : base(player, playerStateMachine)
    {
        this.box = box;
    }

    public override void EnterState()
    {
        base.EnterState();
        _player._playerAnimator.SetBool(Box,true);
    }

    public override void ExitState()
    {
        base.ExitState();
        _player._playerAnimator.SetBool(Box,false);
    }

    public override void FrameUpdate()
    {
        base.FrameUpdate();
        Movement();
    }

    public void Movement()
    {
        _player._playerAnimator.SetFloat("boxSpeed",(Mathf.Abs(_player._fixedJoystick.Horizontal) +
                                                     Mathf.Abs(_player._fixedJoystick.Vertical)) * _player.animValue);
        _player._myController.Move(PlayerDirection() * (Time.deltaTime * _player.speed/2));
        _player.transform.GetChild(0).LookAt(_player.transform.GetChild(0).position +
                                             new Vector3(_player._fixedJoystick.Horizontal, 0f,
                                                 _player._fixedJoystick.Vertical) *
                                             (_player.speed * Time.deltaTime));
        
    }
    Vector3 PlayerDirection()   
    {
        return new Vector3(_player._fixedJoystick.Horizontal, _playerVelocity.y,
            _player._fixedJoystick.Vertical);
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
