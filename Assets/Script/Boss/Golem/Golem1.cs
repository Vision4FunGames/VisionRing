using System;
using DG.Tweening;
using UnityEngine;

public class Golem1 : MonoBehaviour
{
    public float speed;
    private float rateOfFire = 2;
    private float currentTime;
    private CameraShake _cameraShake;
    public ParticleSystem golemParticle;
    public float golemMovementAttackRange;
    public float detectRadius;
    private Animator _animator;
    private Player _player;
    private float _distance;
    private bool _sleep = true;
    [HideInInspector] public bool _attack;
    private bool move;
    private float currentMovementTime;

    private void Awake()
    {
        _cameraShake = FindObjectOfType<CameraShake>();
        _animator = GetComponentInChildren<Animator>();
        _player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if (!_attack)
        {
            LookAtPlayer();
        }

        _distance = Vector3.Distance(_player.transform.position, transform.position);
        if (!_sleep && _distance < detectRadius)
        {
            _sleep = true;
        }

        if (_sleep && !_attack && currentTime > rateOfFire)
        {
            currentTime = 0;
            Attack();
        }

        if (move)
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

    public void Attack()
    {
        _attack = true;
        _animator.Play("AttackHazirlik");
    }

    public void StopAttack()
    {
        _animator.Play("AttackBitis");
        golemParticle.Stop();
        currentMovementTime = 0;
        _attack = false;
        move = false;
        currentTime = 0;
    }

    public void MovementAttack()
    {
        golemParticle.Play();
        StartCoroutine(_cameraShake.Shake(3, 1));
        move = true;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectRadius);
    }

    private void OnTriggerEnter(Collider other)
    {
        StopAttack();
    }
}