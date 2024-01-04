using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Serialization;

public enum ThrowType
{
    arrow,
    bomb,
    ghostball
}

public class PoolingObject : MonoBehaviour
{
    public ThrowType mythrThrowType;
    public GameObject circleParentObj;
    [SerializeField] public float destroyTime;

    public DamageManager ballOwner;
    private ObjectPool<PoolingObject> _pool;

    private Coroutine deactivateBulletAfterTimeCoroutine;

    private Rigidbody rb;

    // Start is called before the first frame update
    private Player player;
    float elapsedTime = 0f;

    void Start()
    {
        ThrowArrow();
    }

    private void OnEnable()
    {
        //GetComponent<Collider>().enabled = false;
        rb = GetComponent<Rigidbody>();
        player = Player.instance;
        deactivateBulletAfterTimeCoroutine = StartCoroutine(DeactivateBulletAfterTime());
    }

    public void ThrowArrow()
    {
        rb.isKinematic = true;
        if (GetComponent<BoxCollider>() != null)
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }

        if (GetComponent<SphereCollider>() != null)
        {
            GetComponent<SphereCollider>().isTrigger = true;
        }

        //transform.LookAt(player.transform.forward);
        //rb.AddForce(Vector3.forward,ForceMode.Force);
        if (mythrThrowType == ThrowType.ghostball)
        {
            Vector3 dir = transform.position - player.transform.position;
         
            dir = new Vector3(dir.x, 0, dir.z);
            dir = Vector3.ClampMagnitude(dir, 2);
            transform.DOMove(
                transform.position+
                dir*-20f, 
                2f).SetEase(Ease.Linear);
        }
        if (mythrThrowType == ThrowType.arrow)
        {
            transform.DOMove(
                new Vector3(player.transform.position.x, player.transform.position.y + 2f, player.transform.position.z),
                .2f).SetEase(Ease.Linear);
        }
        else if (mythrThrowType == ThrowType.bomb)
        {
            print("bomb");
            circleParentObj = Instantiate(Resources.Load<GameObject>("GolemCircle"));
            circleParentObj.SetActive(true);
            circleParentObj.transform.localScale = new Vector3(2, 1.5f, 2);
            Vector3 _targetPos = player.transform.position;
            circleParentObj.transform.position = new Vector3(_targetPos.x, _targetPos.y+0.5f, _targetPos.z);
            circleParentObj.transform.GetChild(1).transform.localScale = new Vector3(0, 0, 0);
            circleParentObj.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 1f)
                .OnComplete((() =>Destroy(circleParentObj.gameObject)));
            transform.DOJump(
                new Vector3(player.transform.position.x, player.transform.position.y + 2f, player.transform.position.z),
                6f, 1, 1).SetEase(Ease.Linear).OnComplete(() =>
            {
                GetComponent<Collider>().enabled = true;
                Invoke("closeTrigger",.1f);
                ParticleSystem bomb = Instantiate(ParticleManager.instance.bombparticle, transform.position,
                    Quaternion.identity, null);
                Destroy(bomb.gameObject, 2f);
            });
        }
    }
    public void closeTrigger()
    {
        GetComponent<Collider>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        // transform.DOMove(new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), .3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ballOwner?.PlayerDamage();
            //StopCoroutine(deactivateBulletAfterTimeCoroutine);
            //_pool.Release(this);
        }
    }

    public void SetPool(ObjectPool<PoolingObject> pool)
    {
        _pool = pool;
    }

    private IEnumerator DeactivateBulletAfterTime()
    {
        elapsedTime = 0f;
        while (elapsedTime < destroyTime)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        //after the timer is over
        _pool.Release(this);
    }
}