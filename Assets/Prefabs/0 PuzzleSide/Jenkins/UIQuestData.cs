using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class UIQuestData : MonoBehaviour
{
    public StoryQuests storyQuests;

    public List<string> completedQuestList;
    public List<string> activeQuestList;
    [SerializeField]private TextMeshProUGUI infoText;
    [SerializeField]private Transform buttonParent;
    [SerializeField] private GameObject buttonPrefab;

    private void Start()
    {
       completedQuestList = ES3.Load("SuccessedQuest", QuestManager.instance.successedQuests);
       FillTheButtons();
    }

    private void FillTheButtons()
    {
        if (completedQuestList.Count > 0)
        {
            for (int i = 0; i < completedQuestList.Count; i++)
            {
                
            }
            for (int i = 0; i < completedQuestList.Count; i++)
            {
                for (int j = 0; j < storyQuests.questLine.Count; j++)
                {
                    if (completedQuestList[i] == storyQuests.questLine[j].id) 
                    {
                          var button = Instantiate(buttonPrefab, buttonParent);
                          button.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = storyQuests.questLine[j].header + "  <sprite name="+"check"+">";
                          button.GetComponent<Image>().color = Color.black;
                    }
                }
            }
        }
    }
}
