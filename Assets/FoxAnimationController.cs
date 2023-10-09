using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxAnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject upperEyeLid;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EyeBlink()
    {
        //upperEyeLid.transform.DORotate(new Vector3(300.368988f, 92.3291397f, 261.021851f), .5f).SetEase(Ease.Linear)
        //    .OnComplete(() => upperEyeLid.transform.DORotate(new Vector3(282.519287f, 243.685699f, 111.34433f), .5f));
    }
}
