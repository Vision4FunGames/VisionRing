using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    
    #region Singleton
    public static Shop instance;
    private string type = "All";
    void Awake ()
    {
        instance = this;
    }
    #endregion
    public delegate void OnItemChanged();

    public OnItemChanged onItemChangedCallback;
    public int space = 10;

    public List<Item> shopItems = new List<Item>();
    public GameObject shopItem;

    private ShopUI shopUI;
    int i;
    void Start()
    {
        shopUI = ShopUI.instance;
        
        for ( i=0; i < 3; i++)
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
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();

    }

}
