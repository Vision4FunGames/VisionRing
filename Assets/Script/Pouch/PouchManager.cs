
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
    public GameObject inventorySlot,descriptionImage;
    public Canvas worldCanvas;
    public TextMeshProUGUI itemWorldText;
    private void Start()
    {
        player = Player.instance;
        equipmentManager = EquipmentManager.instance;
        worldCanvas = GetComponentInChildren<Canvas>();
        canvasMain = GameObject.FindGameObjectWithTag("mainCanvas").GetComponentInChildren<Canvas>();
        
        
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
            item1.GetComponent<InventorySlot>().AddItem(equipmentManager.chestItems[chest]);
            item1.GetComponent<InventorySlot>()._inventoryType = InventoryType.Collect;
            current.gameObject.SetActive(false);
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
           if (rndItemCount <= 50)
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
        Debug.Log("SlotCount : " + slotCount);
        if (slotCount<=1)
        {
            QuestMachineMessages.SendCompositeMessage(this, message);
            Destroy(transform.parent.gameObject);
            Destroy(current.gameObject);
        }
    }
}
