using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using NaughtyAttributes;
using UnityEditor;
using UnityEngine;

public class PrefabReplacer : MonoBehaviour
{
    public GameObject prefab;
    // [Button]
    // public void Change()
    // {
    //     var childCount = transform.childCount;
    //     for (int i = 0; i < childCount; i++)
    //     {
    //         var data = transform.GetChild(i).Get();
    //         var spawnedPrefab = EditorUtility.InstantiatePrefab(prefab) as GameObject;
    //         spawnedPrefab.transform.SetParent(transform, true);
    //         spawnedPrefab.transform.Set(data);
    //         transform.GetChild(i).gameObject.SetActive(false);
    //     }
    // }
}
public static class Extensions
{
    public static TransformData Get(this Transform transform)
    {
        return new TransformData
        {
            initialPosition = transform.localPosition,
            initialRotation = transform.localRotation,
            initialScale = transform.localScale
        };
    }
    public static void Set(this Transform transform, TransformData data)
    {
        transform.localPosition = data.initialPosition;
        transform.localRotation = data.initialRotation;
        transform.localScale = data.initialScale;
    }
}
[System.Serializable]
public class TransformData
{
    public Vector3 initialPosition;
    public Quaternion initialRotation;
    public Vector3 initialScale;
}