using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GecıtController : MonoBehaviour
{
    public bool isOpen;
    public float timer;

    public BoxCollider _boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        _boxCollider = GetComponent<BoxCollider>();
        timer = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            timer -= Time.deltaTime;
            if (timer  <= 0)
            {
                isOpen = false;
                timer = 3f;
                GecitClose();
            }
        }
        
    }

    public void GecitClose()
    {
        _boxCollider.enabled = true;
    }

    public void GecitOpen()
    {
        Debug.Log("Open");
        isOpen = true;
        _boxCollider.enabled = false;
    }
    
}
