using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Pool;


public class GhostBallSpawner : MonoBehaviour
{
    public ObjectPool<GhostBall> _pool;
    private GhostAnimator ghostAnimator;
    private Player player;
    void Start()
    {
        player = Player.instance;
        ghostAnimator = GetComponent<GhostAnimator>();
        _pool = new ObjectPool<GhostBall>(CreateGhostBall, OnTakeBallFromPool, OnReturnBallToPool, OnDestroyBall, true,
            10, 20);
    }

    private GhostBall CreateGhostBall()
    {
        GhostBall ghostBall = Instantiate(ghostAnimator.ballPrefab, ghostAnimator.rightHand.transform.position,
            ghostAnimator.rightHand.transform.rotation);
        ghostBall.ballOwner = GetComponent<DamageManager>();
        ghostBall.transform.DOMove(new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), .2f);
        //assign the ghostball`s pool

        ghostBall.SetPool(_pool);
        return ghostBall;
    }

    private void OnTakeBallFromPool(GhostBall ghostBall)
    {
        //set the transform and rotation
        ghostBall.transform.rotation = ghostAnimator.rightHand.transform.rotation;
        ghostBall.transform.right = ghostAnimator.rightHand.transform.right;
        
        //activate
        ghostBall.gameObject.SetActive(true);
    }

    private void OnReturnBallToPool(GhostBall ghostBall)
    {
        ghostBall.gameObject.SetActive(false);
    }

    private void OnDestroyBall(GhostBall ghostBall)
    {
        Destroy(ghostBall.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
