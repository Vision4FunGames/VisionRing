using System;
using System.Collections;
using System.Collections.Generic;
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

        if (other.gameObject.CompareTag("Floor"))
        {
            transform.position = startPos;
            Player.instance.StateMachine.ChangeState(new PlayerMovementState(Player.instance,Player.instance.StateMachine,false));
        }
    }
}
