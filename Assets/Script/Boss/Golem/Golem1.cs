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
    private SkinnedMeshRenderer[] _skinnedMeshRenderers;
    private bool dead;

    private void Awake()
    {
        _skinnedMeshRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
        baseHealth = health;
        _cameraShake = FindObjectOfType<CameraShake>();
        cameraShake = _cameraShake.Shake(3, 1);
        _animator = GetComponentInChildren<Animator>();
        _player = FindObjectOfType<Player>();
        _damageNumbersPro = Resources.Load("Spread Up") as GameObject;
    }

    private void OnEnable()
    {
        MMProgressBar prefab = Resources.Load<MMProgressBar>("Golem1 Bar");
        if (prefab != null)
        {
            healthBar = Instantiate(prefab, FindObjectOfType<ShopUI>().transform, false);
            healthBar.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError("BirlesikGolem prefab'ı bulunamadı veya yüklenemedi!");
        }
    }

    private void Update()
    {
        if (!_attack && !stun && !dead)
        {
            LookAtPlayer();
        }

        _distance = Vector3.Distance(_player.transform.position, transform.position);
        if (!_sleep && _distance < detectRadius)
        {
            _sleep = true;
        }

        if (_sleep && !_attack && currentTime > rateOfFire && !stun && !dead)
        {
            currentTime = 0;
            Attack();
        }

        if (move && !stun && !dead)
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
        _animator.SetFloat("Blend", -(transform.rotation.eulerAngles.magnitude - rotation.eulerAngles.magnitude));
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
            other.GetComponent<PlayerHealth>().TakeDamage(40);
            other.GetComponent<PlayerManager>().Stun(gameObject);
        }

        if (other.CompareTag("BossTrap"))
        {
            StopAttack();
        }

        if (other.CompareTag("SwordCollider"))
        {
            if (!dead)
                TakeDamage(_player.GetComponent<PlayerAttack>().damage);
        }

        if (other.CompareTag("Tornado"))
        {
            FindObjectOfType<TornadoExit>().EnemyAdd(gameObject);
        }

        if (other.CompareTag("RotateFire"))
        {
            TakeDamage(_player.GetComponent<PlayerAttack>().damage);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tornado"))
        {
            FindObjectOfType<TornadoExit>().EnemyRemove(gameObject);
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

    public void DamageMaterial()
    {
        for (int i = 0; i < _skinnedMeshRenderers.Length; i++)
        {
            int index = i;
            _skinnedMeshRenderers[i].material.DOColor(Color.red, .1f).SetEase(Ease.Linear)
                .OnComplete((() =>
                    _skinnedMeshRenderers[index].material.DOColor(Color.white, .1f).SetEase(Ease.Linear)));
        }
    }

    public void TakeDamage(int damage)
    {
        if (health > 0)
        {
            DamageMaterial();
            ShowText(damage);
            health -= damage;
            healthBar.UpdateBar(health, 0, baseHealth);
        }
        else if (health <= 0 && !dead)
        {
            GetComponent<Collider>().enabled = false;
            _animator.Play("Death");
            dead = true;
            Destroy(gameObject, 10);
        }
    }

    #endregion
}