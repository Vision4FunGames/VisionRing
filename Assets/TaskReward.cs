using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaskReward : MonoBehaviour
{
    public GameObject rewardPanel;
    public Image rewardImage;
    public Button collectBtn;
    public bool tutorialComplete;

    public TextMeshProUGUI rewardTxt;
    // Start is called before the first frame update
    void Start()
    {
        //Inventory.instance.usableItemsCount[0] += 1;
        //Inventory.instance.usableItemsCount[1] += 1;
        Inventory.instance.SaveAllItems();
        collectBtn.onClick.AddListener(GetReward);
    }

    public void GetReward()
    {
        //Item item = FindObjectOfType<EquipmentManager>().dropUsableItems[0];
        //Inventory.instance.usableItemsCount[0] += 1;
        //Inventory.instance.SaveAllItems();
        rewardPanel.transform.DOScale(Vector3.zero, .5f);
        Destroy(FindObjectOfType<TaskPrefab>().gameObject, 2);
        FindObjectOfType<TaskPrefab>().isCompleted = true;
        rewardTxt.text = " ";
        if (!tutorialComplete)
            FindObjectOfType<UiManager>().isTaskInventory = true;
    }
}