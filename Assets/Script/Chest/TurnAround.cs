using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TurnAround : MonoBehaviour
{
   public bool inArea;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate (Vector3.up * 50 * Time.deltaTime, Space.World);
        
        if(inArea)
        {
            transform.DOMove(Player.instance.transform.position,1f);
        }
        
    }
}
