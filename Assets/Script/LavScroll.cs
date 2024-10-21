using UnityEngine;

public class LavScroll : MonoBehaviour
{
    public Material material;
    public Vector2 surfaceSpeed = new Vector2(0.1f, 0.1f); // Ana doku hızı
    public Vector2 detailSpeed = new Vector2(0.05f, 0.05f); // Detay doku hızı

    private Vector2 surfaceOffset = Vector2.zero;
    private Vector2 detailOffset = Vector2.zero;

    void Update()
    {
        // Ana dokunun offset'ini ayarla
        surfaceOffset += surfaceSpeed * Time.deltaTime;
        material.SetTextureOffset("_BaseMap", surfaceOffset); // Main texture offset

        // Detay dokunun offset'ini ayarla
        detailOffset += detailSpeed * Time.deltaTime;
        material.SetTextureOffset("_DetailAlbedoMap", detailOffset); // Detail texture offset
    }
}
