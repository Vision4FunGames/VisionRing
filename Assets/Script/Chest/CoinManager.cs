
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
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
       // transform.GetChild(i).transform.DOMove(Player.instance.transform.position, .5f);
       transform.GetChild(i).GetComponent<TurnAround>().inArea = true;
        GameObject current = Instantiate(Resources.Load<GameObject>("coin"), canvasMain.transform);
        Vector3 goldpos = Camera.main.WorldToScreenPoint(this.transform.position);
        current.transform.position = goldpos+new Vector3(Random.Range(10f,100f),Random.Range(10f,100f),Random.Range(10f,100f));
        current.transform.DOLocalMove(canvasMain.transform.GetChild(0).GetChild(8).transform.localPosition, 1f).SetDelay(Random.Range(0f,1f)).OnComplete(() =>
        {
          Destroy(current);
        });
      }
      Destroy(gameObject,.3f);
     
    }
    
  }
}
