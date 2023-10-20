using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void OnItemChanged();

    public OnItemChanged onItemChangedCallback;
    public int space = 10;

    public List<Item> shopItems = new List<Item>();
    public GameObject shopItem;

    private ShopUI shopUI;
    void Start()
    {
        shopUI = ShopUI.instance;
        for (int i = 0; i < 3; i++)
        {
            AddItem();
        }
    }

    // Update is called once per frame 
    void Update()
    {

    }

    public void AddItem() 
    {
        var currentItem = Instantiate(shopItem);
        currentItem.transform.parent = shopUI.itemsParent.transform;
        currentItem.transform.localScale = new Vector3(1, 1, 1);
    }

}
