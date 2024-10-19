using AllIn1SpringsToolkit;
using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewChestManager : MonoBehaviour
{
    public GameObject earnKeyPanel;
    public GameObject doubleParticle;
    public GameObject openButton, claimButton, doubleButton, keys;
    public CamFovOrSizeSpringComponent camSpring;
    public RewardList rewardManager;
    public int selectChestIndx;
    public TextMeshProUGUI[] keyTxts;
    public GameObject[] chests;
    public int[] keysAmount;
    public Transform chestFirstPos, chestLastPos;
    public NewChest selectChest;

    public GameObject oldChest;
    public static NewChestManager instance;
    private void Awake()
    {
        instance = this;
    }

    void OnEnable()
    {
        // SceneManager.sceneLoaded olayýna event handler ekle
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        // Event handler'ý kaldýr
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // Sahne yüklendiðinde çaðrýlacak yöntem
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        keysAmount = new int[3];
        for (int i = 0; i < keysAmount.Length; i++)
        {
            keysAmount[i] = PlayerPrefs.GetInt("Key" + i, 2);
            keyTxts[i].text = keysAmount[i].ToString();
        }
        KeyControl();
    }
    public void KeyControl()
    {
        if (keysAmount[2] > 0) OpenSelectChest(2);
        else if (keysAmount[1] > 0) OpenSelectChest(1);
        else if (keysAmount[0] > 0) OpenSelectChest(0);
        else earnKeyPanel.SetActive(true);
    }


    public void OpenSelectChest(int select)
    {
        if (keysAmount[select] <= 0) return;
        if (select == selectChestIndx && selectChest != null) return;
        if (earnKeyPanel.activeSelf) earnKeyPanel.SetActive(false);
        selectChestIndx = select;
        if (oldChest != null)
        {
            oldChest.transform.DOKill();
            Destroy(oldChest.gameObject);
        }
        selectChest = Instantiate(chests[selectChestIndx], chestFirstPos.position, Quaternion.identity).GetComponent<NewChest>();
        oldChest = selectChest.gameObject;
        selectChest.Show(chestFirstPos, chestLastPos);
    }

    public void Open()
    {
        if (selectChest != null && selectChest.ready)
        {
            keysAmount[selectChestIndx]--;
            PlayerPrefs.SetInt("Key" + selectChestIndx, keysAmount[selectChestIndx]);
            keyTxts[selectChestIndx].text = keysAmount[selectChestIndx].ToString();
            selectChest.StartCoroutine(selectChest.Open());
            openButton.SetActive(false);
            keys.SetActive(false);
        }
    }
    public void Double()
    {
        doubleButton.SetActive(false);
        claimButton.SetActive(false);
        // AdsManager.instance.rewarded.ShowAd(() =>
        // {
        StartCoroutine(GetDouble());
        // }, null);
    }

    private IEnumerator GetDouble()
    {
        foreach (var item in selectChest.rewards)
        {
            item.Double();
            yield return new WaitForSeconds(0.15f);
        }
        claimButton.SetActive(true);
    }

    public void Claim()
    {
        claimButton.SetActive(false);
        doubleButton.SetActive(false);
        StartCoroutine(ClaimAll());
    }

    private IEnumerator ClaimAll()
    {
        foreach (var item in selectChest.rewards)
        {
            item.Claim();
            yield return new WaitForSeconds(0.1f);
        }
        selectChest.chestSpring.AddVelocityScale(Vector3.one * -50f);
        Destroy(selectChest.gameObject);
        selectChest = null;
        keys.SetActive(true);
        KeyControl();
    }


}