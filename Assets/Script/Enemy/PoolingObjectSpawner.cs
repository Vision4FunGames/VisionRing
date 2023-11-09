using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Pool;


public class PoolingObjectSpawner : MonoBehaviour
{
    public ObjectPool<PoolingObject> _pool;
    private GhostAnimator ghostAnimator;
    private Player player;
    void Start()
    {
        player = Player.instance;
        ghostAnimator = GetComponent<GhostAnimator>();
        _pool = new ObjectPool<PoolingObject>(CreateGhostBall, OnTakeBallFromPool, OnReturnBallToPool, OnDestroyBall, true,
            10, 50);
    }

    private PoolingObject CreateGhostBall()
    {
        
        PoolingObject _poolingObject = Instantiate(ghostAnimator.ballPrefab, ghostAnimator.rightHand.transform.position,
         new Quaternion(0,0,0,0));
        
        _poolingObject.SetPool(_pool);
        _poolingObject.ballOwner = GetComponent<DamageManager>();
        
       // Destroy(poolingObject,poolingObject.destroyTime);
        //assign the ghostball`s pool

        Debug.Log("Spawn");
        return _poolingObject;
    }

    private void OnTakeBallFromPool(PoolingObject poolingObject)
    {
        //set the transform and rotation
        Debug.Log(poolingObject.transform.position + "1st position");
      //  Vector3 pos = new Vector3(ghostAnimator.rightHand.transform.position.x,ghostAnimator.rightHand.transform.position.y,go)
        poolingObject.transform.localRotation = ghostAnimator.rightHand.transform.rotation;
        poolingObject.transform.localPosition = ghostAnimator.rightHand.transform.position;
        Debug.Log(poolingObject.transform.position + "2nd position");
        //activate
        poolingObject.gameObject.SetActive(true);
        poolingObject.ThrowArrow();
    }

    private void OnReturnBallToPool(PoolingObject poolingObject)
    {
        poolingObject.gameObject.SetActive(false);
    }

    private void OnDestroyBall(PoolingObject poolingObject)
    {
        Destroy(poolingObject.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
