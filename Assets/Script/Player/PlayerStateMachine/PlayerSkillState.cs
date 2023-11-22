using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public enum SkillType
{
    Dash,
    FireRotate,
    EarthQ,
    FlameT,
    Tornado,
    Sword,
    ArrowRain,
    Shield,
    Clone
}

public class PlayerSkillState : PlayerState
{
    private SkillType _skillType;
    private GameObject sword;

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
            case SkillType.Sword:
                if (SkillCoolDown.instance.CanUse(5))
                    SwordSkill();
                else
                {
                    _player.StateMachine.ChangeState(_player.PlayerMovementState);
                }

                break;
            case SkillType.ArrowRain:
                if (SkillCoolDown.instance.CanUse(6))
                    ArrowRain();
                else
                {
                    _player.StateMachine.ChangeState(_player.PlayerMovementState);
                }

                break;
            case SkillType.Shield:
                if (SkillCoolDown.instance.CanUse(7))
                    ShieldSkill();
                else
                {
                    _player.StateMachine.ChangeState(_player.PlayerMovementState);
                }

                break;
            case SkillType.Clone:
                if (SkillCoolDown.instance.CanUse(8))
                    CloneSkill();
                else
                {
                    _player.StateMachine.ChangeState(_player.PlayerMovementState);
                }

                break;
        }
    }

    public void CloneSkill()
    {
        SkillCoolDown.instance.skillsArray[8].coolDownTime = SkillCoolDown.instance.skillsArray[8].coolDown;
        UiManager.instance.DisableButton();
        List<GameObject> clones = new List<GameObject>();
        for (int i = 0; i < 3; i++)
        {
            clones.Add(Instantiate(Resources.Load("Skills/Clone") as GameObject));
            clones[i].transform.position = _player.transform.position;
            clones[i].SetActive(true);
            Destroy(clones[i].gameObject,20);
        }
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
       
        _player.DisableSkill(20);
    }
    public void ShieldSkill()
    {
        SkillCoolDown.instance.skillsArray[7].coolDownTime = SkillCoolDown.instance.skillsArray[7].coolDown;
        UiManager.instance.DisableButton();
        Vector3 shieldPos = new Vector3(_player.transform.position.x, _player.transform.position.y + 2f, _player.transform.position.z);
        GameObject shield =  GameObject.Instantiate(Resources.Load("Skills/Shield") as GameObject ,shieldPos,Quaternion.identity);
        _player._playerHealth.useShield = true;
        shield.GetComponent<ParticleSystem>().Play();
        shield.transform.SetParent(_player.transform);
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
        Destroy(shield,20);
        _player.DisableSkill(20);
    }
    public void ArrowRain()
    {
        SkillCoolDown.instance.skillsArray[6].coolDownTime = SkillCoolDown.instance.skillsArray[6].coolDown;
        UiManager.instance.DisableButton();
        Vector3 arrowPos = new Vector3(_player.transform.position.x, _player.transform.position.y + 40f, _player.transform.position.z);
        GameObject arrowSkil =  GameObject.Instantiate(Resources.Load("Skills/ArrowRain") as GameObject ,arrowPos,Quaternion.Euler(-90,0,0));
        arrowSkil.GetComponent<ParticleSystem>().Play();
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
        Destroy(arrowSkil,10);
        _player.DisableSkill(10);
    }
    public void SwordSkill()
    {
        SkillCoolDown.instance.skillsArray[5].coolDownTime = SkillCoolDown.instance.skillsArray[5].coolDown;
        UiManager.instance.DisableButton();
        sword = GameObject.Instantiate(Resources.Load("Skills/Skill Sword") as GameObject);
        if (sword != null)
        {
            sword.transform.SetParent(_player.skillSword.transform);
            sword.transform.localRotation = Quaternion.identity;
            sword.transform.localPosition = Vector3.zero;
            sword.transform.localScale = new Vector3(1, 1, 1);
        }
        _player._playerAnimator.SetFloat("AttackSpeed", 0.5f);
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
        Destroy(sword,10);
        _player.DisableSkill(10);
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
        Vector3 playerVelocity = new Vector3(_player.uiManager.attackJoystick.Horizontal, 0,
            _player.uiManager.attackJoystick.Vertical);
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
        UiManager.instance.DisableButton();
        SkillCoolDown.instance.skillsArray[1].coolDownTime = SkillCoolDown.instance.skillsArray[1].coolDown;
        GameObject currentRotat = GameObject.Instantiate(Resources.Load("Skills/FireEarth") as GameObject);
        if (currentRotat != null) currentRotat.transform.SetParent(_player.transform);
        currentRotat.transform.localPosition = new Vector3(0, 2, 0);
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
        GameObject.Destroy(currentRotat, SkillCoolDown.instance.skillsArray[1].coolDown / 2);
        _player.DisableSkill(SkillCoolDown.instance.skillsArray[1].coolDown / 2);

    }

    public void EarthQuick()
    {
        UiManager.instance.DisableButton();
        SkillCoolDown.instance.skillsArray[2].coolDownTime = SkillCoolDown.instance.skillsArray[2].coolDown;
        GameObject currentEarthShatter = GameObject.Instantiate(Resources.Load("Skills/EarthShatter") as GameObject);
        if (currentEarthShatter != null) currentEarthShatter.transform.SetParent(_player.transform);
        currentEarthShatter.transform.localPosition = new Vector3(0, 0, 0);
        currentEarthShatter.transform.localRotation = _player.transform.GetChild(0).localRotation;
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
        GameObject.Destroy(currentEarthShatter, 4);
        _player.DisableSkill(4);
    }

    public void FlameTower()
    {
        UiManager.instance.DisableButton();
        SkillCoolDown.instance.skillsArray[3].coolDownTime = SkillCoolDown.instance.skillsArray[3].coolDown;
        GameObject currentEarthShatter = GameObject.Instantiate(Resources.Load("Skills/FlameThrower") as GameObject);
        if (currentEarthShatter != null) currentEarthShatter.transform.SetParent(_player.transform.GetChild(0));
        _player._playerAnimator.SetBool("Flame", true);
        currentEarthShatter.transform.localPosition = new Vector3(0, 2, 2);
        currentEarthShatter.transform.localRotation = Quaternion.identity;
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
        _player.speed = 0;
        GameObject.Destroy(currentEarthShatter, 8);
        _player.DisableSkill(8);
    }

    public void Tornado()
    {
        UiManager.instance.DisableButton();
        SkillCoolDown.instance.skillsArray[4].coolDownTime = SkillCoolDown.instance.skillsArray[4].coolDown;
        GameObject currentTornado = GameObject.Instantiate(Resources.Load("Skills/BasicTornado") as GameObject);
        if (currentTornado != null) currentTornado.transform.SetParent(_player.transform);
        currentTornado.transform.localPosition = new Vector3(0, 0.1f, 0);
        _player.StateMachine.ChangeState(_player.PlayerMovementState);
        GameObject.Destroy(currentTornado, 4);
        _player.DisableSkill(4);
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