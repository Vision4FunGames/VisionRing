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
            purifyObject[i].GetComponent<Collider>().enabled = true;
            purifyObject[i].GetComponent<Outline>().enabled = true;
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