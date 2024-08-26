using System;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;


public class PuzzleChest : MonoBehaviour
{
    public float dropObjectCount;
    public Object[] chestItem;
    bool chestOpen;

    private void Awake()
    {
        chestItem = Resources.LoadAll("PuzzleChestItem", typeof(GameObject));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!chestOpen)
            {
                chestOpen = true;
                GetComponent<Animator>().SetTrigger("Open");
                Invoke("ChestOpen", 1f);
            }
        }

        if (other.CompareTag("Solar"))
        {
            GetComponent<Waypoint_Indicator>().enabled = true;
        }
    }

    public void ChestOpen()
    {
        for (int i = 0; i < dropObjectCount; i++)
        {
            GameObject currentOBject = (GameObject)Instantiate(chestItem[Random.Range(0, chestItem.Length)],
                transform.position + new Vector3(0, 1, 0), Quaternion.identity, transform);
            currentOBject.GetComponent<ChestDropObj>().Jumping();
        }
    }
}