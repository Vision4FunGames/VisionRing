using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class GhostAnimator : MonoBehaviour
{
    public GameObject rightHand;
    public GameObject ballPrefab;
    private Player player;

    private void Start()
    {
        player = Player.instance;
    }

    public void ThrowBall()
    {
        var currentBall = Instantiate(ballPrefab, rightHand.transform.position, Quaternion.identity);
        currentBall.transform
            .DOMove(new Vector3(player.transform.position.x, player.transform.position.y + 2f, player.transform.position.z),
                .2f).OnComplete(()=>Destroy(currentBall.gameObject));
    }
}
