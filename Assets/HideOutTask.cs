using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class HideOutTask : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject hideout = FindObjectOfType<HideOutManager>().gameObject;
        hideout.transform.DOScale(Vector3.one,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
