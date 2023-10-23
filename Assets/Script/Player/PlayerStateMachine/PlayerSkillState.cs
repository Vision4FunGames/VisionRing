using DG.Tweening;
using UnityEngine;

public enum SkillType
{
    Dash,
    FireRotate,
    EarthQ,
    FlameT,
    Tornado,
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
            case SkillType.Dash:
                if (SkillCoolDown.instance.CanUse(0))
                    DashSkill();
                else
                {
                    _player.StateMachine.ChangeState(_player.PlayerMovementState);
                }
                break;
            case SkillType.FireRotate:
                if (SkillCoolDown.instance.CanUse(1))
                    FireRotate();
                else
                {
                    _player.StateMachine.ChangeState(_player.PlayerMovementState);
                }
                break;
            case SkillType.EarthQ:
                if (SkillCoolDown.instance.CanUse(2))
                    EarthQuick();
                else
                {
                    _player.StateMachine.ChangeState(_player.PlayerMovementState);
                }
                break;
            case SkillType.FlameT:
                if (SkillCoolDown.instance.CanUse(3))
                    FlameTower();
                else
                {
                    _player.StateMachine.ChangeState(_player.PlayerMovementState);
                }
                break;
            case SkillType.Tornado:
                if (SkillCoolDown.instance.CanUse(4))
                    Tornado();
                else
                {
                    _player.StateMachine.ChangeState(_player.PlayerMovementState);
                }
                break;
        }
    }

    public void DashSkill()
    {
        _player.transform.GetChild(0).LookAt(_player.transform.GetChild(0).position +
                                             new Vector3(_player.uiManager.attackJoystick.Horizontal, 0f,
                                                 _player.uiManager.attackJoystick.Vertical) *
                                             (10 * Time.deltaTime));
        _player._playerAnimator.Play("Dash");
        SkillCoolDown.instance.skillsArray[0].coolDownTime = SkillCoolDown.instance.skillsArray[0].coolDown;
        var position = _player.transform.position;
        Vector3 playerVelocity = new Vector3(_player.uiManager.attackJoystick.Horizontal, 0, _player.uiManager.attackJoystick.Vertical);
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
        SkillCoolDown.instance.skillsArray[1].coolDownTime = SkillCoolDown.instance.skillsArray[1].coolDown;
        GameObject currentRotat = GameObject.Instantiate(Resources.Load("Skills/FireEarth") as GameObject);
        if (currentRotat != null) currentRotat.transform.SetParent(_player.transform);
        currentRotat.transform.localPosition = new Vector3(0, 2, 0);
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
        GameObject.Destroy(currentRotat, SkillCoolDown.instance.skillsArray[1].coolDown/2);
    }

    public void EarthQuick()
    {
        SkillCoolDown.instance.skillsArray[2].coolDownTime = SkillCoolDown.instance.skillsArray[2].coolDown;
        GameObject currentEarthShatter = GameObject.Instantiate(Resources.Load("Skills/EarthShatter") as GameObject);
        if (currentEarthShatter != null) currentEarthShatter.transform.SetParent(_player.transform);
        currentEarthShatter.transform.localPosition = new Vector3(0, 0, 0);
        currentEarthShatter.transform.localRotation = _player.transform.GetChild(0).localRotation;
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
        GameObject.Destroy(currentEarthShatter, 4);
    }

    public void FlameTower()
    {
        SkillCoolDown.instance.skillsArray[3].coolDownTime = SkillCoolDown.instance.skillsArray[3].coolDown;
        GameObject currentEarthShatter = GameObject.Instantiate(Resources.Load("Skills/FlameThrower") as GameObject);
        if (currentEarthShatter != null) currentEarthShatter.transform.SetParent(_player.transform.GetChild(0));
        _player._playerAnimator.SetBool("Flame",true);
        currentEarthShatter.transform.localPosition = new Vector3(0, 2, 2);
        currentEarthShatter.transform.localRotation = Quaternion.identity;
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
        _player.speed = 0;
        GameObject.Destroy(currentEarthShatter, 8);
    }

    public void Tornado()
    {
        SkillCoolDown.instance.skillsArray[4].coolDownTime = SkillCoolDown.instance.skillsArray[4].coolDown;
        GameObject currentTornado = GameObject.Instantiate(Resources.Load("Skills/BasicTornado") as GameObject);
        if (currentTornado != null) currentTornado.transform.SetParent(_player.transform);
        currentTornado.transform.localPosition = new Vector3(0, 0.1f, 0);
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
        GameObject.Destroy(currentTornado, 4);
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