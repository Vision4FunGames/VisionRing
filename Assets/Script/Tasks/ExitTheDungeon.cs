using UnityEngine;

public class ExitTheDungeon : MonoBehaviour
{
    private void OnEnable()
    {
        FindObjectOfType<DungeonExitPortals>().dungeonTaskCheck();
    }
    
}
