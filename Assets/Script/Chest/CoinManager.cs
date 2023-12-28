
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

public class CoinManager : MonoBehaviour
{
  private bool done = false;
  public float lookRadius;
  private float distance;
  Canvas canvasMain;
  private void Start()
  {
    canvasMain = GameObject.FindGameObjectWithTag("mainCanvas").GetComponent<Canvas>();
      
  }
  private void Update()
  {
    distance = Vector3.Distance(Player.instance.transform.position, transform.position);
    if (distance <= lookRadius)
    {
      GoToPlayer();
    }
  }

  private void GoToPlayer()
  {
    if (!done)
    {
      done = true;
      for (int i = 0; i < transform.childCount; i++)
      { 
        CollectAnimation(transform.GetChild(i).gameObject);
      }
     // Destroy(gameObject,.3f);
     
    }
  }

  private void CollectAnimation(GameObject coin)
  {
    Tweener tweener = coin.transform.DOMove(new Vector3(Player.instance.transform.position.x,Player.instance.transform.position.y+2f,Player.instance.transform.position.z), 50f).SetSpeedBased(true);
    tweener.OnUpdate(delegate () {
      // if the tween isn't close enough to the target, set the end position to the target again
      if(Vector3.Distance(coin.transform.position, new Vector3(Player.instance.transform.position.x,Player.instance.transform.position.y+2f,Player.instance.transform.position.z)) > 1f) {
        tweener.ChangeEndValue(new Vector3(Player.instance.transform.position.x,Player.instance.transform.position.y+2f,Player.instance.transform.position.z), true);
      }
      else
      {
      Destroy(coin);
      }
      
    });

  // GameObject current = Instantiate(Resources.Load<GameObject>("coin"), canvasMain.transform);
    // Vector3 goldpos = Camera.main.WorldToScreenPoint(this.transform.position);
    // current.transform.position = goldpos+new Vector3(Random.Range(10f,100f),Random.Range(10f,100f),Random.Range(10f,100f));
    // current.transform.DOLocalMove(canvasMain.transform.GetChild(0).GetChild(8).transform.localPosition, 1f).SetDelay(Random.Range(0f,1f)).OnComplete(() =>
    // {
    //   Destroy(current);
    // });
  }
}
