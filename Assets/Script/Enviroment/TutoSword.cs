using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoSword : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       // transform.Rotate(0, (transform.rotation.y) + Time.deltaTime * 20f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.TutorialLoad();
            EquipmentManager.instance.currentWeapon.GetComponent<MeshRenderer>().enabled = true;
            Destroy(gameObject);
        }
    }
}
