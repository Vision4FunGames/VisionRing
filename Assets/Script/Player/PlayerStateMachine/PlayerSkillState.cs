using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Script.Player.PlayerStateMachine;
using UnityEditor.VersionControl;
using UnityEngine;

public enum SkillType
{
    dash,
    rotateFire,
}

public class PlayerSkillState : PlayerState
{
    private SkillType _skillType;

    public PlayerSkillState(Player player, PlayerStateMachine playerStateMachine, SkillType mySkillType) : base(player,
        playerStateMachine)
    {
        _skillType = mySkillType;
    }

    public override void EnterState()
    {
        base.EnterState();
        switch (_skillType)
        {
            case SkillType.dash:
                DashSkill();
                break;
            case SkillType.rotateFire:
                FireRotate();
                break;
        }
    }

    public void DashSkill()
    {
        var position = _player.transform.position;
        Vector3 playerVelocity = new Vector3(_player._fixedJoystick.Horizontal, 0, _player._fixedJoystick.Vertical);
        Vector3 targetPos = new Vector3(position.x, position.y, position.z) +
                            playerVelocity * 10;
        targetPos = new Vector3(targetPos.x, position.y, targetPos.z);
        ParticleManager.instance.playerDashParticle.Play();
        _player.transform.DOMove(targetPos, .2f).SetEase(Ease.Linear).OnComplete((() =>
        {
            _player.StateMachine.ChangeState(_player.PlayerMovementState);
            ParticleManager.instance.playerDashParticle.Stop();
        }));
    }

    public void FireRotate()
    {
        GameObject currentRotat = GameObject.Instantiate(Resources.Load("FireEarth") as GameObject);
        if (currentRotat != null) currentRotat.transform.SetParent(_player.transform);
        currentRotat.transform.localPosition = new Vector3(0, 2, 0);
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
        GameObject.Destroy(currentRotat, 2);
    }


    public override void ExitState()
    {
        base.ExitState();
    }

    public override void FrameUpdate()
    {
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