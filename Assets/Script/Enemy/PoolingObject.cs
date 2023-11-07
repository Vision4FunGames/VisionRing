using System;
using System.Collections;
using System.Collections.Generic;
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
       
        rb = GetComponent<Rigidbody>();
        player = Player.instance;
      
       ThrowArrow();
    }

    private void OnEnable()
    {
        deactivateBulletAfterTimeCoroutine = StartCoroutine(DeactivateBulletAfterTime());
    }

    public void ThrowArrow()
    {
        transform.DOMove(
                new Vector3(player.transform.position.x, player.transform.position.y + 2f, player.transform.position.z), .5f)
            .OnComplete(() =>
            {
                if (ballOwner != null)
                {
                    ballOwner.PlayerDamage();
                }
                else
                {
                    Debug.Log("Null");
                }
            });
    }
    // Update is called once per frame
    void Update()
    {
       // transform.DOMove(new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), .3f);
        

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
