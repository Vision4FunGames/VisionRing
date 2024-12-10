using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardDisplay : MonoBehaviour
{
    public RewardList rewardList;
    public GameObject rewardPanel;
    public static RewardDisplay Instance;
    public List<RewardDetail> rewards;
    public GameObject rewardPrefab;
    public Transform rewardRoot;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void EarnReward(List<RewardDetail> rewardList)
    {
        rewards.Clear();
        DestroyOldReward();
        rewardPanel.SetActive(true);

        StartCoroutine(MultiReward());

        IEnumerator MultiReward()
        {
            foreach (RewardDetail item in rewardList)
            {
                rewards.Add(item);
                GameObject rewardItem = Instantiate(rewardPrefab, rewardRoot);
                rewardItem.GetComponent<RewardDisplayItem>().SetReward(item);
                yield return new WaitForSeconds(0.25f);
            }
        }
    }

    public void EarnReward(RewardItemType rewardType,int customAmount)
    {
        rewards.Clear();
        DestroyOldReward();
        rewardPanel.SetActive(true);
        rewards.Add(rewardList.GetRewardDetail(rewardType));
        GameObject rewardItem = Instantiate(rewardPrefab, rewardRoot);
        RewardDetail newReward = rewardList.GetRewardDetail(rewardType);
        newReward.amount = customAmount;
        rewardItem.GetComponent<RewardDisplayItem>().SetReward(newReward);
    }



    public void EarnReward(RewardItemType rewardType)
    {
        rewards.Clear();
        DestroyOldReward();
        rewardPanel.SetActive(true);
        rewards.Add(rewardList.GetRewardDetail(rewardType));
        GameObject rewardItem = Instantiate(rewardPrefab, rewardRoot);
        rewardItem.GetComponent<RewardDisplayItem>().SetReward(rewardList.GetRewardDetail(rewardType));
    }
    public void EarnReward(ChestRewardPack rewardPack)
    {
        rewards.Clear();
        DestroyOldReward();
        rewardPanel.SetActive(true);

        StartCoroutine(MultiReward());

        IEnumerator MultiReward()
        {
            foreach (RewardDetail item in rewardPack.rewards)
            {
                rewards.Add(item);
                GameObject rewardItem = Instantiate(rewardPrefab, rewardRoot);
                rewardItem.GetComponent<RewardDisplayItem>().SetReward(item);
                yield return new WaitForSeconds(0.25f);
            }
        }
    }
    public void EarnReward(ChestRewardPackType chestType)
    {
        rewards.Clear();
        DestroyOldReward();
        rewardPanel.SetActive(true);

        StartCoroutine(MultiReward());

        IEnumerator MultiReward()
        {
            ChestRewardPack newChest = rewardList.GetRewardDetail(chestType);
            foreach (RewardDetail item in newChest.rewards)
            {
                rewards.Add(item);
                GameObject rewardItem = Instantiate(rewardPrefab, rewardRoot);
                rewardItem.GetComponent<RewardDisplayItem>().SetReward(item);
                yield return new WaitForSeconds(0.25f);
            }
        }
    }
   




    public void DestroyOldReward()
    {
        for (int i = rewardRoot.transform.childCount - 1; i >= 0; i--)
        {
            Destroy(rewardRoot.transform.GetChild(i).gameObject);
        }
    }

    public void Claim()
    {
        foreach (var item in rewards)
        {
            Debug.Log("Earn  " + item.rewardName + "   " + item.amount);
        }
        rewardPanel.SetActive(false);
    }

}
