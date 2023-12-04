using System.Collections.Generic;
using UnityEngine;

public class PlayerRender : MonoBehaviour
{
    public Material transparentMaterial;
    public GameObject player;
    public Camera _camera;
    private List<Material> originalMaterial;
    public GameObject currentRenderer;
    public LayerMask mylayermask;
    public float maxdistance;
    public bool isOk;

    private void Start()
    {
        _camera = Camera.main;
        originalMaterial = new List<Material>();
    }

    private void Update()
    {
        //RaycastPlayer();
    }

    public void RaycastPlayer()
    {
        if (_camera != null && isOk)
        {
            Vector3 playerPos = new Vector3(player.transform.position.x, player.transform.position.y,
                player.transform.position.z);
            Vector3 fwd = -_camera.transform.position + playerPos;
            RaycastHit hit;
            if (Physics.Raycast(_camera.transform.position, fwd, out hit, maxdistance, mylayermask))
            {
                if (!hit.collider.CompareTag("Player"))
                {
                    //print(hit.transform.name);
                    GameObject obj = hit.collider.gameObject;
                    Renderer renderer = obj.GetComponentInChildren<Renderer>();
                    if (renderer != null && obj != currentRenderer)
                    {
                        currentRenderer = renderer.gameObject;
                        MaterialTransparent();
                    }
                }
                else if (hit.collider.CompareTag("Player"))
                {
                    //print(hit.transform.name);
                    MaterialOpueAndDeleteList();
                }
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Vector3 direction = -_camera.transform.position + new Vector3(player.transform.position.x,
            player.transform.position.y, player.transform.position.z);
        Gizmos.DrawRay(transform.position, direction);
    }

    public void MaterialTransparent()
    {
        Material[] currentMaterial = new Material[currentRenderer.GetComponentInChildren<Renderer>().materials.Length];
        for (int i = 0; i < currentRenderer.GetComponentInChildren<Renderer>().materials.Length; i++)
        {
            originalMaterial.Add(currentRenderer.GetComponentInChildren<Renderer>().materials[i]);
            currentMaterial[i] = transparentMaterial;
            currentMaterial[i].mainTexture = originalMaterial[i].mainTexture;
        }

        currentRenderer.GetComponentInChildren<Renderer>().materials = currentMaterial;
    }

    public void MaterialOpueAndDeleteList()
    {
        if (currentRenderer != null)
        {
            for (int i = 0; i < currentRenderer.GetComponentInChildren<Renderer>().materials.Length; i++)
            {
                currentRenderer.GetComponentInChildren<Renderer>().materials = originalMaterial.ToArray();
            }

            currentRenderer = null;
            originalMaterial.Clear();
        }
    }
}