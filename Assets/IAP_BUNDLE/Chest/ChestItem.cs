using AllIn1SpringsToolkit;
using DG.Tweening;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChestItem : MonoBehaviour
{
    public TransformSpringComponent spring, txtSpring;
    public TextMeshPro amountTxt;
    public RewardItemType rewardType;
    public int amount;
    public Transform target;
    public NewChest chest;

    public void SetAmount(NewChest chest, RewardItemType rewardType, int amount, Transform target)
    {
        this.chest = chest;
        this.target = target;
        this.rewardType = rewardType;
        this.amount = amount;
        amountTxt.text = StaticFuncs.FormatNumber(amount);
        transform.DOMove(target.position, 0.25f).SetEase(Ease.OutBounce);
        spring.AddVelocityScale(Vector3.up * 15f);
        txtSpring.AddVelocityScale(Vector3.up * 10f);
        txtSpring.AddVelocityPosition(Vector3.up * -5f);
    }
    [Button]
    public void Go()
    {
        transform.DOMove(target.position, 0.5f).SetEase(Ease.OutBounce);
    }
    public void Double()
    {
        amount *= 2;
        amountTxt.text = StaticFuncs.FormatNumber(amount);
        txtSpring.AddVelocityScale(Vector3.one * 100f);
        chest.PlayDoubleSound();
        Instantiate(NewChestManager.instance.doubleParticle, amountTxt.transform.position, Quaternion.identity);
    }

    public void Claim()
    {
        spring.AddVelocityScale(Vector3.one * -50f);
        chest.PlayClaimSound();
        Debug.Log("CLAIM " + amount + "  " + rewardType.ToString());
        Destroy(gameObject, 0.1f);
    }


}
