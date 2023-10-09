using System;
using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

/// <summary>
/// Place this script on an object that needs to override the fade options
/// Override the fade objects per object
/// </summary>
public class FadeObjectOptions : MonoBehaviour
{
    public bool OverrideFadeOutSeconds = false;
    public bool OverrideFadeInSeconds = false;
    public float FadeOutSeconds = 0;
    public float FadeInSeconds = 0;
    public bool OverrideFinalAlpha = false;
    public float FinalAlpha = 0;
    public bool isNotTransParent;
    public List<Material> orgMaterial;

    private void Start()
    {
        orgMaterial = new List<Material>();
        for (int i = 0; i < transform.GetComponent<Renderer>().materials.Length; i++)
        {
            orgMaterial.Add(GetComponentInChildren<Renderer>().materials[i]);
        }
   
    }
}