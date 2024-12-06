using UnityEngine;

public class DungeonExitPortals : MonoBehaviour
{
    private TeleportManager _teleportManager;
    public GameObject exitPortal;
    
    public int taskCount;
    private int currentTaskCount;

    public void dungeonTaskCheck()
    {
        currentTaskCount++;
        if (currentTaskCount >= taskCount)
        {
            _teleportManager = FindObjectOfType<TeleportManager>();
            DailyQuestManager.Instance.AddQuestEvent(DailyQuestType.ClearDungeon,1);
            _teleportManager.TeleportCloseAll();
            exitPortal.gameObject.SetActive(true);
            exitPortal.GetComponent<Waypoint_Indicator>().enabled = true;
            exitPortal.GetComponent<Collider>().enabled = true;
            exitPortal.GetComponent<TeleportScene>().task = true;
        }
    }
}
