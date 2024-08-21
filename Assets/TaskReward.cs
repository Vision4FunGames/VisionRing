using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TaskReward : MonoBehaviour
{
    public GameObject rewardPanel;
    public Image rewardImage;
    public Button collectBtn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        collectBtn.onClick.AddListener(GetReward);
    }

    public void GetReward()
    {
        Item item = FindObjectOfType<EquipmentManager>().dropUsableItems[0];
        Inventory.instance.usableItemsCount[0] += 1; 
        Inventory.instance.SaveAllItems();
        rewardPanel.transform.DOScale(Vector3.zero, .5f);
    }
}
