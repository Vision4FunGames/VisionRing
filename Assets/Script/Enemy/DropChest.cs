using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public enum SkeletType
{
    Skelet,
    MiniSkelet,
    KingSkelet,
    Boss
}
public class DropChest : MonoBehaviour
{
    public SkeletType SkeletType;
    public GameObject chestPrefab;
    public GameObject boss;
    public int rnd;
    
    private void Awake()
    {
        boss = this.gameObject;
    }

    public void ChestDrop(Vector3 bossTransform)
    {
         rnd = Random.Range(1, 100);
         if (rnd <= 85)
        {
            if (SkeletType == SkeletType.Skelet)
            {
                var drop = Instantiate(chestPrefab, new Vector3(bossTransform.x, bossTransform.y - 5, bossTransform.z),Quaternion.identity);
                drop.transform.DOScale(new Vector3(1f, 1f, 1f),.1f).SetEase(Ease.OutBounce);
                drop.transform.DOMove(new Vector3(bossTransform.x, bossTransform.y, bossTransform.z), 2f);
            }
            if (SkeletType == SkeletType.Boss)
            {
                var drop = Instantiate(chestPrefab, new Vector3(bossTransform.x, bossTransform.y-5, bossTransform.z),Quaternion.identity);
                drop.transform.DOScale(new Vector3(3f, 3f, 3f), .1f).SetEase(Ease.OutBounce).SetDelay(4f);
                drop.transform.DOMove(new Vector3(bossTransform.x, bossTransform.y, bossTransform.z), 2f).SetDelay(4f);;
            }
            if (SkeletType== SkeletType.MiniSkelet)
            {
                var drop = Instantiate(chestPrefab, new Vector3(bossTransform.x, bossTransform.y-5, bossTransform.z),Quaternion.identity);
                drop.transform.DOScale(new Vector3(1f, 1f, 1f),.1f).SetEase(Ease.OutBounce);
                drop.transform.DOMove(new Vector3(bossTransform.x, bossTransform.y + 2.65f, bossTransform.z), 2f);
            }
            if (SkeletType== SkeletType.KingSkelet)
            {
                var drop = Instantiate(chestPrefab, new Vector3(bossTransform.x, bossTransform.y-5, bossTransform.z),Quaternion.identity);
                drop.transform.DOScale(new Vector3(1f, 1f, 1f),.1f).SetEase(Ease.OutBounce);
                drop.transform.DOMove(new Vector3(bossTransform.x, bossTransform.y + 2.70f, bossTransform.z), 2f);
            }
        }
    }
    
}
#if UNITY_EDITOR
[UnityEditor.CustomEditor(typeof(DropChest))]
public class Customditor : Editor
{


    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        DropChest drop = (DropChest)target;
        if (GUILayout.Button("Run"))
        {
            Vector3 bossLocal = new Vector3(drop.boss.transform.localPosition.x, drop.boss.transform.localPosition.y,
                drop.boss.transform.localPosition.z);
            drop.ChestDrop(bossLocal);
        }
    }
}
#endif
