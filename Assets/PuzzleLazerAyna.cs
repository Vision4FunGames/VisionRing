using System;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PuzzleLazerAyna : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    public GameObject lineDetectObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lazer"))
        {
            lineDetectObject = other.gameObject;
            SetLazerCompenent();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Lazer"))
        {
            DeleteLazerPos();
        }
    }

    public void DeleteLazerPos()
    {
        Vector3 currentPos = lineDetectObject.transform.forward * 40;
        lineDetectObject.GetComponentInParent<LineRenderer>().SetPosition(1,new Vector3(0,0,currentPos.z));
        _lineRenderer.enabled = false;
        GetComponentInChildren<MeshCollider>().enabled = false;
    }

    public void GenerateMeshCollider()
    {
        MeshCollider collider = GetComponentInChildren<MeshCollider>();
        if (collider == null)
        {
            collider = gameObject.transform.GetChild(0).AddComponent<MeshCollider>();
            Mesh mesh = new Mesh();
            _lineRenderer.BakeMesh(mesh);
            collider.sharedMesh = mesh;
            collider.tag = "Lazer";
        }
    }

    public void SetLazerCompenent()
    {
        _lineRenderer ??= gameObject.transform.GetChild(0).AddComponent<LineRenderer>();
        _lineRenderer.useWorldSpace = false;
        _lineRenderer.enabled = true;
        _lineRenderer.material =
            lineDetectObject.GetComponentInParent<LineRenderer>().material;
        float distance = Vector3.Distance (transform.position, lineDetectObject.transform.position);
        lineDetectObject.GetComponentInParent<LineRenderer>().SetPosition(1,new Vector3(0,0,distance));
        _lineRenderer.ResetBounds();
        _lineRenderer.SetPosition(0,
            new Vector3(0, 0, 0));
        SetLazerPosition();
    }

    public void SetLazerPosition()
    {
        Vector3 lazerPos = (Vector3.forward * 40);
        lazerPos = new Vector3(0, 0, lazerPos.z);
        _lineRenderer.SetPosition(1, lazerPos);
        GenerateMeshCollider();
    }
}