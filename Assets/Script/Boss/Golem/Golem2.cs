using DG.Tweening;
using UnityEngine;

public class Golem2 : MonoBehaviour
{
    private float _currentTime, _rateOfFire = 5;
    private CameraShake _cameraShake;
    public ParticleSystem golemParticle;
    private Animator _animator;
    private Player _player;
    [HideInInspector] public bool attack;
    public GameObject circleParentObj;
    private Vector3 _targetPos;
    private float animSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        circleParentObj = Instantiate(Resources.Load<GameObject>("GolemCircle"),transform);
        _cameraShake = FindObjectOfType<CameraShake>();
        _animator = GetComponentInChildren<Animator>();
        _player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!attack)
            LookAtPlayer();

        if (_currentTime > _rateOfFire)
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
        StartCoroutine(_cameraShake.Shake(.5f, 1));
        golemParticle.Play();
        attack = false;
    }
}