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
    }

    public void StartPurify()
    {
        for (int i = 0; i < purifyObject.Length; i++)
        {
            if (purifyObject[i].GetComponent<GrowTween>())
            {
                purifyObject[i].GetComponent<GrowTween>().StartGrowPurify();
            }
            else
            {
                purifyObject[i].GetComponent<Collider>().enabled = true;
                purifyObject[i].GetComponent<Outline>().enabled = true;
                purifyObject[i].GetComponent<Waypoint_Indicator>().enabled = true;
            }
               
        }
    }

    public void DestroyObj()
    {
        currentObj++;
        if (objCount == currentObj)
        {
            PlayerPrefs.SetInt("Purify", 1);
            GetComponentInParent<TaskPrefab>().isCompleted = true;
            Destroy(transform.parent.gameObject, 1);
        }
    }
}