using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAttack : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject mask;
    void Start()
    {
        FindObjectOfType<PlayerAttack>().isSimpleAttackBool = true;
        Invoke("maskClose",3f);
    }

    public void maskClose()
    {
        mask.SetActive(false);
    }

    public void CompleteTask()
    {
        GetComponent<TaskPrefab>().isCompleted = true;
        Destroy(gameObject,.5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
