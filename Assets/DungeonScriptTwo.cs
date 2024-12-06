using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonScriptTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Inventory.instance.usableItemsCount[1] += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
