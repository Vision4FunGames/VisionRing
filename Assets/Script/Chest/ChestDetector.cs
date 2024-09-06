using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class ChestDetector : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public Equipment _equipment;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("ChestItem"))
        {
            _equipment = col.transform.GetChild(0).GetComponent<CaseCell>()._Equipment;
        }
    }
    
    public void CollectChestItem()
    {
        _equipment.showInInventory = true;
        EquipmentManager.instance.selectedChestItem = _equipment;
        Inventory.instance.Add(EquipmentManager.instance.selectedChestItem);
        Inventory.instance.SaveAllItems();
        var chest = FindObjectOfType<ChestManager>().gameObject;
        Destroy(chest);
        //GameManager.instance.playerVCam.Follow = Player.instance.transform;
        //GameManager.instance.playerVCam.LookAt = Player.instance.transform;
        UiManager.instance.GamePlayUI();
        
        // GameManager.Instance.cameraPlayer.GetComponent<CinemachineVirtualCamera>().Follow = FindObjectOfType<PlayerManager>().gameObject.transform;
    }
}
