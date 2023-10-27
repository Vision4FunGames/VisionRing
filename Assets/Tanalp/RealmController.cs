using AmazingAssets.DynamicRadialMasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealmController : MonoBehaviour
{
    public GameObject DRM; // Reference to the DRM game object
    public float updateSpeed = 1.0f; // Speed at which the radius value is updated
    public ParticleSystem particleSystem; // Public reference to the particle system
    public GameObject waterObject; // Reference to the new GameObject

    private DRMGameObject drmScript; // Reference to the DRMGameObject script
    private Material particleMaterial; // Material instance from the particle system
    private float timer = 0.0f;
    // Start is called when the script is initialized
    void Start()
    {
        if (particleSystem != null)
        {
            // Get the material from the particle system
            particleMaterial = particleSystem.GetComponent<Renderer>().material;
        }
        else
        {
            Debug.LogWarning("The 'particleSystem' variable is not assigned.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if (DRM != null)
        // {
        //     // Ensure we have a reference to the DRMGameObject script
        //     if (drmScript == null)
        //     {
        //         drmScript = DRM.GetComponent<DRMGameObject>();
        //     }
        //
        //     if (drmScript != null)
        //     {
        //         // Update the radius value based on the speed control
        //         timer += Time.deltaTime * updateSpeed;
        //         float newRadius = Mathf.Lerp(0f, 100f, Mathf.PingPong(timer, 1f));
        //         drmScript.radius = newRadius;
        //
        //         // Change the fog density as radius reaches 100
        //         float fogDensity = newRadius / 100f * 0.004f; // Set fog density from radius
        //         RenderSettings.fogDensity = fogDensity;
        //
        //         if (particleMaterial != null)
        //         {
        //             // Update the HDR albedo value based on the DRM radius
        //             float hdrValue = newRadius / 100f; // Set HDR albedo value from radius
        //
        //             Color albedoColor = particleMaterial.GetColor("_Color");
        //             albedoColor.a = newRadius;
        //             Color x = Color.white;
        //             x.a = hdrValue;
        //             particleMaterial.SetColor("_Color", x);
        //         }
        //         else
        //         {
        //             Debug.LogWarning("The particle system does not have a material with '_AlbedoHDR'.");
        //         }
        //
        //         if (waterObject != null)
        //         {
        //             // Get the material from the waterObject
        //             Material waterMaterial = waterObject.GetComponent<Renderer>().material;
        //
        //             if (waterMaterial != null)
        //             {
        //                 // Update the _WaterColor property
        //                 float normalizedRadius = newRadius / 100f; // Normalize the radius value to the range [0, 1]
        //                 Color startColor = new Color(0.2117f, 0.6745f, 1.0f); // Initial color
        //                 Color endColor = new Color(0.1373f, 1.0f, 0.0f); // Target color
        //
        //                 Color waterColor = Color.Lerp(startColor, endColor, normalizedRadius);
        //                 waterMaterial.SetColor("_WaterColor", waterColor);
        //             }
        //             else
        //             {
        //                 Debug.LogWarning("The 'waterObject' does not have a material with '_WaterColor'.");
        //             }
        //         }
        //         else
        //         {
        //             Debug.LogWarning("The 'waterObject' GameObject is not assigned.");
        //         }
        //
        //     }
        //     else
        //     {
        //         Debug.LogWarning("The 'DRM' object does not have a 'DRMGameObject' script attached.");
        //     }
        //
        //
        // }
        // else
        // {
        //     Debug.LogWarning("The 'DRM' game object is not assigned.");
        // }
    }
}
