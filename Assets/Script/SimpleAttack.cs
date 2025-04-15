using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAttack : MonoBehaviour
{
    // Start is called before the first frame update
    private Horse _horse;
    public GameObject mask;
    void Start()
    {
        FindObjectOfType<PlayerAttack>().isSimpleAttackBool = true;
        Invoke("maskClose",3f);
        _horse = FindObjectOfType<Horse>();
        if (_horse.playerAttach)
        {
            _horse.CallHorse();
        }
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
