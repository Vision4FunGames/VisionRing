using System.Collections;
using System.Collections.Generic;
using GameAnalyticsSDK.Setup;
using PixelCrushers.QuestMachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool merchantTutorial;

    public bool blackSmithTurial;

    public bool magicianTutorial;

    public bool farmerTutorail;

    public bool baskanTutorial;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.name == "Blacksmith")
                {
                    if (blackSmithTurial)
                    {
                      
                        FindObjectOfType<MeetBuckley>()?.SpeechStart();
                        blackSmithTurial = false;
                    }
                    else
                    {
                        UiManager.instance.BlackSmithUI();
                        QuestMachineMessages.SendCompositeMessage(this, "Meet:Blacksmith");
                    }
                    
                }

                else if (hit.transform.gameObject.name == "pouch")
                {
                    //  hit.transform.gameObject.GetComponent<PouchManager>().OpenPouchPanel();
                    UiManager.instance.selectedPouch = hit.transform.gameObject;
                }
                else if (hit.transform.gameObject.name == "Chest")
                {
                    hit.transform.gameObject.GetComponent<ChestManager>().GoToCamera();
                    hit.transform.gameObject.GetComponent<BoxCollider>().enabled = false;
                }

                else if (hit.transform.gameObject.name == "Merchant")
                {
                    if (merchantTutorial)
                    {
                        FindObjectOfType<TalkWithAaliyah>()?.SpeechStart();
                        FindObjectOfType<TalkWAaliyah>()?.SpeechStart();

                        merchantTutorial = false;
                    }
                    else
                    {
                        UiManager.instance.CloseAllUI();
                        UiManager.instance.ShopUI();
                    }
                }else if (hit.transform.gameObject.name == "Farmer")
                {
                    if (farmerTutorail)
                    {
                        FindObjectOfType<MeetShirley>()?.SpeechStart();
                        farmerTutorail = false;
                    }
                    else
                    {
                        UiManager.instance.CloseAllUI();
                        UiManager.instance.ShopUI();
                    }
                }
                else if (hit.transform.gameObject.name == "Magician")
                {
                    if (magicianTutorial)
                    {
                        FindObjectOfType<MeetMarley>().SpeechStart();

                        magicianTutorial = false;
                    }
                    else
                    {
                        QuestMachineMessages.SendCompositeMessage(this, "Found:Magician");
                        UiManager.instance.MagicianUI();
                    }
                 
                }
                else if (hit.transform.gameObject.name == "Baskan")
                {
                    if (baskanTutorial)
                    {
                        baskanTutorial = false;
                        FindObjectOfType<MeetRuthledge>()?.SpeechStart();
                    }
                    else
                    {
                        UiManager.instance.DungeonPanelOpen();
                    }
                }
            }
        }
    }
}