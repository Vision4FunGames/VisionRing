using UnityEngine;

public class TerrainTextureChanger : MonoBehaviour
{
    public Terrain terrain;
    public float changeInterval = 0.1f; // Time interval between texture changes (in seconds)
    public Texture2D[] targetTextures;  // An array to store the target textures for the first terrain layer
    private TerrainData terrainData;
    private int currentTextureIndex = 0;
    private float timer = 0f;

    private void Start()
    {
        if (terrain == null)
        {
            Debug.LogError("Terrain reference is missing. Please assign the terrain.");
            enabled = false;
            return;
        }

        terrainData = terrain.terrainData;

        // Make sure there are textures to change to for the first terrain layer
        if (targetTextures == null || targetTextures.Length == 0)
        {
            Debug.LogError("No target textures assigned. Please assign textures to the 'Target Textures' array.");
            enabled = false;
            return;
        }

        // Initialize the terrain's splatmap for the first layer with the first texture
        SetTerrainTexture(currentTextureIndex);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        // Check if it's time to change the texture
        if (timer >= changeInterval)
        {
            // Reset the timer
            timer = 0f;

            // Increment the texture index
            currentTextureIndex++;

            // Check if we've reached the end of the textures array
            if (currentTextureIndex >= targetTextures.Length)
            {
                currentTextureIndex = 0; // Loop back to the first texture
            }

            // Change the terrain texture for the first layer
            SetTerrainTexture(currentTextureIndex);
        }
    }

    // Helper method to set the terrain texture for the first layer
    private void SetTerrainTexture(int textureIndex)
    {
        SplatPrototype[] splatPrototypes = terrainData.splatPrototypes;

        // Ensure the texture index is within bounds
        if (textureIndex >= 0 && textureIndex < targetTextures.Length)
        {
            // Create a new SplatPrototype with the target texture
            SplatPrototype newSplat = new SplatPrototype();
            newSplat.texture = targetTextures[textureIndex];

            // Replace the first splat prototype with the new one
            splatPrototypes[0] = newSplat;

            // Apply the changes to the terrain
            terrainData.splatPrototypes = splatPrototypes;
            terrain.Flush(); // Flush the terrain to apply the changes
        }
    }
}
