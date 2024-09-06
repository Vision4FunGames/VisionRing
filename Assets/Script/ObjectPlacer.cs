using UnityEngine;

[ExecuteInEditMode] // Bu komut, scriptin editör modunda çalışmasını sağlar
public class ObjectPlacer : MonoBehaviour
{
    public GameObject[] objectPrefab; // Yerleştirilecek objeler
    public int objectCount = 10; // Yerleştirilecek obje sayısı
    public float spacing = 5f; // Obje aralarındaki mesafe
    public int maxColumns = 4; // Maksimum sütun sayısı

    private void OnValidate()
    {
        // Editörde yapılan değişiklikler sonrası objeleri düzenle
        PlaceObjects();
    }

    private void PlaceObjects()
    {
        // Eski objeleri temizle
        ClearObjects();

        // Yerleştirilecek obje sayısını prefab uzunluğuna göre ayarla
        int count = Mathf.Min(objectCount, objectPrefab.Length);

        for (int i = 0; i < count; i++)
        {
            // Satır ve sütun hesaplama
            int row = i / maxColumns;
            int column = i % maxColumns;

            // Obje konumunu hesapla
            Vector3 position = new Vector3(column * spacing, 0, row * spacing);

            // Obje oluştur
            if (objectPrefab[i] != null)
            {
                Instantiate(objectPrefab[i], position, Quaternion.identity, transform);
            }
        }
    }

    private void ClearObjects()
    {
        // Mevcut tüm çocuk objeleri sil
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            DestroyImmediate(transform.GetChild(i).gameObject);
        }
    }
}