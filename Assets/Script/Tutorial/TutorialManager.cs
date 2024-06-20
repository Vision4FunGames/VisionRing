// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class TutorialManager : MonoBehaviour
// {
//     public bool isMagician;
//     public bool isBlacksmith;
//     public bool isRing;
//     public bool isHeal;
//     public bool isBox;
//     public bool isColosseum;
//     public bool isDash;
//     public bool isDungeon;
//     public float currentTime;
//     public bool fightBool;
//     public GameObject tutoVaril;
//     public GameObject tutorialIncreaserFirst;
//     [Header("Tutorial")] public GameObject tutorialEnemies;
//     public GameObject tutoCage;
//     public GameObject tutorialWall;
//     public GameObject tutorialCollider1, tutorialCollider2, villageEntryCollider;
//     public GameObject wallFires;
//     public GameObject tutorialBox, tutorialBoxArea;
//     public int tutorialCounter = 0;
//     public int tutorialSection;
//     private string tutorialName;
//     public bool tutorial;
//     public GameObject tutorial1SpawnPos;
//     public GameObject tutorialStartPos;
//     public GameObject baskan;
//     public GameObject merchant;
//     public GameObject blacksmith;
//     public GameObject magician;
//     public GameObject villageDoor, villageDoor2;
//     public GameObject colosseum;
//     public GameObject firstLevelEnemies;
//     public GameObject realmChange;
//     public GameObject seaWater;
//     public GameObject campFire;
//     public GameObject StonePanel;
//     private void Awake()
//     {
//         if (PlayerPrefs.HasKey("TutorialSection"))
//         {
//             tutorialCounter = 0;
//             tutorialSection = PlayerPrefs.GetInt("TutorialSection");
//         }
//          if (PlayerPrefs.HasKey("TutorialSection"))
//         {
//             tutorialSection = PlayerPrefs.GetInt("TutorialSection");
//         }
//
//         if (tutorialSection == 1)
//         {
//             // //Quest quest = new Quest(questMachineConfiguration)
//             // Player.instance.GetComponent<QuestJournal>()
//             //     .AddQuest(questMachineConfiguration.questDatabases[0].questAssets[9]);
//         }
//
//         if (tutorialSection == 2)
//         {
//             tutorial = true;
//         }
//         // else if (magician.GetComponent<QuestGiver>().HasOfferableOrActiveQuest())
//         // {
//         //     var questlist = magician.GetComponent<QuestGiver>().questList;
//         //     for (int i = 0; i < questlist.Count; i++)
//         //     {
//         //         if (_questManager.successedQuests.Contains(questlist[i].id.ToString()))
//         //         {
//         //             questlist[i].SetState(QuestState.Successful);
//         //             Debug.Log(questlist[i].id.ToString()+ " Bitirildi ");
//         //         }
//         //         else
//         //         {
//         //             questlist[i].SetState(QuestState.WaitingToStart);
//         //             IndicatorDefine(magician);
//         //             break;
//         //         }
//         //     }
//         // }
//
//         if (PlayerPrefs.HasKey("Blacksmith"))
//         {
//             if (PlayerPrefs.GetInt("Blacksmith") == 1)
//             {
//                 isBlacksmith = true;
//             }
//         }
//
//         if (PlayerPrefs.HasKey("Merchant"))
//         {
//             if (PlayerPrefs.GetInt("Merchant") == 1)
//             {
//             }
//         }
//
//         if (PlayerPrefs.HasKey("Magician"))
//         {
//             if (PlayerPrefs.GetInt("Magician") == 1)
//             {
//                 isMagician = true;
//             }
//         }
//
//         if (PlayerPrefs.HasKey("Ring"))
//         {
//             if (PlayerPrefs.GetInt("Ring") == 1)
//             {
//                 if (gameState != GameState.Tutorial)
//                 {
//                     isRing = true;
//                     UiManager.instance.ringBtn.gameObject.SetActive(true);
//                     UiManager.instance.ringBtn.GetComponent<Button>().enabled = true;
//                 }
//             }
//             else
//             {
//                 UiManager.instance.ringBtn.gameObject.SetActive(false);
//             }
//         }
//
//         if (PlayerPrefs.HasKey("FirstEnemies"))
//         {
//             if (PlayerPrefs.GetString("FirstEnemies") == "True")
//             {
//                 firstLevelEnemies.gameObject.SetActive(true);
//             }
//         }
//
//         if (PlayerPrefs.HasKey("Heal"))
//         {
//             if (PlayerPrefs.GetInt("Heal") == 1)
//             {
//                 isHeal = true;
//             }
//         }
//
//         if (PlayerPrefs.HasKey("Dash"))
//         {
//             if (PlayerPrefs.GetInt("Dash") == 1)
//             {
//                 isDash = true;
//             }
//         }
//
//         if (PlayerPrefs.HasKey("FoxSaved"))
//         {
//             if (PlayerPrefs.GetInt("FoxSaved") == 1)
//             {
//                 isFoxSaved = true;
//                 seaWater.transform.DOLocalMove(new Vector3(89.502594f, -31f, -113.304504f),2f);
//             }
//         }
//         if (PlayerPrefs.HasKey("Colosseum"))
//         {
//             if (PlayerPrefs.GetInt("Colosseum") == 1)
//             {
//                 isColosseum = true;
//             }
//         }
//         if (PlayerPrefs.HasKey("Campfire"))
//         {
//             if (PlayerPrefs.GetInt("Campfire") == 1)
//             {
//                 isCampfire = true;
//             }
//         }
//
//         if (PlayerPrefs.HasKey("isDungeon"))
//         {
//             isDungeon = true;
//         }
//         tutorialName = tutorialSection + ".";
//         if (!tutorial)
//         {
//             if (tutorialSection == 0 && tutorialCounter == 0)
//             {
//                 EquipmentManager.instance.currentWeapon.GetComponent<MeshRenderer>().enabled = false;
//                 Player.instance._fixedJoystick.transform.GetChild(0).gameObject.SetActive(true);
//             }
//
//             UpdateGameState(GameState.Tutorial);
//             TutorialLoader.instance.Load(tutorialName + tutorialCounter);
//             TutorialEvents.OnTutorialComplete += TutorialChange;
//         }
//     }
//     private void TutorialChange()
//     {
//       
//         TutorialEvents.OnTutorialComplete -= TutorialChange;
//         CinematicCamDisable();
//         tutorialCounter++;
//         PlayerPrefs.SetInt("TutorialCounter", tutorialCounter);
//         PlayerPrefs.SetInt("TutorialSection", tutorialSection);
//
//         if (tutorialSection == 0 && tutorialCounter > 8)
//         {
//             if (tutorialCounter > 8)
//             {
//                 foxManager.FinishTutorial();
//                 FindObjectOfType<Player>().FinishTutorial();
//                 var foxgate = GameObject.FindWithTag("FoxGate");
//                 foxgate.GetComponent<Collider>().enabled = false;
//                 //EndOfTheCinematic();
//             }
//             //CinematicCamEnable(Player.instance.transform);
//             //Player.instance.FinishTutorial();
//         }
//         else
//         {
//             UpdateGameState(GameState.Tutorial);
//             CinematicCamDisable();
//         }
//
//         if (tutorialSection == 0 && tutorialCounter == 4)
//         {
//             Time.timeScale = 1f;
//         }
//
//         if (tutorialSection == 1 && tutorialCounter == 1)
//         {
//             tutorialEnemies.gameObject.SetActive(true);
//             baskan.GetComponent<QuestGiver>().StartDialogueWithPlayer();
//         }
//
//         if (tutorialSection == 1 && tutorialCounter == 3)
//         {
//             tutorialSection++;
//             PlayerPrefs.SetInt("TutorialSection", tutorialSection);
//             tutorial = true;
//             PlayerPrefs.SetString("Tutorial", "true");
//         }
//     }
//  public string TutorialLoad()
//     {
//         tutorialName = tutorialSection + ".";
//         gameState = GameState.Pause;
//         if (tutorialSection == 0 && tutorialCounter == 4)
//         {
//             FoxCamEnable();
//             var cage = tutoCage.GetComponent<TutoCage>();
//             for (int i = 0; i <cage.enemies.Length ; i++)
//             {
//                 cage.enemies[i].GetComponent<Waypoint_Indicator>().enabled = true;
//             }
//         }
//         else if (tutorialSection == 0 && tutorialCounter == 6)
//         {
//             CinematicCamEnable(tutoVaril.transform);
//         }
//         else if (tutorialSection == 0 && tutorialCounter ==8)
//         {
//             isFoxSaved = true;
//             PlayerPrefs.SetInt("FoxSaved", 1);
//         }
//
//         if (tutorialSection == 1)
//         {
//             if (tutorialCounter == 1)
//             {
//                 OpenTheVillageDoors();
//                 wallFires.gameObject.SetActive(false);
//                 CinematicCamEnable(villageEntryCollider.transform);
//             }
//             else if (tutorialCounter == 2)
//             {
//                 CinematicCamEnable(baskan.transform.GetChild(1).transform);
//             }
//             else if (tutorialCounter == 3)
//             {
//                 CinematicCamEnable(merchant.transform.GetChild(2).transform);
//             }
//             else if (tutorialCounter == 4)
//             {
//                 CinematicCamEnable(blacksmith.transform.GetChild(2).transform);
//             }
//             else if (tutorialCounter == 5)
//             {
//                 CinematicCamEnable(magician.transform.GetChild(1).transform);
//             }
//         }
//         // else if (tutorialSection == 0 && tutorialCounter == 3)
//         // {
//         //     CinematicCamEnable(tutorialWall.transform.GetChild(0).transform);
//         //     tutorialWall.transform.DOLocalMoveY(-1f, 5f).OnComplete((() => { CinematicCamDisable(); }));
//         // }
//
//
//         TutorialLoader.instance.Load(tutorialName + tutorialCounter);
//         TutorialEvents.OnTutorialComplete += TutorialChange;
//         return null;
//     }
//
//     // Start is called before the first frame update
//     void Start()
//     {
//         
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         
//     }
// }
