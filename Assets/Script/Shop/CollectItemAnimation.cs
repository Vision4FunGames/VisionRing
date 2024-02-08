using System;
using System.Collections;
using DamageNumbersPro;
using UnityEngine;
using DG.Tweening;
using NaughtyAttributes;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using Random = UnityEngine.Random;
public class CollectItemAnimation : MonoBehaviour
{
    Canvas canvasMain;
    private GameObject panel;
    
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
    public void CollectItem(String itemName,int count)
    {
       panel = UiManager.instance.itemTextPanel.gameObject;
        for (int i = 0; i < panel.transform.childCount; i++)
        {
            if (!panel.transform.GetChild(i).gameObject.activeSelf)
            {
                panel.transform.GetChild(i).gameObject.SetActive(true);
                panel.transform.GetChild(i).GetComponent<TextMeshProUGUI>().text = itemName + " x"+ count;
                StartCoroutine(CloseText());
                return;
                
            }
        }
       
        // newDamageNumber.followedTarget = transform;
        // for (int i = 0; i < 20; i++)
        // {
        //     GameObject current = Instantiate(Resources.Load<GameObject>("GoldImage"), canvasMain.transform);
        //         current.GetComponent<Image>().sprite = sprite;
        //         Vector3 goldpos = Camera.main.WorldToScreenPoint(this.transform.position);
        //         current.transform.position = goldpos+new Vector3(Random.Range(10f,100f),Random.Range(10f,100f),Random.Range(10f,100f));
        //         current.transform.DOLocalMove(canvasMain.transform.GetChild(0).GetChild(8).transform.localPosition, 1f).SetDelay(Random.Range(0f,1f)).OnComplete(() =>
        //         {
        //             Destroy(current);
        //         });
        // }
    }

    IEnumerator CloseText()
    {
        yield return new WaitForSeconds(3f);
        if (panel != null)
        {
            for (int i = 0; i < panel.transform.childCount ; i++)
            {
                panel.transform.GetChild(i).gameObject.SetActive(false);
            } 
        }
       
    }
}
