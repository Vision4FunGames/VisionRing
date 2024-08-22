using System;
using DG.Tweening;
using UnityEngine;

public class InventoryTask : MonoBehaviour
{
    public GameObject mask1, mask2;
    
    private void OnEnable()
    {
           
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
        Destroy(transform.parent.gameObject, 1f);
    }
}
