using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected Player _player;
    protected PlayerStateMachine _playerStateMachine;

    public PlayerState(Player player, PlayerStateMachine playerStateMachine)
    {
        this._player = player;
        this._playerStateMachine = playerStateMachine;
    }

    public virtual void EnterState()
    {
    }

    public virtual void ExitState()
    {
    }

    public virtual void FrameUpdate()
    {
    }

    public virtual void PhysicUpdate()
    {
    }

    public virtual void AnimationTriggerEvent(Player.AnimationTriggerType triggerType)
    {
    }
}