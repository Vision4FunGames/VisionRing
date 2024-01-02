using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcLookAt : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(Player.instance.transform.position.x,transform.position.y,Player.instance.transform.position.z));
    }
}
