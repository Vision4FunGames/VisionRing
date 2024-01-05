using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

public class PuzzleController : MonoBehaviour
{
    public GameObject StoneArray,StoneArray1,StoneArray2;
    public GameObject[] cubes;
    public int mission;
    public int missionStoneCounter;
    public Transform[] children; // Çocuk nesnelerin referanslarını tutacak dizi
    public float duration = 1f; // İndirme süresi
    public float distance = 1f; // İndirme mesafesi
    public GameObject Enemies;
    public GameObject rockButton;
    public int enemyCount;
    public int killedEnemy;
    public IEnumerator StoneStart(GameObject stone)
    {
        children = new Transform[stone.transform.childCount]; // Çocuk nesnelerin referanslarını al
        for (int i = 0; i < stone.transform.childCount; i++)
        {
            children[i] = stone.transform.GetChild(i);
        }

        yield return StartCoroutine(MoveChildren());
    }

    IEnumerator MoveChildren()
    {
        float timeElapsed = 0f;

        for (int i = 0; i < children.Length; i++)
        {
            MoveChild(children[i]);
            yield return new WaitForSeconds(.5f); // 1 saniye bekle
        }
    }

    void MoveChild(Transform child)
    {
        Vector3 endPos = child.localPosition - Vector3.up * distance;

        child.DOLocalMove(endPos, duration).SetEase(Ease.Linear);
    }

    public void DoneStoneMission()
    {
        missionStoneCounter++; 
        if (missionStoneCounter ==mission)
        {
            StartCoroutine(StoneStart(StoneArray));
        }
    }
    public void DoneEnemyMission()
    {
        rockButton.transform.GetChild(1).transform.DOLocalMove(new Vector3(0, 0, 0), 1f).SetEase(Ease.Linear).OnComplete(() => StartCoroutine(StoneStart(StoneArray1)));
    }
    public void EnemyDead()
    {
        killedEnemy++;
        if (killedEnemy == enemyCount)
        {
            rockButton.transform.GetChild(0).gameObject.SetActive(false);
            rockButton.GetComponent<Collider>().isTrigger = true;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
