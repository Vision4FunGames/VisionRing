using System;
using System.Collections;
using System.Collections.Generic;
using PixelCrushers.QuestMachine.Wrappers;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;
using UnityEngine.UI;
using Button = UnityEngine.UIElements.Button;

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

    public void FillTheButtons()
    {
        completedQuestList = ES3.Load("SuccessedQuest", QuestManager.instance.successedQuests);
        InitializeActiveQuest();
        bool isAlreadyInstantiate = false;
        if (completedQuestList.Count > 0)
        {
          
            for (int i = 0; i < completedQuestList.Count; i++)
            {
                isAlreadyInstantiate = false;
                for (int j = 0; j < storyQuests.questLine.Count; j++)
                {
                    if (completedQuestList[i] == storyQuests.questLine[j].id) 
                    {
                        for (int k = 0; k < buttonParent.transform.childCount; k++)
                        {
                            if (buttonParent.transform.GetChild(k).GetChild(0).GetComponent<TextMeshProUGUI>().text ==
                                storyQuests.questLine[j].header  + "  <sprite name="+"check"+">")
                            {
                                isAlreadyInstantiate = true;
                                break;
                            }
                            
                        }

                        if (!isAlreadyInstantiate)
                        {
                            var button = Instantiate(buttonPrefab, buttonParent);
                            button.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = storyQuests.questLine[j].header + "  <sprite name="+"check"+">";
                            button.transform.SetAsFirstSibling();
                            button.GetComponent<Image>().color = Color.black;
                            var text = storyQuests.questLine[j].info;
                            button.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => FillInfoText(text));
                        }
                         
                    }
                }
            }
        }

        if (activeQuestList.Count > 0)
        {
            for (int i = 0; i < activeQuestList.Count; i++)
            {
                isAlreadyInstantiate = false;
                for (int j = 0; j < storyQuests.questLine.Count; j++)
                {
                    
                    if (activeQuestList[i] == storyQuests.questLine[j].id)
                    {
                        for (int k = 0; k < buttonParent.transform.childCount; k++)
                        {
                            if (buttonParent.transform.GetChild(k).GetChild(0).GetComponent<TextMeshProUGUI>().text ==
                                storyQuests.questLine[j].header)
                            {
                                isAlreadyInstantiate = true;
                                break;
                            }
                            
                        }

                        if (!isAlreadyInstantiate)
                        {
                            var button = Instantiate(buttonPrefab, buttonParent);
                            button.transform.SetAsFirstSibling();
                            button.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = storyQuests.questLine[j].header;
                            button.GetComponent<Image>().color = Color.white;
                            var text = storyQuests.questLine[j].info;
                            button.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => FillInfoText(text));    
                        }
                                    
                    }
                }
            }
        }
    }

    public void FillInfoText(string text)
    {
        infoText.text = text;
    }

    public void InitializeActiveQuest()
    {
        var questJournal = Player.instance.GetComponent<QuestJournal>();
        if (questJournal.questList.Count>0)
        {
            activeQuestList.Add(questJournal.questList[questJournal.questList.Count-1].id.ToString());
        }
    }
}
