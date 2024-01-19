using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Script.Player.PlayerStateMachine;
using UnityEngine;

public class BoxItem : MonoBehaviour
{
    public GameObject[] playerDragPos;

    public bool movement;
    public Vector3 offset;
    private PuzzleController _puzzleController;
    private Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
        _puzzleController = GetComponentInParent<PuzzleController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BoxHolder"))
        {
            _puzzleController.DoneStoneMission();
            transform.parent = other.gameObject.transform;
            transform.localPosition = new Vector3(0, 0, 0);
           // transform.rotation = Quaternion.identity;
            GetComponent<Collider>().isTrigger = false;
            Player.instance.StateMachine.ChangeState(new PlayerMovementState(Player.instance,Player.instance.StateMachine,false));
        }
        if (other.gameObject.CompareTag("BoxPointTutorial"))
        {
          
        }
    }

    private float distance;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("BoxPointTutorial"))
        {
            distance = Vector3.Distance(transform.position, other.transform.position);
            if (Vector3.Distance(transform.position, other.transform.position) < 1f)
            {
                other.gameObject.GetComponent<Collider>().enabled = false;
                GameManager.instance.isBox = true;
                Player.instance.StateMachine.ChangeState(new PlayerMovementState(Player.instance,Player.instance.StateMachine,false));
                //Invoke(GameManager.instance.TutorialLoad(),2f);
          
                transform.DOMove(other.gameObject.transform.position,2f).OnComplete(() =>
                {
                    GameManager.instance.tutorialWall.transform.DOLocalMoveY(-1f, 5f);
                    GameManager.instance.CinematicCamEnable(GameManager.instance.tutorialWall.transform.GetChild(0).transform,
                        3f);
                });
            }
        }
    }
} 
