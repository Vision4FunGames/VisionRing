using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class spiderWeb : MonoBehaviour
{
    private Spider parent;
    public void SetParent(Spider _parent)
    {
        parent = _parent;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Collider>().enabled = false;
            GetComponentInChildren<ParticleSystem>().Play();
            transform.DOKill();
            Invoke("AddPool",2f);
        }
    }

    public void AddPool()
    {
        parent.AddSpiderWeb(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
