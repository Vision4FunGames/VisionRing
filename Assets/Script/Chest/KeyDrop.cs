using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using DG.Tweening;
using Lofelt.NiceVibrations;
using MoreMountains.Tools;
using Unity.VisualScripting;
using UnityEngine;

public class KeyDrop : MonoBehaviour
{
    private Transform player;

    private bool isArrived = false;
    
    // Start is called before the first frame update
    void Start()
    {
        player = Player.instance.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.position.x,player.position.y+2f,player.position.z), 5f *2* Time.deltaTime);
        
        // Eğer Player'a ulaşıldıysa Coin'i yok et
        if (Vector3.Distance(transform.position, new Vector3(player.position.x,player.position.y +2f,player.position.z)) < 0.1f)
        {
            if (!isArrived)
            {
                isArrived = true;
                ArriveToPlayer();
            } 
            
        }
    }

    public void ArriveToPlayer()
    {
        if (isArrived)
        {
            
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.HeavyImpact);
            transform.parent = Player.instance.transform;
            transform.localPosition = new Vector3(0, 0, 0);
            transform.DOScale(3f, 1f);
            transform.DORotate(new Vector3(0, 90, 90), 1f).SetLoops(-1, LoopType.Incremental);
            transform.DOLocalMove(new Vector3(0, 10, 0), 2f).OnComplete((() =>
            {
                GameManager.instance.TutorialLoad();
                Destroy(gameObject);
            }));

        }
    }
}
