using System;
using UnityEngine;
using DG.Tweening;
using NaughtyAttributes;
using Unity.VisualScripting;
using Random = UnityEngine.Random;

public class CollectItemAnimation : MonoBehaviour
{
    Canvas canvasMain;

    private void Start()
    {
        canvasMain = GameObject.FindGameObjectWithTag("mainCanvas").GetComponent<Canvas>();
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pouch"))
        {
            UiManager.instance.selectedPouch = other.gameObject.transform.gameObject;
            var panel = other.gameObject.GetComponent<PouchManager>().current.transform.GetChild(0).transform;
            var items = panel.GetComponentsInChildren<InventorySlot>();
            for (int i = 0; i < items.Length; i++)
            {
                items[i].UseItem();
                Debug.Log("Toplandi :" + i);
            }
        }
    }

    [ButtonAttribute("CollectItem")]
    public void CollectItem()
    {
        for (int i = 0; i < 20; i++)
        {
            int rand = Random.Range(0, 20);
            if (rand < 10)
            {
                GameObject current = Instantiate(Resources.Load<GameObject>("GoldImage"), canvasMain.transform);
                Vector3 goldpos = Camera.main.WorldToScreenPoint(this.transform.position);
                current.transform.position = goldpos+new Vector3(Random.Range(10f,100f),Random.Range(10f,100f),Random.Range(10f,100f));
                current.transform.DOLocalMove(canvasMain.transform.GetChild(0).GetChild(8).transform.localPosition, 1f).SetDelay(Random.Range(0f,1f)).OnComplete(() =>
                {
                    Destroy(current);
                });
            }
            else
            {
                GameObject current = Instantiate(Resources.Load<GameObject>("GoldImage 1"), canvasMain.transform);
                Vector3 goldpos = Camera.main.WorldToScreenPoint(this.transform.position);
                current.transform.position = goldpos+new Vector3(Random.Range(0f,10f),Random.Range(0f,10f),Random.Range(0f,10f));
                current.transform.DOLocalMove(canvasMain.transform.GetChild(0).GetChild(8).transform.localPosition, 1f).SetDelay(Random.Range(0f,1f)).OnComplete(() =>
                {
                    Destroy(current);
                });
            }
          
        }
    }
}