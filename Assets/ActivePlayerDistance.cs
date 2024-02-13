using UnityEngine;

public class ActivePlayerDistance : MonoBehaviour
{
    public Player player;
    public ActiveObjects[] ActiveObjectsArray;


    public float refreshTime, activeDistance;
    private float currentTime;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > refreshTime)
        {
            currentTime = 0;
            ObjectActivator();
        }
    }

    public void ObjectActivator()
    {
        for (int i = 0; i < ActiveObjectsArray.Length; i++)
        {
            for (int j = 0; j < ActiveObjectsArray[i].activeObjectsArray.Length; j++)
            {
                if (Vector3.Distance(player.transform.position,
                        ActiveObjectsArray[i].activeObjectsArray[j].transform.position) < activeDistance)
                {
                    if (!ActiveObjectsArray[i].activeObjectsArray[j].activeSelf)
                        ActiveObjectsArray[i].activeObjectsArray[j].SetActive(true);
                }
                else
                {
                    if (ActiveObjectsArray[i].activeObjectsArray[j].activeSelf)
                    {
                        if (!ActiveObjectsArray[i].activeObjectsArray[j].GetComponent<Waypoint_Indicator>())
                            ActiveObjectsArray[i].activeObjectsArray[j].SetActive(false);
                        else if (ActiveObjectsArray[i].activeObjectsArray[j]?.GetComponent<Waypoint_Indicator>()
                                     .enabled == false)
                        {
                            ActiveObjectsArray[i].activeObjectsArray[j].SetActive(false);
                        }
                    }
                }
            }
        }
    }
}

[System.Serializable]
public class ActiveObjects
{
    public GameObject[] activeObjectsArray;
}