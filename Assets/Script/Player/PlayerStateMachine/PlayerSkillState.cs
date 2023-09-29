using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SkillType
{
    dash
}
public class PlayerSkillState : PlayerState
{


    public PlayerSkillState(Player player, PlayerStateMachine playerStateMachine,SkillType mySkillType) : base(player, playerStateMachine)
    {
    }

    public override void EnterState()
    {
        base.EnterState();
        
    }

    public void DashSkill()
    {
        
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
