using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    
    #region Singleton
    public static ShopUI instance;
    private string type = "All";
    void Awake ()
    {
        instance = this;
    }
    #endregion
    
    public GameObject shopUI;	// The entire UI
    public Transform itemsParent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
