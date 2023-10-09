using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardRaycast : MonoBehaviour
{
    public LayerMask myLayer;
    //private PlayerMovement _playerMovement;
    public float distance;

    private void Start()
    {
        //_playerMovement = FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        CheckWater();
    }

    public void CheckWater()
    {
        //if (_playerMovement.box)
        //{
        //    RaycastHit objectHit;
        //    Vector3 fwd = transform.TransformDirection(Vector3.forward);
        //    Debug.DrawRay(transform.position, fwd * distance, Color.green);
        //    if (Physics.Raycast(transform.position, fwd, out objectHit, distance,myLayer))
        //    {
        //        if (objectHit.collider.CompareTag("water"))
        //        {
        //            _playerMovement.speed = 0;
        //        }
        //        else
        //        {
        //            _playerMovement.speed = _playerMovement.boxObject.GetComponent<BoxItem>().boxSpeed;
        //        }
        //    }
        //}
    }
}
