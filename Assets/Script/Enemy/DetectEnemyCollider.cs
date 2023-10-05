using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Random = UnityEngine.Random;

public class DetectEnemyCollider : MonoBehaviour
{
   private EnemyStats _enemyStats;

   private void Awake()
   {
      _enemyStats = GetComponent<EnemyStats>();
   }

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Tornado"))
      {
         TornadoStart(other.gameObject);
      }

      if (other.CompareTag("RotateFire"))
      {
         _enemyStats.TakeDamage(10);
      }
   }


   public void TornadoStart(GameObject _tornado)
   {
      GetComponent<EnemyController>().enabled = false;
      Vector3 target =  transform.position-_tornado.transform.position ;
      target = new Vector3(target.x, 10, target.z);
      transform.DOMove(target * 4,Random.Range(2,6));

      /*transform.SetParent(_tornado.transform.GetChild(0));}
      transform.DOMoveY(transform.position.y+10,Random.Range(4,10)).OnComplete((() =>
      {
         gameObject.SetActive(false);
      }));*/
   }
}
