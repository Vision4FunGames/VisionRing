using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class DailyRewardManager : MonoBehaviour
{
    public GameObject currentReward;
    public GameObject decimalPos;
    public Image selector;
    public Image[] imageArray;
    private int currentIndex;
    public float delayTime = 0.1f;
    public float maxDelayTime = .3f;

    private float baseDelayTime;
    private float randomRotateTime;
    private float currentTime = 0;
    private bool spin;
    private bool _decimalBool;
    private int rewardCount;

    private void Start()
    {
        baseDelayTime = delayTime;
    }

    public void Collect(bool decimalBool)
    {
        _decimalBool = decimalBool;
        StartCoroutine(MoveThroughArray());
    }

    private void Update()
    {
        if (spin)
            currentTime += Time.deltaTime;
    }

    // ReSharper disable Unity.PerformanceAnalysis
    IEnumerator MoveThroughArray()
    {
        randomRotateTime = Random.Range(1f, 3f);
        spin = true;
        delayTime = baseDelayTime;
        while (true)
        {
            yield return new WaitForSeconds(delayTime);
            currentIndex = (currentIndex + 1) % imageArray.Length;
            selector.transform.SetParent(imageArray[currentIndex].transform);
            selector.transform.localPosition = Vector3.zero;
            if (currentTime > randomRotateTime)
            {
                delayTime = Mathf.Lerp(delayTime, maxDelayTime, 0.2f);
            }
            else
                delayTime = Mathf.Lerp(delayTime, maxDelayTime, 0.01f);


            if (delayTime > maxDelayTime - 0.1f)
            {
                if (!_decimalBool)
                    Invoke("OpenReward", 1f);
                else
                {
                    Invoke("OpenRewardDecimal", 1f);
                }

                break;
            }
        }
    }

    public void OpenReward()
    {
        currentReward = Instantiate(Resources.Load<GameObject>("Reward"), transform, false);
        currentReward.transform.DOScale(new Vector3(1.3f, 1.3f, 1.3f), 0.2f).OnComplete((() =>
        {
            currentReward.transform.DOScale(new Vector3(1f, 1f, 1f), 0.2f);
        }));
        spin = false;
    }

    public void OpenRewardDecimal()
    {
        if (rewardCount < 10)
        {
            currentReward = Instantiate(Resources.Load<GameObject>("Reward"), transform, false);
            currentReward.transform.DOLocalMove(decimalPos.transform.GetChild(rewardCount).transform.localPosition, 0.2f);
            currentReward.transform.DOScale(new Vector3(0.65f, 0.65f, 0.65f), 0.2f).OnComplete((() =>
            {
                currentReward.transform.DOScale(new Vector3(0.4f, 0.4f, 0.4f), 0.2f).OnComplete(OpenRewardDecimal);
            }));
        }
        rewardCount++;
        spin = false;
    }
}