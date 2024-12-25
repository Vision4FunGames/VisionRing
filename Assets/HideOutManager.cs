using System;
using AmazingAssets.DynamicRadialMasks;
using Cinemachine;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HideOutManager : MonoBehaviour
{
    public float maxRadius;
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
        hideOutCamPos = new Vector3(29f, 48f, -32);
        currentPos = playerCamPos;
        player = FindObjectOfType<Player>();
        hideOutBuildBtn.onClick.AddListener(BuildBase);
        BuildAlreadyBase();
    }

    public void BuildAlreadyBase()
    {
        if (PlayerPrefs.GetInt("HideOut" + SceneManager.GetActiveScene().name) == 1)
        {
            canvas.SetActive(false);
            DOTween.To(() => drmGameObject.baseRadius, x => drmGameObject.baseRadius = x, maxRadius, 2)
                .OnComplete(() =>
                {
                    DOTween.To(() => currentPos, x => currentPos = x, playerCamPos, 2).SetDelay(2f).OnComplete((() =>
                    {
                    }));
                });
        }
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
            DOTween.To(() => drmGameObject.baseRadius, x => drmGameObject.baseRadius = x, maxRadius, 2)
                .OnComplete(() =>
                {
                    DOTween.To(() => currentPos, x => currentPos = x, playerCamPos, 2).SetDelay(2f).OnComplete((() =>
                    {
                        hideOut = false;
                        player.isMovement = true;
                        PlayerPrefs.SetInt("HideOut" + SceneManager.GetActiveScene().name, 1);
                        if (!PlayerPrefs.HasKey("HideOutReward"))
                        {
                            FindObjectOfType<TaskReward>().rewardPanel.transform.DOScale(new Vector3(1, 1, 1), .5f);
                            FindObjectOfType<TaskReward>().rewardTxt.text = "Dungeon Key (T1)";
                        }
                    }));
                });
        }));
    }
}