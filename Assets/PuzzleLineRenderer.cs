using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PuzzleLineRenderer : MonoBehaviour
{
    public LineRenderer lazer;

    private void Awake()
    {
        lazer = GetComponentInChildren<LineRenderer>();
        GenerateMeshCollider();
    }

    public void GenerateMeshCollider()
    {
        MeshCollider collider = GetComponent<MeshCollider>();
        if (collider == null)
        {
            collider = gameObject.transform.GetChild(0).AddComponent<MeshCollider>();
        }

        Mesh mesh = new Mesh();
        lazer.BakeMesh(mesh);
        collider.sharedMesh = mesh;
        collider.tag = "Lazer";
    }
}