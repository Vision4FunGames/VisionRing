using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsDrawer : MonoBehaviour
{
    public Color gizmoColor;
    private BoxCollider _boxCollider;
    public BoxCollider BoxCollider
    {
        get
        {
            if (_boxCollider != null)
                return _boxCollider;
            _boxCollider = GetComponent<BoxCollider>();
            return _boxCollider;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Matrix4x4 oldGizmosMatrix = Gizmos.matrix;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawCube(BoxCollider.center, BoxCollider.size);
        Gizmos.matrix = oldGizmosMatrix;
    }
}
