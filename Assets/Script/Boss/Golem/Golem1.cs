using System;
using System.Collections;
using DamageNumbersPro;
using DG.Tweening;
using MoreMountains.Tools;
using UnityEngine;

public class Golem1 : MonoBehaviour, GolemCombat
{
    public float speed;
    private float rateOfFire = 2;
    private float currentTime;
    private CameraShake _cameraShake;
    public ParticleSystem golemParticle, stunParticle;
    public float detectRadius;
    private Animator _animator;
    private Player _player;
    private float _distance;
    private bool _sleep = true;
    [HideInInspector] public bool _attack;
    private IEnumerator cameraShake;
    private bool move;
    private float currentMovementTime;
    public bool checkPlayer, stun;
    public MMProgressBar healthBar;
    public int health;
    private int baseHealth;
    public GameObject _damageNumbersPro;

    private void Awake()
    {
        baseHealth = health;
        _cameraShake = FindObjectOfType<CameraShake>();
        cameraShake = _cameraShake.Shake(3, 1);
        _animator = GetComponentInChildren<Animator>();
        _player = FindObjectOfType<Player>();
        _damageNumbersPro = Resources.Load("Spread Up") as GameObject;
    }

    private void Update()
    {
        if (!_attack && !stun)
        {
            LookAtPlayer();
        }

        _distance = Vector3.Distance(_player.transform.position, transform.position);
        if (!_sleep && _distance < detectRadius)
        {
            _sleep = true;
        }

        if (_sleep && !_attack && currentTime > rateOfFire && !stun)
        {
            currentTime = 0;
            Attack();
        }

        if (move && !stun)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            currentMovementTime += Time.deltaTime;
            if (currentMovementTime > rateOfFire)
            {
                StopAttack();
            }
        }
    }

    public void LookAtPlayer()
    {
        currentTime += Time.deltaTime;
        var lookPos = _player.transform.position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10);
    }


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectRadius);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkPlayer = true;
        }

        if (other.CompareTag("BossTrap"))
        {
            StopAttack();
        }

        if (other.CompareTag("SwordCollider"))
        {
            TakeDamage(_player.GetComponent<PlayerAttack>().damage);
        }
    }

    #region Stun

    public void DisableStun()
    {
        stunParticle.Stop();
        _animator.Play("idle");
        stun = false;
        checkPlayer = false;
    }

    #endregion

    #region Attack

    public void StopAttack()
    {
        _animator.Play("AttackBitis");
        StopCoroutine(cameraShake);
        golemParticle.Stop();
        currentMovementTime = 0;
        _attack = false;
        move = false;
        currentTime = 0;
        if (!checkPlayer)
        {
            stunParticle.Play();
            _animator.Play("Stun");
            stun = true;
            checkPlayer = false;
            Invoke("DisableStun", 5);
        }
        else
        {
            checkPlayer = false;
        }
    }

    public void Attack()
    {
        _attack = true;
        _animator.Play("AttackHazirlik");
    }

    public void MovementAttack()
    {
        golemParticle.Play();
        cameraShake = _cameraShake.Shake(3, 1);
        StartCoroutine(cameraShake);
        move = true;
    }

    #endregion

    #region GolemTakeDamage

    public void ShowText(int damage)
    {
        DamageNumber newDamageNumber =
            _damageNumbersPro.GetComponent<DamageNumber>().Spawn(
                new Vector3(transform.position.x, transform.position.y + 6, transform.position.z),
                damage);
    }


    public void TakeDamage(int damage)
    {
        ShowText(damage);
        health -= damage;
        healthBar.UpdateBar(health, 0, baseHealth);
    }

    #endregion
}