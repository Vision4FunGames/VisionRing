using System;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

public enum npcType
{
    BlackSmith,
    Merchant,
    Magician
}

public class BuildScale : MonoBehaviour
{
    public npcType MyNpcType;
    public GameObject npc;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DRM"))
        {
            ScaleUp();
        }
    }

    [Button("LevelMapTest")]
    public void ScaleUp()
    {
        transform.DOScale(new Vector3(1, 1, 1), .5f).SetEase(Ease.OutBack).OnComplete((() =>
        {
            string npcString = MyNpcType.ToString();
            if (PlayerPrefs.GetInt(npcString) == 1)
                npc.transform.DOScale(new Vector3(1, 1, 1), 1);
        }));
    }

    [Button("NpcOpen")]
    public void NpcOpen()
    {
        string npcString = MyNpcType.ToString();
        PlayerPrefs.SetInt(npcString, 1);
        npc.transform.DOScale(new Vector3(1, 1, 1), 1);
    }
}