using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;

public class PoolingObject : MonoBehaviour
{

   
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
        transform.DOMove(
            new Vector3(player.transform.position.x, player.transform.position.y + 2f, player.transform.position.z),
            .2f).SetEase(Ease.Linear);
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
            StopCoroutine(deactivateBulletAfterTimeCoroutine);
            _pool.Release(this);
            
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
