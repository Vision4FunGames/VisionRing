using System;
using DamageNumbersPro;
using DG.Tweening;
using MoreMountains.Tools;
using UnityEngine;

public class Golem2 : MonoBehaviour , GolemCombat
{
    private Collider collider;
    private float _currentTime, _rateOfFire = 5;
    private CameraShake _cameraShake;
    private Vector3 _targetPos;
    private Animator _animator;
    private Player _player;
    private float animSpeed;
    private int baseHealth;

    [HideInInspector] public bool attack;
    public GameObject circleParentObj;
    public MMProgressBar healthBar;
    public int health;
    public bool stun , checkPlayer;
    public GameObject _damageNumbersPro;
    public ParticleSystem golemParticle , stunStar;
    private SkinnedMeshRenderer[] _skinnedMeshRenderers;

    // Start is called before the first frame update
    void Start()
    {
        _skinnedMeshRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();
        baseHealth = health;
        collider = GetComponent<Collider>();
        collider.enabled = false;
        circleParentObj = Instantiate(Resources.Load<GameObject>("GolemCircle"),transform);
        _cameraShake = FindObjectOfType<CameraShake>();
        _animator = GetComponentInChildren<Animator>();
        _player = FindObjectOfType<Player>();
        _damageNumbersPro = Resources.Load("Spread Up") as GameObject;
    }

    private void OnEnable()
    {
        MMProgressBar prefab = Resources.Load<MMProgressBar>("Golem2 Bar");
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

    // Update is called once per frame
    void Update()
    {
        if (!attack && !stun)
            LookAtPlayer();

        if (_currentTime > _rateOfFire && !stun)
        {
            _currentTime = 0;
            Attack();
        }
    }

    public void LookAtPlayer()
    {
        _currentTime += Time.deltaTime;
        var lookPos = _player.transform.position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        _animator.SetFloat("Blend",-(transform.rotation.eulerAngles.magnitude-rotation.eulerAngles.magnitude));
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10);
    }
   
    public void CheckPlayerCollider()
    {
        if (checkPlayer)
        {
            collider.enabled = false;
            checkPlayer = false;
        }
        else
        {
            StunBoss();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkPlayer = true;    
            other.GetComponent<PlayerHealth>().TakeDamage(40);
        }

        if (other.CompareTag("SwordCollider"))
        {
            TakeDamage(_player.GetComponent<PlayerAttack>().damage);
        }
    }

    #region Attack
    public void Attack()
    {
        _animator.Play("Attack");
        attack = true;
        circleParentObj.SetActive(true);
        _targetPos = _player.transform.position;
        circleParentObj.transform.position = new Vector3(_targetPos.x, 0.5f, _targetPos.z);
        circleParentObj.transform.GetChild(1).transform.localScale = new Vector3(0, 0, 0);
        circleParentObj.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 1.5f)
            .OnComplete((() => circleParentObj.SetActive(false)));
    }
    public void FinishAttack()
    {
        CancelInvoke("CheckPlayerCollider");
        Invoke("CheckPlayerCollider",.5f);
        collider.enabled = true;
        StartCoroutine(_cameraShake.Shake(.5f, 1));
        golemParticle.Play();
        attack = false;
    }
    public void Jump()
    {
        circleParentObj.SetActive(false);
        _targetPos = new Vector3(_targetPos.x, 0, _targetPos.z);
        transform.DOJump(_targetPos, 8, 0, 1).SetEase(Ease.Linear).OnComplete((() =>
        {
            FinishAttack();
        }));
    }
    #endregion
    #region Stum

    public void StunBoss()
    {
        collider.enabled = false;
        checkPlayer = false;
        stun = true;
        stunStar.Play();
        _animator.Play("Stun");
        Invoke("DisableStun",5f);
    }

    public void DisableStun()
    {
        stunStar.Stop();
        stun = false;
        _animator.Play("idle");

    }

    #endregion
    #region GolemTakeDamage

    public void TakeDamage(int damage)
    {
        DamageMaterial();
        
        ShowText(damage);
        health -= damage;
        healthBar.UpdateBar(health,0,baseHealth);
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

    public void ShowText(int damage)
    {
        DamageNumber newDamageNumber =
            _damageNumbersPro.GetComponent<DamageNumber>().Spawn(
                new Vector3(transform.position.x, transform.position.y+6, transform.position.z),
                damage);
    }
    #endregion
   
}