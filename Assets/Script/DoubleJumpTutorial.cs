using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpTutorial : MonoBehaviour
{
    public GameObject mask;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Player>().isDoubleJumpTutorial = true;
        Invoke("MaskClose",3);
    }

    public void CompleteTask()
    {
        GetComponent<TaskPrefab>().isCompleted = true;
        Destroy(gameObject,.5f);
    }
    public void MaskClose()
    {
        mask.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
