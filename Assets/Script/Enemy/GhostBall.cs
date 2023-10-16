using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Pool;

public class GhostBall : MonoBehaviour
{

    [SerializeField] private LayerMask whatDestroysBall;
    [SerializeField] private float destroyTime;

    public DamageManager ballOwner;
    private ObjectPool<GhostBall> _pool;

    private Rigidbody rb;
    
    // Start is called before the first frame update
    private Player player;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = Player.instance;
       
        
    }

    private void OnEnable()
    {
       // rb.AddForce(new Vector3(player.transform.position.x,player.transform.position.y +2f,player.transform.position.z),ForceMode.Force);  
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
            ballOwner.PlayerDamage();
            _pool.Release(this);
        }
    }

    public void SetPool(ObjectPool<GhostBall> pool)
    {
        _pool = pool;
    }
}
