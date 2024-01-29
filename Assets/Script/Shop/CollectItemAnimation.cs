using System;
using UnityEngine;
using DG.Tweening;
using NaughtyAttributes;
using Unity.VisualScripting;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CollectItemAnimation : MonoBehaviour
{
    Canvas canvasMain;
    private void Start()
    {
        canvasMain = GameObject.FindGameObjectWithTag("GamePlayCanvas").GetComponentInChildren<Canvas>();
      
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
            }
            
        }
    }

    [ButtonAttribute("CollectItem")]
    public void CollectItem(Sprite sprite)
    {
        
        for (int i = 0; i < 20; i++)
        {
                
                GameObject current = Instantiate(Resources.Load<GameObject>("GoldImage"), canvasMain.transform);
                current.GetComponent<Image>().sprite = sprite;
                Vector3 goldpos = Camera.main.WorldToScreenPoint(this.transform.position);
                current.transform.position = goldpos+new Vector3(Random.Range(10f,100f),Random.Range(10f,100f),Random.Range(10f,100f));
                current.transform.DOLocalMove(canvasMain.transform.GetChild(0).GetChild(8).transform.localPosition, 1f).SetDelay(Random.Range(0f,1f)).OnComplete(() =>
                {
                    Destroy(current);
                });
            
            
        }
    } 
}
