using System;
using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class DailyRewardManager : MonoBehaviour
{
    public Button CollectBtn;
    public AlignSpin _alignSpin;
    public GameObject currentReward;
    public GameObject decimalPos;
    public Image[] selector;
    private int currentIndex;
    public float delayTime = 0.1f;

    private float randomRotateTime;
    private float currentTime = 0;
    private bool spin;
    private bool _decimalBool;
    private int rewardCount;
    private RewardManager _rewardManager;
    private int decimalcount;

    private void Start()
    {
        _rewardManager = FindObjectOfType<RewardManager>();
        _alignSpin = GetComponentInChildren<AlignSpin>();

        float radius = 2f;
        for (int i = 0; i < selector.Length; i++)
        {
            float angle = i * Mathf.PI * 2f / selector.Length;
            Vector3 newPos = new Vector3(Mathf.Cos(angle) * radius, 0, Mathf.Sin(angle) * radius);
            selector[i].transform.position = newPos;
        }
    }

    public void Collect(bool decimalBool)
    {
        _decimalBool = decimalBool;
        MoveThroughArray();
    }


    // ReSharper disable Unity.PerformanceAnalysis
    void MoveThroughArray()
    {
        float delayT = 0;
        if (!_decimalBool)
        {
            StartCoroutine(selector[0].GetComponent<Selector>().Move(delayT, 0));
        }

        else
        {
            for (int i = 0; i < selector.Length; i++)
            {
                //delayT += 0.15f;
                selector[i].gameObject.SetActive(true);
                selector[i].GetComponent<Selector>()._decimalBool = true;
                StartCoroutine(selector[i].GetComponent<Selector>().Move(delayT, i));
            }
        }

        _decimalBool = false;
    }

    public void OpenReward(GameObject _selector)
    {
        currentReward = Instantiate(Resources.Load<GameObject>("Reward"), transform, false);
        currentReward.transform.GetChild(1).GetComponent<Image>().sprite =
            _selector.transform.parent.transform.GetChild(0).GetComponent<Image>().sprite;
        currentReward.transform.DOScale(new Vector3(1.3f, 1.3f, 1.3f), 0.2f).OnComplete((() =>
        {
            currentReward.transform.DOScale(new Vector3(1f, 1f, 1f), 0.2f);
        }));
        spin = false;
        FindObjectOfType<VaultUI>().vaultCount =
            int.Parse(_selector.transform.parent.transform.GetComponentInChildren<TextMeshProUGUI>().text);
        
        PlayerPrefs.SetInt("vaultgem",     int.Parse(_selector.transform.parent.transform.GetComponentInChildren<TextMeshProUGUI>().text));

        FindObjectOfType<VaultUI>().vaultGem.text = FindObjectOfType<VaultUI>().vaultCount.ToString();
        Invoke("ResetDaily", 3);
    }

    public void OpenRewardDecimalCheck()
    {
        decimalcount++;
        if (decimalcount == 10)
        {
            OpenRewardDecimal();
        }
    }

    public void OpenRewardDecimal()
    {
        if (rewardCount < 10)
        {
            currentReward = Instantiate(Resources.Load<GameObject>("Reward"), transform, false);
            currentReward.transform.DOLocalMove(decimalPos.transform.GetChild(rewardCount).transform.localPosition,
                0.2f);
            currentReward.transform.GetChild(1).GetComponent<Image>().sprite =
                _rewardManager.upgradeItems[Random.Range(0, 2)].icon;
            currentReward.transform.DOScale(new Vector3(0.65f, 0.65f, 0.65f), 0.1f).OnComplete((() =>
            {
                currentReward.transform.DOScale(new Vector3(0.4f, 0.4f, 0.4f), 0.1f).OnComplete(OpenRewardDecimal);
            }));
        }

        rewardCount++;
        spin = false;
        Invoke("ResetDaily", 3);
    }

    public void ResetDaily()
    {
        UiManager.instance.CloseAllUI();
        UiManager.instance.GamePlayUI();
    }
}