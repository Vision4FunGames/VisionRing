using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testsc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UiManager.instance.JumpBtn.onClick.AddListener(testtt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void testtt()
    {
        Debug.Log("aaa");
    }
}
