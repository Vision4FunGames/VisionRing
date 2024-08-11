using System;
using DG.Tweening;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    private Player player;
    public void Start()
    {
    }

   

    public void SlorThrow()
   {
       gameObject.SetActive(true);
       transform.DOKill();
       transform.localScale = new Vector3(0.520004f, 0.73148f, 0.620004f);
       transform.DOScale(new Vector3(215.520004f,259.383148f,215.520004f), 10).OnComplete((() =>
       {
           transform.localScale = new Vector3(215.520004f, 259.383148f, 215.520004f);
           gameObject.SetActive(false);
       }));
   }
}
