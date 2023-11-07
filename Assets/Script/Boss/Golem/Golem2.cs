using System;
using DG.Tweening;
using UnityEngine;

public class Golem2 : MonoBehaviour
{
    private Collider collider;
    private float _currentTime, _rateOfFire = 5;
    private CameraShake _cameraShake;
    public ParticleSystem golemParticle , stunStar;
    private Animator _animator;
    private Player _player;
    [HideInInspector] public bool attack;
    public GameObject circleParentObj;
    private Vector3 _targetPos;
    private float animSpeed;
    
    public bool stun , checkPlayer;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
        collider.enabled = false;
        circleParentObj = Instantiate(Resources.Load<GameObject>("GolemCircle"),transform);
        _cameraShake = FindObjectOfType<CameraShake>();
        _animator = GetComponentInChildren<Animator>();
        _player = FindObjectOfType<Player>();
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
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10);
    }
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

    public void Jump()
    {
        circleParentObj.SetActive(false);
        transform.DOJump(_targetPos, 8, 0, 1).SetEase(Ease.Linear).OnComplete((() =>
        {
            FinishAttack();
        }));
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
        _animator.Play("Idle");

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
    }
}