using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FragileObject : MonoBehaviour
{
    private Transform player;
    public float moveSpeed = 3f;
    public float spawnRadius = 2f;
    private bool isBroken = false;
    private void Start()
    {
        player = Player.instance.transform;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
          BrokeTheObject();
          other.gameObject.GetComponent<Collider>().enabled = false;
        }
    }

    public void BrokeTheObject()
    {
        if (!isBroken)
        {
            isBroken = true;
            GetComponent<MeshRenderer>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(true);
            KeyOut();
            Destroy(gameObject, 2f); 

        }
        
    }

    public void KeyOut()
    {
        Vector3 randomPos = Random.insideUnitSphere * spawnRadius;
        var key = Instantiate(Resources.Load("key")as GameObject, new Vector3(transform.position.x,transform.position.y+2f,transform.position.z) + randomPos, new Quaternion(90,180,0,0),transform);
        Debug.Log("Key Spawned");
    }
}
