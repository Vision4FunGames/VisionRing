
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Quaternion = UnityEngine.Quaternion;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

public class CoinManager : MonoBehaviour
{
  private bool done = false;
  public float lookRadius;
  private float distance;
  public GameObject coin;
  Canvas canvasMain;
  public int numberOfObjects;
  public float spawnRadius;
  private VaultUI _vaultUI;
  private int minGold, maxGold;
  private int gold;
  public void SetGold(int min, int max)
  {
    minGold = min;
    maxGold = max;
  }
  private void Start()
  {
    _vaultUI = FindObjectOfType<VaultUI>();
    //numberOfObjects = Random.Range(2, 7);
    canvasMain = GameObject.FindGameObjectWithTag("mainCanvas").GetComponent<Canvas>();
    SpawnCoin();
  }
  private void Update()
  {
    if (transform.childCount==0)
    {
      Destroy(gameObject);
    }
  }
  private void CollectAnimation(GameObject coin)
  {
    if (!done)
    {
      done = true;
      GameObject current = Instantiate(Resources.Load<GameObject>("coin"), canvasMain.transform);
      Vector3 goldpos = Camera.main.WorldToScreenPoint(this.transform.position);
      current.transform.position = goldpos+new Vector3(Random.Range(10f,100f),Random.Range(10f,100f),Random.Range(10f,100f));
      current.transform.DOLocalMove(canvasMain.transform.GetChild(0).GetChild(8).transform.localPosition, .5f).SetDelay(Random.Range(0f,1f)).OnComplete(() =>
      {
        Destroy(current);
        Destroy(gameObject);
      });
    }
    
  }

  
  void SpawnCoin()
  {
    for (int i = 0; i < numberOfObjects; i++)
    {
      Vector3 randomPos = Random.insideUnitSphere * spawnRadius; // Rastgele bir nokta oluştur
      randomPos.y = 0; // Y ekseni sabit olduğunda objeler yeryüzüne yerleştirilir

      var spawnedCoin = Instantiate(coin, new Vector3(transform.position.x,transform.position.y+2f,transform.position.z) + randomPos, new Quaternion(90,180,0,0),transform);
      gold = Random.Range(minGold, maxGold);
      gold *= (int)_vaultUI.currentGoldBoost;
      spawnedCoin.GetComponent<TurnAround>().setGoldCount(gold);
      // Belirtilen objeyi rastgele noktada oluştur
    }
    transform.GetChild(0).GetComponent<TurnAround>().setGoldCount(gold);
  }
}
