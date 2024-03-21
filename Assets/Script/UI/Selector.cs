using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Selector : MonoBehaviour
{
    private int currentIndex;
    private float baseDelayTime;
    private float randomRotateTime;
    private bool spin;
    public bool _decimalBool;
    private int rewardCount;
    public float delayTime = 0.1f;
    public float maxDelayTime = .3f;
    private float currentTime;
    private DailyRewardManager _dailyRewardManager;

    private void Start()
    {
        _dailyRewardManager = FindObjectOfType<DailyRewardManager>();
    }

    public IEnumerator Move(float startDelay,int currentIn)
    {
        yield return new WaitForSeconds(startDelay);
      
        currentIndex = currentIn;
        gameObject.SetActive(true);
        randomRotateTime = Random.Range(1f, 3f);
        spin = true;
        delayTime = baseDelayTime;
        while (true)
        {
            yield return new WaitForSeconds(delayTime);
            currentIndex = (currentIndex + 1) %_dailyRewardManager._alignSpin.spinPool.Count;
            transform.SetParent(_dailyRewardManager._alignSpin.spinPool[currentIndex].transform);
            transform.GetComponent<RectTransform>().sizeDelta = transform.parent.GetComponent<RectTransform>().sizeDelta;
            transform.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            transform.localPosition = Vector3.zero;
            transform.localEulerAngles = Vector3.zero;
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
        _dailyRewardManager.OpenReward(gameObject);
        spin = false;
        gameObject.SetActive(false);
    }

    public void OpenRewardDecimal()
    {
        _dailyRewardManager.OpenRewardDecimalCheck();
        spin = false;
    }
    private void Update()
    {
        if (spin)
            currentTime += Time.deltaTime;
    }
}
