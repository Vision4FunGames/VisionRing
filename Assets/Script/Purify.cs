using System;
using UnityEngine;

public class Purify : MonoBehaviour
{
    public GameObject[] purifyObject;

    private int objCount;
    private int currentObj;

    private void Start()
    {
        objCount = transform.childCount;
        if (PlayerPrefs.HasKey("Purify"))
            gameObject.SetActive(false);
        else
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).GetComponent<Collider>().enabled = true;
                transform.GetChild(i).GetComponent<Outline>().enabled = true;
            }
        }
    }

    public void DestroyObj()
    {
        currentObj++;
        if (objCount == currentObj)
        {
           PlayerPrefs.SetInt("Purify",1);
           GetComponent<TaskPrefab>().isCompleted = true;
           Destroy(gameObject,1);
        }
    }
}