using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowTween : MonoBehaviour
{
    public Material[] materials;
    public float time = 2.0f;
    
    public float start;
    public float end;
    private float delta;
    private Material[] materialInstances; 
    void Start()
    {
        delta = start - end;
        materialInstances = new Material[materials.Length];
        for (int i = 0; i < materials.Length; i++)
        {
            materialInstances[i] = new Material(materials[i]);
        }
        GetComponent<Renderer>().materials = materialInstances;
    }
    public void Grow()
    {
        start = start + delta;
        foreach (var item in materialInstances)
        {
            DOVirtual.Float(start,  start + delta, time, (z) => { item.SetFloat("_Grow", z); })
                .OnComplete((() =>Debug.Log(start+delta)));
        }
    }
}