using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BuildObjMove : MonoBehaviour
{
    public void MoveBuild(Transform target, float delay, bool last)
    {
        transform.DOJump(target.position+new Vector3(0,1,0), 5, 1, 0.4f).SetDelay(delay).OnComplete((() =>
                {
                    Destroy(gameObject);
                    if (last)
                    {
                        PlayerManager.instance.BuildFinishObj();
                    }
                }
            ));
    }
}