using UnityEngine;

public class AchievementRouting : MonoBehaviour
{
    public static AchievementRouting instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void GoDungeon()
    {
        Debug.Log("GoDungeon");
    }
    public void ShowAds()
    {
        Debug.Log("ShowAds");
    }

}
