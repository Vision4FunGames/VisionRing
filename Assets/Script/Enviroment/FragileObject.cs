using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragileObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SwordCollider"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 2f);
        }
        
    }
}
