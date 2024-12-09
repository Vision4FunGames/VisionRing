using System;
using DG.Tweening;
using UnityEngine;

public class InventoryTask : MonoBehaviour
{
    public GameObject mask1, mask2;
    public GameObject softInventoryMask;
    
    private void OnEnable()
    {
        softInventoryMask.GetComponent<RectTransform>().position =
            UiManager.instance.inventoryBtn.GetComponent<RectTransform>().position;
        UiManager.instance.focusPanel.SetActive(true);
        //Item item = FindObjectOfType<EquipmentManager>().dropUsableItems[0];
        Inventory.instance.usableItemsCount[0] += 1;
        //Inventory.instance.SaveAllItems();
        FindObjectOfType<UiManager>().isTaskInventory = true;
    }

    private void OnDisable()
    {
        
    }

    public void OpenInventory()
    {
        mask1.SetActive(false);
        mask2.SetActive(true);
    }

    public void UseItem()
    {
        GetComponent<TaskPrefab>().isCompleted = true;
        transform.parent.DOScale(Vector3.zero, 1);
        Destroy(transform.gameObject, 1f);
    }
}
