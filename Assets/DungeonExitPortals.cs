using UnityEngine;

public class DungeonExitPortals : MonoBehaviour
{
    public GameObject exitPortal;
    
    public int taskCount;
    private int currentTaskCount;

    public void dungeonTaskCheck()
    {
        currentTaskCount++;
        if (currentTaskCount >= taskCount)
        {
            DailyQuestManager.Instance.AddQuestEvent(DailyQuestType.ClearDungeon,1);
            exitPortal.gameObject.SetActive(true);
            exitPortal.GetComponent<Waypoint_Indicator>().enabled = true;
            exitPortal.GetComponent<Collider>().enabled = true;
            exitPortal.GetComponent<TeleportScene>().task = true;
        }
    }
}
