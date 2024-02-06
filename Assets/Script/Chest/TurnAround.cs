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
    private Canvas canvasMain;
    private bool done;
    private int goldCount;
    private bool goldSetted;
    public int getGoldCount() => goldCount;
    public void setGoldCount(int value)
    {
      
        goldCount = value;
       
        goldSetted = true;
     
    }

    void Start()
    {
        canvasMain = GameObject.FindGameObjectWithTag("mainCanvas").GetComponent<Canvas>();
        player = Player.instance.transform;
        centerPosition = transform.position; // Dairenin merkez pozisyonunu Coin'in pozisyonu olarak belirle
        
        transform.DOLocalJump(new Vector3(Random.Range(-3f,3f),-1f,Random.Range(-4f,4f)), 3f, 1, 1.5f).SetEase(Ease.OutBack);
        GetComponent<Collider>().isTrigger = true;
    }

    void Update()
    {
        if (goldSetted)
        {
            transform.Rotate (Vector3.up * 50 * Time.deltaTime, Space.World);
    float distanceToPlayer = Vector3.Distance(transform.position, player.position);
    if (distanceToPlayer< minDistanceToPlayer)
    {
        isInside = true;
    }
    
    if (isInside)
    {
        // Player'a doğru hareket et
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.position.x,player.position.y+2f,player.position.z), moveSpeed *2* Time.deltaTime);
        GetComponent<Collider>().isTrigger = true;
        // Eğer Player'a ulaşıldıysa Coin'i yok et
        if (Vector3.Distance(transform.position, new Vector3(player.position.x,player.position.y +2f,player.position.z)) < 0.1f)
        {
            EconomyManager.instance.SetGold(goldCount);
            Destroy(gameObject);
        }
        // if (!isMovingToPlayer)
        // {
        //     // // Daire üzerinde yarım daire hareketi
        //     // float x = centerPosition.x + Mathf.Cos(currentAngle) * circleRadius;
        //     // float z = centerPosition.z + Mathf.Sin(currentAngle) * circleRadius;
        //     //
        //     // Vector3 targetPosition = new Vector3(x, transform.position.y, z);
        //     //
        //     // // // Coin'i hedef pozisyona doğru hareket ettir
        //     // transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        //     //
        //     // // Açıyı güncelle, böylece Coin sürekli olarak yarım daireyi dolaşır
        //     // currentAngle += Time.deltaTime * moveSpeed *3f / circleRadius;
        //     // isMovingToPlayer = true;
        //     // Eğer açı 180 dereceden büyükse, Player'a doğru hareketi başlat
        //     // if (currentAngle > 30f)
        //     // {
        //     //     currentAngle = 30f;
        //     //     //isMovingToPlayer = true;
        //     //     
        //     // }
        //     
        // }
        // else
        // {
        //     // Player'a doğru hareket et
        //     transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.position.x,player.position.y+2f,player.position.z), moveSpeed *2* Time.deltaTime);
        //     GetComponent<Collider>().isTrigger = true;
        //     // Eğer Player'a ulaşıldıysa Coin'i yok et
        //     if (Vector3.Distance(transform.position, new Vector3(player.position.x,player.position.y +2f,player.position.z)) < 0.1f)
        //     {
        //       CollectAnimation();
        //     }
        // } 
    }
        }
        
    
        
       
    }
    private void CollectAnimation()
    {
        if (!done)
        {
            done = true;
            var target = canvasMain.transform.GetChild(0).GetChild(8).transform;
            GameObject current = Instantiate(Resources.Load<GameObject>("coin"), canvasMain.transform);
            Vector3 goldpos = Camera.main.WorldToScreenPoint(this.transform.position);
            current.transform.position = goldpos+new Vector3(Random.Range(10f,100f),Random.Range(10f,100f),Random.Range(10f,100f));
            current.transform.DOLocalMove(new Vector3(target.localPosition.x-2f,target.localPosition.y-2f,target.localPosition.z), 1f).SetDelay(Random.Range(0f,1f)).OnComplete(() =>
            {
                Destroy(current);
                Destroy(gameObject);
            });
        }
            
         

    }
    
}
