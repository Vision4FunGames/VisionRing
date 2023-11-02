using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class ChestManager : MonoBehaviour
{
    public Camera mainCamera;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        mainCamera = Camera.main;
      
    }

 

    public void GoToCamera()
    {
        GameManager.instance.playerVCam.Follow = transform;
        anim.SetTrigger("Open");
        transform.DOScale(new Vector3(4f, 4f, 4f), 2f)
            .OnComplete(() =>
            {
                UiManager.instance.ChestPanelUI();
                UiManager.instance.caseScroll.GetComponent<CaseScroll>().Scroll();
            });
    }
}
