using System.Collections.Generic;
using System.Xml.Schema;
using PixelCrushers.QuestMachine;
using TMPro;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class PouchManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pouchCanvas;
    private Player player;
    Canvas canvasMain;
    public GameObject current;
    public float buttonRange;
    public Vector3 offsett;
    public GameObject itemSlot;
    private EquipmentManager equipmentManager;
    public GameObject itemTextImage;
    public GameObject pouchPanel;
    public GameObject inventorySlot, descriptionImage;
    private List<int> itemIndexList;
    public StoneChance stoneChance;

    private void Start()
    {
        player = Player.instance;
        equipmentManager = EquipmentManager.instance;
        canvasMain = GameObject.FindGameObjectWithTag("mainCanvas").GetComponentInChildren<Canvas>();
        itemIndexList = new List<int>();
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < buttonRange)
        {
            SpawnButton();
        }
        else
        {
            DestroyButton();
        }
    }

    public void DestroyButton()
    {
        if (current != null)
        {
            current.gameObject.SetActive(false);
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    // public void CreateItem(int count)
    // {
    //     // for (int i = 0; i < count; i++)
    //     // {
    //     //     var pouchitempanel = Instantiate(pouchPanel, current.transform.GetChild(0));
    //     //     pouchitempanel.transform.SetAsFirstSibling();
    //     //     var item1Slot = Instantiate(itemSlot, current.transform.GetChild(0).transform.GetChild(0).transform);
    //     //     var rectTransform = item1Slot.GetComponent<RectTransform>();
    //     //     item1Slot.GetComponent<RectTransform>().SetHeight(150);
    //     //     item1Slot.GetComponent<RectTransform>().SetWidth(150);
    //     //     rectTransform.anchorMin = new Vector2(0, .5f);
    //     //     rectTransform.anchorMax = new Vector2(0, .5f);
    //     //     rectTransform.pivot = new Vector2(0, .5f);
    //     //     int chest = UnityEngine.Random.Range(0, 2);
    //     //     var item1 = Instantiate(_ıtemManager.chestItems[chest].gameObject,item1Slot.transform.GetChild(0).transform);
    //     //     item1.GetComponent<DraggableItem>().isPouchItem = true;
    //     //     var item1Text = Instantiate(itemTextImage, current.transform.GetChild(0).transform.GetChild(0).transform);
    //     // }
    //     //
    //     // current.gameObject.SetActive(false);
    // }
    public bool Scripted = false;
    public int ScriptedItemId = 0;
    public string message = "";

    public void CreateScriptedItem()
    {
        var pouchPanel = Instantiate(this.pouchPanel, current.transform.GetChild(0));
        pouchPanel.transform.SetAsFirstSibling();
        var item1 = Instantiate(inventorySlot, current.transform.GetChild(0).transform.GetChild(0).transform);
        var rectTransform = item1.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(150, 150);
        rectTransform.anchorMin = new Vector2(0, .5f);
        rectTransform.anchorMax = new Vector2(0, .5f);
        rectTransform.pivot = new Vector2(0, .5f);
        item1.transform.localPosition = new Vector3(0, 0, 0);
        int chest = ScriptedItemId;
        item1.GetComponent<InventorySlot>().AddItem(equipmentManager.chestItems[chest]);
        item1.GetComponent<InventorySlot>()._inventoryType = InventoryType.Collect;

        current.gameObject.SetActive(false);
    }

    public void CreateItem(int count)
    {
        if (Scripted)
        {
            CreateScriptedItem();
            return;
        }

        itemIndexList.Clear();
        int luck = Random.Range(0, 100);

        for (int i = 0; i < count; i++)
        {
            var pouchPanel = Instantiate(this.pouchPanel, current.transform.GetChild(0));
            pouchPanel.transform.SetAsFirstSibling();
            var item1 = Instantiate(inventorySlot, current.transform.GetChild(0).transform.GetChild(0).transform);
            var rectTransform = item1.GetComponent<RectTransform>();
            rectTransform.sizeDelta = new Vector2(150, 150);
            rectTransform.anchorMin = new Vector2(0, .5f);
            rectTransform.anchorMax = new Vector2(0, .5f);
            rectTransform.pivot = new Vector2(0, .5f);
            item1.transform.localPosition = new Vector3(0, 0, 0);
            int chest = UnityEngine.Random.Range(0, equipmentManager.chestItems.Length);


            if (itemIndexList.Count == 0)
            {
                itemIndexList.Add(chest);
            }
            else
            {
                if (!itemIndexList.Contains(chest))
                {
                    itemIndexList.Add(chest);
                }
                else
                {
                    do
                    {
                        chest = Random.Range(0, equipmentManager.chestItems.Length);
                    } while (itemIndexList[0] == chest);

                    itemIndexList.Add(chest);
                }
            }

            if (luck < 5)
            {
                item1.GetComponent<InventorySlot>().AddItem(equipmentManager.dropUsableItems[0]);
                item1.GetComponent<InventorySlot>().countText.text = "1";
                item1.GetComponent<InventorySlot>()._inventoryType = InventoryType.Collect;
                current.gameObject.SetActive(false);
            }
            else
            {
                item1.GetComponent<InventorySlot>().AddItem(equipmentManager.chestItems[chest]);
                item1.GetComponent<InventorySlot>().countText.text = Random.Range(1, 3).ToString();
                item1.GetComponent<InventorySlot>()._inventoryType = InventoryType.Collect;
            }

            current.gameObject.SetActive(false);
            DropStone(pouchPanel, stoneChance);
        }
    }

    private void SpawnButton()
    {
        if (current == null)
        {
            current = Instantiate(Resources.Load<GameObject>("PouchPopUp"), canvasMain.transform);
            //Buraya objeyi random ekleyecegiz...
            // ar item1 = current.transform.GetComponentInChildren<>()
            // Vector3 buttonppos = Camera.main.WorldToScreenPoint(this.transform.position);
            // current.transform.position = buttonppos + offsett;
            int rndItemCount = UnityEngine.Random.Range(0, 100);
            if (rndItemCount <= 00)
            {
                rndItemCount = 1;
            }
            else
            {
                rndItemCount = 2;
            }

            if (rndItemCount == 1)
            {
                CreateItem(1);
            }
            else
            {
                CreateItem(2);
            }
            //item1Text.GetComponent<TextMeshPro>().text = 
            // item1Slot.GetComponent<RectTransform>().SetPivotAndAnchors();
        }

        // else
        // {
        //     current.gameObject.SetActive(true);
        // }
        if (current.transform.GetChild(0).childCount == 0)
        {
            Destroy(current.gameObject);
            Destroy(transform.parent.gameObject);
        }
    }

    public void OpenPouchPanel()
    {
        current.gameObject.SetActive(true);
    }

    public void PouchInsideControl()
    {
        var slotCount = current.transform.GetChild(0).transform.childCount;
        if (slotCount <= 1)
        {
            QuestMachineMessages.SendCompositeMessage(this, message);
            Destroy(transform.parent.gameObject);
            Destroy(current.gameObject);
        }
    }

    public void DropStone(GameObject panel, StoneChance stoneChance)
    {
        var item1 = Instantiate(inventorySlot, current.transform.GetChild(0).transform.GetChild(0).transform);
        var rectTransform = item1.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(150, 150);
        rectTransform.anchorMin = new Vector2(0, .5f);
        rectTransform.anchorMax = new Vector2(0, .5f);
        rectTransform.pivot = new Vector2(0, .5f);
        item1.transform.localPosition = new Vector3(0, 0, 0);
        int chest = ScriptedItemId;
        Debug.Log(stoneChance);
        if (stoneChance == StoneChance.Darkstone)
        {
            //item1.GetComponent<InventorySlot>().AddItem(equipmentManager.chestItems[2]);
            EconomyManager.instance.SetStoneCount("DarkStone", EconomyManager.instance.GetStoneCount("DarkStone")+1);
        }
        else if (stoneChance == StoneChance.LightStone)
        {
            // item1.GetComponent<InventorySlot>().AddItem(equipmentManager.chestItems[3]);   
            EconomyManager.instance.SetStoneCount("LightStone",EconomyManager.instance.GetStoneCount("LightStone")+1);
        }
        else if (stoneChance == StoneChance.LifeStone)
        {
            //item1.GetComponent<InventorySlot>().AddItem(equipmentManager.chestItems[4]);
            EconomyManager.instance.SetStoneCount("LifeStone", EconomyManager.instance.GetStoneCount("LifeStone")+1);
        }

        item1.GetComponent<InventorySlot>()._inventoryType = InventoryType.Collect;
    }

    public enum StoneChance
    {
        Darkstone,
        LightStone,
        LifeStone
    }
}