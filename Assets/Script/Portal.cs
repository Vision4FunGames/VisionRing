using System;
using System.Collections;
using System.Collections.Generic;
using Exoa.TutorialEngine;
using GameAnalyticsSDK;
using PixelCrushers.QuestMachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private Player player;
    public GameObject targetpuzzle;
    public string message = "Entry:Portal";
    public bool portalEnd;
    private float currentCompletePortalTime;
    private void Awake()
    {
        
        player = FindObjectOfType<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetComponent<PlayerManager>().currentPortalTime >
            other.GetComponent<PlayerManager>().portalTime)
        {
            other.GetComponent<PlayerManager>().currentPortalTime = 0;
            QuestMachineMessages.SendCompositeMessage(this, message);
            print("Player portal");
            player.isMovement = false;
            targetpuzzle.SetActive(true);
            player.transform.position = targetpuzzle.transform.position;
            Invoke("IsMovementAgain", 1f);
            if (!GameManager.instance.isDungeon)
            {
                GameManager.instance.isDungeon = true;
                PlayerPrefs.SetInt("isDungeon", 1);
                TutorialLoader.instance.Load("Dungeon");
            }

            if (!portalEnd)
            {
                currentCompletePortalTime = 0;
                GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Puzzle", targetpuzzle.name);
            }
            else
            {
                GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Puzzle", targetpuzzle.name,(int)currentCompletePortalTime);
                currentCompletePortalTime = 0;
            }
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
        currentCompletePortalTime += Time.deltaTime;
    }
}