using System;
using DG.Tweening;
using UnityEngine;

public class TutoSword : MonoBehaviour
{
    private void Start()
    {
        Invoke("CloseSwords", .5f);
    }

    public void CloseSwords()
    {
        EquipmentManager.instance.currentWeapon.GetComponent<MeshRenderer>().enabled = false;
        UiManager.instance.attackJoystick.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EquipmentManager.instance.currentWeapon.GetComponent<MeshRenderer>().enabled = true;
            UiManager.instance.attackJoystick.gameObject.SetActive(true);
            GetComponentInParent<TaskPrefab>().isCompleted = true;
            transform.parent.DOScale(Vector3.zero, 1);
            Destroy(transform.parent.gameObject, 1f);
        }
    }
}