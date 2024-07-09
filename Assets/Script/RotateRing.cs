using UnityEngine;

public class RotateRing : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 lastMousePosition;
    private Vector3 currentRotation;
    private Vector3 targetRotation;
    void Update()
    {
        // Sol mouse tuşuna basıldığında
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            lastMousePosition = Input.mousePosition;
        }

        // Sol mouse tuşu bırakıldığında
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        // Objeyi sürüklerken döndür
        if (isDragging)
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            float angleX = delta.y * 0.9f; // Yatay eksende döndürme hızı
            float angleY = -delta.x * 0.9f; // Dikey eksende döndürme hızı

            targetRotation = new Vector3(currentRotation.x + angleX, currentRotation.y + angleY, currentRotation.z);

            lastMousePosition = Input.mousePosition;
        }

        // Mevcut rotasyonu hedef rotasyona doğru Lerp ile güncelle
        currentRotation = Vector3.Lerp(currentRotation, targetRotation, Time.deltaTime * 5f);
        transform.rotation = Quaternion.Euler(currentRotation);
    }
}