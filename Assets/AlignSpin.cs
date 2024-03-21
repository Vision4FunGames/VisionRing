using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class AlignSpin : MonoBehaviour
{
    public bool creat;
    private RewardManager _rewardManager;
    public Sprite[] spinObj;
    public GameObject center;
    public List<GameObject> spinPool;

    private void Awake()
    {
        _rewardManager = FindObjectOfType<RewardManager>();
    }

    public void InstantiateInCircle(Vector3 location, int howMany, float radius, float yPosition)
    {
        float angleSection = Mathf.PI * 2f / howMany;
        for (int i = 0; i < howMany; i++)
        {
            float angle = i * angleSection;
            Vector3 newPos = location + new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * radius;
            newPos.z = yPosition;
            int rand = Random.Range(0, spinObj.Length);
            GameObject objToSpawn = CreateObj(i, rand);
            objToSpawn.transform.localPosition = newPos;
            objToSpawn.transform.rotation = Quaternion.Euler(0, 0, 90 + (i * (360 / howMany)));
            spinPool.Add(objToSpawn);
        }

        for (int i = 0; i < spinPool.Count; i++)
        {
            GameObject objToSpawn = new GameObject("spin" + i);
            objToSpawn.AddComponent<RectTransform>();
            objToSpawn.AddComponent<Image>();
            objToSpawn.transform.SetParent(spinPool[i].transform);
            spinPool[i].transform.GetChild(0).GetComponent<Image>().sprite = _rewardManager.upgradeItems[Random.Range(0, 2)].icon;
        }
    }

    public GameObject CreateObj(int index, int rand)
    {
        GameObject objToSpawn = new GameObject("spin" + index);
        objToSpawn.AddComponent<RectTransform>();
        objToSpawn.AddComponent<Image>();
        objToSpawn.transform.SetParent(transform);
        objToSpawn.GetComponent<Image>().sprite = spinObj[rand];
        objToSpawn.transform.localScale = new Vector3(1.8f, 2.4f, 1);
        return objToSpawn;
    }

    public void InstantiateInCircle(Vector3 location, int howMany, float radius)
    {
        this.InstantiateInCircle(location, howMany, radius, location.y);
    }


    // client EXAMPLE
    private void Start()
    {
        if (creat)
            this.InstantiateInCircle(new Vector3(0, 0, 0), 12, 280, 0);
        else
        {
            for (int i = 0; i < spinObj.Length; i++)
            {
                spinPool[i].GetComponent<Image>().sprite = spinObj[Random.Range(0, spinObj.Length)];
            }
        }
    }
}