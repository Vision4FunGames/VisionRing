using System;
using System.Collections;
using System.Collections.Generic;
using PixelCrushers.QuestMachine;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class QuestManager : MonoBehaviour
{

     public List<string> successedQuests;
     public static QuestManager instance;

     private void Awake()
     {
         instance = this;
     }

     public void SuccessQuest(string quest)
    {
        successedQuests.Add(quest);
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
