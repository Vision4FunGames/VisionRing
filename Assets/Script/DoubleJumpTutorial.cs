using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Player>().isDoubleJumpTutorial = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
