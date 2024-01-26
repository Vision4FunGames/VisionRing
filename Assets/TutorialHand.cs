using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class TutorialHand : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform parentTransform;
    void Start()
    {
        parentTransform = transform.parent.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // parentTransform = transform.parent.transform;
        // transform.rotation = Quaternion.Euler(parentTransform.rotation.x,parentTransform.rotation.y,parentTransform.rotation.z * -1);
        // transform.localPosition = new Vector3(0, -70, 0);
    }
}
