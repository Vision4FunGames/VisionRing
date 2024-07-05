using System;
using AmazingAssets.DynamicRadialMasks;
using Cinemachine;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HideOutManager : MonoBehaviour
{
    public GameObject canvas;
    public Button hideOutBuildBtn;
    public DRMGameObject drmGameObject;
    private Player player;
    private CinemachineTransposer mfollowOfset;
    private Vector3 playerCamPos, hideOutCamPos;
    private Vector3 currentPos;
    private bool hideOut;

    void Start()
    {
        mfollowOfset = GameManager.instance.playerVCam.GetCinemachineComponent<CinemachineTransposer>();
        playerCamPos = new Vector3(18.7801094f, 25f, -23.4532204f);
        hideOutCamPos = new Vector3(33.8899994f, 43.5099983f, -42.3300285f);
        currentPos = playerCamPos;
        player = FindObjectOfType<Player>();
        hideOutBuildBtn.onClick.AddListener(BuildBase);
    }

    public void BuildAlreadyBase()
    {
        canvas.SetActive(false);
    }

    private void Update()
    {
        if (hideOut)
            mfollowOfset.m_FollowOffset = currentPos;
    }

    public void BuildBase()
    {
        hideOut = true;
        canvas.SetActive(false);
        player.isMovement = false;

        DOTween.To(() => currentPos, x => currentPos = x, hideOutCamPos, 2).OnComplete((() =>
        {
            DOTween.To(() => drmGameObject.baseRadius, x => drmGameObject.baseRadius = x, 78f, 2)
                .OnComplete(() =>
                {
                    DOTween.To(() => currentPos, x => currentPos = x, playerCamPos, 2).SetDelay(2f).OnComplete((() =>
                    {
                        hideOut = false;
                        player.isMovement = true;
                    }));
                });
        }));
    }
}