using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using DG.Tweening;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class TutorialHand : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform parentTransform;
    public bool dash;
    void Start()
    {
        parentTransform = transform.parent.transform;
        if (dash)
        {
            PlayDashAnimation();
        }
    }

    private void PlayDashAnimation()
    {
        transform.DOLocalMove(new Vector3(87f, -193f, 0), 1f).SetLoops(-1,LoopType.Yoyo);
        
    }


    // Update is called once per frame
    void Update()
    {
        // parentTransform = transform.parent.transform;
        // transform.rotation = Quaternion.Euler(parentTransform.rotation.x,parentTransform.rotation.y,parentTransform.rotation.z * -1);
        // transform.localPosition = new Vector3(0, -70, 0);
    }
}
