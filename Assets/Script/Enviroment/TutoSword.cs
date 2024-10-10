using System;
using DG.Tweening;
using UnityEngine;

public class TutoSword : MonoBehaviour
{
    public GameObject hand;
    public Vector3 offset;
    private void Start()
    {
        Invoke("CloseSwords", .5f);
    }

    public void CloseSwords()
    {
        EquipmentManager.instance.currentWeapon.GetComponent<MeshRenderer>().enabled = false;
        UiManager.instance.attackJoystick.gameObject.SetActive(false);
        //HandScaleAnimation();
    }

    private void Update()
    {
        //HandAnimation();
    }

    public void HandAnimation()
    {
        if (Camera.main != null)
        {
            Vector3 goldpos = Camera.main.WorldToScreenPoint(this.transform.position);
            hand.transform.position = goldpos + offset;
        }
    }
    public void HandScaleAnimation()
    {
        hand.transform.DOMove(new Vector3(1f, 1f, 1f), 1f).OnComplete((() =>
        {
            hand.transform.DOScale(new Vector3(.5f, .5f, .5f), 1f).OnComplete((() => HandScaleAnimation()));
        }));
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