using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class TurnAround : MonoBehaviour
{
    public Transform player; // Player'ın Transform component'ini referans alacak değişken
    public float circleRadius = 3f; // Yarıçap
    public float moveSpeed = 3f; // Hareket hızı
    public float minDistanceToPlayer = 5f;
    private Vector3 centerPosition; // Dairenin merkez pozisyonu
    private float currentAngle = 0f; // Dolaşılacak açı
    private bool isMovingToPlayer = false; // Player'a doğru hareket etme durumu
    private bool isInside;
    void Start()
    {
        player = Player.instance.transform;
        centerPosition = transform.position; // Dairenin merkez pozisyonunu Coin'in pozisyonu olarak belirle
    }

    void Update()
    {
        transform.Rotate (Vector3.up * 50 * Time.deltaTime, Space.World);
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceToPlayer< minDistanceToPlayer)
        {
            isInside = true;
        }

        if (isInside)
        {
            if (!isMovingToPlayer)
            {
                // Daire üzerinde yarım daire hareketi
                float x = centerPosition.x + Mathf.Cos(currentAngle) * circleRadius;
                float z = centerPosition.z + Mathf.Sin(currentAngle) * circleRadius;

                Vector3 targetPosition = new Vector3(x, transform.position.y, z);

                // Coin'i hedef pozisyona doğru hareket ettir
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

                // Açıyı güncelle, böylece Coin sürekli olarak yarım daireyi dolaşır
                currentAngle += Time.deltaTime * moveSpeed / circleRadius;

                // Eğer açı 180 dereceden büyükse, Player'a doğru hareketi başlat
                if (currentAngle > 30f)
                {
                    currentAngle = 30f;
                    isMovingToPlayer = true;
                }
            }
            else
            {
                // Player'a doğru hareket et
                transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);

                // Eğer Player'a ulaşıldıysa Coin'i yok et
                if (Vector3.Distance(transform.position, player.position) < 0.1f)
                {
                    Destroy(gameObject);
                }
            } 
        }
        
       
    }
    
}
