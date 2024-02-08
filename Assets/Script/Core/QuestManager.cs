using System.Collections;
using System.Collections.Generic;
using PixelCrushers.QuestMachine;
using UnityEngine;
using UnityEngine.Serialization;

public class QuestManager : MonoBehaviour
{

     public List<string> successedQuests;

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
