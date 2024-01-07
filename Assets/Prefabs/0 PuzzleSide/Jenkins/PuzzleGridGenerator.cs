using System.Collections;
using System.Collections.Generic;
using Exoa.TutorialEngine;
using NaughtyAttributes;
using UnityEditor;
using UnityEngine;

public class PuzzleGridGenerator : MonoBehaviour
{
    [HorizontalLine(2f, EColor.Red)]
    public GameObject center;
    public GameObject borderCorner;
    public GameObject borderCenter;
    [HorizontalLine(2f, EColor.Red)]
    public Transform centerParent;
    public Transform borderCenterParent;
    public Transform borderCornerParent;
    [HorizontalLine(2f, EColor.Red)]
    public int gridSizeX = 5;
    public int gridSizeZ = 5;
    public float spacing = 1.0f;
    [HorizontalLine(2f, EColor.Red)]
    public float cornerOffset;
    public float heightOffset = -1;

    [Button()]
    public void Spawn()
    {
        ClearAll();
        SpawnCenter();
        SpawnCorners();
        SpawnBorders();
    }



    void SpawnCenter()
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int z = 0; z < gridSizeZ; z++)
            {
                Vector3 position = new Vector3(x * spacing, 0.0f, z * spacing);
                GameObject go = EditorUtility.InstantiatePrefab(center) as GameObject;
                go.transform.SetParent(centerParent, true);
                go.transform.localPosition = position;
            }
        }

        gameObject.name = "PuzzleBlock [" + gridSizeX + "x" + gridSizeZ + "]";
    }
    void PrepareCorner(int x, int z, Vector3 side, float angle)
    {
        Vector3 position = new Vector3(x * spacing, 0.0f, z * spacing);
        var offset = side * cornerOffset;
        position += offset;
        position += Vector3.up * heightOffset;
        GameObject go = EditorUtility.InstantiatePrefab(borderCorner) as GameObject;
        go.transform.SetParent(borderCornerParent, true);
        go.transform.localPosition = position;
        go.transform.localEulerAngles = Vector3.up * angle;
    }

    void PrepareBorder(int x, int z, Vector3 side)
    {
        Vector3 position = new Vector3(x * spacing, 0.0f, z * spacing);
        var offset = side * cornerOffset;
        position += offset;
        position += Vector3.up * heightOffset;
        GameObject go = EditorUtility.InstantiatePrefab(borderCenter) as GameObject;
        go.transform.SetParent(borderCenterParent, true);
        go.transform.localPosition = position;
        go.transform.localEulerAngles = Vector3.up * 90 * Random.Range(0, 4);
    }

    public void SpawnCorners()
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int z = 0; z < gridSizeZ; z++)
            {
                if (x == 0 && z == 0)
                {
                    // Bottom Left
                    PrepareCorner(x, z, Vector3.left - Vector3.forward, 180);
                }
                else if (x == gridSizeX - 1 && z == 0)
                {
                    // Bottom Right
                    PrepareCorner(x, z, Vector3.right - Vector3.forward, 90);
                }
                else if (x == gridSizeX - 1 && z == gridSizeZ - 1)
                {
                    // Top Right
                    PrepareCorner(x, z, Vector3.right + Vector3.forward, 0);
                }
                else if (x == 0 && z == gridSizeZ - 1)
                {
                    // Top Left
                    PrepareCorner(x, z, Vector3.left + Vector3.forward, 270);
                }
            }
        }

    }

    public void SpawnBorders()
    {
        SpawnLeftRight();
        SpawnTopBottom();
    }
    void SpawnLeftRight()
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int z = 0; z < gridSizeZ; z++)
            {
                if (x == 0 && (z != 0 || z != gridSizeZ - 1))
                {
                    // Left Side
                    PrepareBorder(x, z, Vector3.left);
                }
                if (x == gridSizeX - 1 && (z != 0 || z != gridSizeZ - 1))
                {
                    // Right Side
                    PrepareBorder(x, z, Vector3.right);
                }
            }
        }
    }
    void SpawnTopBottom()
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int z = 0; z < gridSizeZ; z++)
            {
                if (z == gridSizeZ - 1)
                {
                    // Top 
                    PrepareBorder(x, z, Vector3.forward);
                }
                if (z == 0)
                {
                    // Bottom
                    PrepareBorder(x, z, Vector3.back);
                }
            }
        }
    }

    [Button()]
    public void ClearAll()
    {
        var centerChildCount = centerParent.childCount;
        for (int i = 0; i < centerChildCount; i++)
        {
            var obj = centerParent.GetChild(0).gameObject;
            DestroyImmediate(obj);
        }
        var cornerChildCount = borderCornerParent.childCount;
        for (int i = 0; i < cornerChildCount; i++)
        {
            var obj = borderCornerParent.GetChild(0).gameObject;
            DestroyImmediate(obj);
        }
        var borderChildCount = borderCenterParent.childCount;
        for (int i = 0; i < borderChildCount; i++)
        {
            var obj = borderCenterParent.GetChild(0).gameObject;
            DestroyImmediate(obj);
        }

    }

}
