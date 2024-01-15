using System;
using System.Collections;
using System.Collections.Generic;
using PixelCrushers.QuestMachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private Player player;
    public GameObject targetpuzzle;
    public string message = "Collected:Diamond";
    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            QuestMachineMessages.SendCompositeMessage(this,message);
            print("Player portal");
            player.isMovement = false;
            targetpuzzle.SetActive(true);
            player.transform.position = targetpuzzle.transform.position;
            Invoke("IsMovementAgain",1f);
            GetComponent<Collider>().enabled = false;
        }
            

    }

    public void IsMovementAgain()
    {
        player.isMovement = true;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}