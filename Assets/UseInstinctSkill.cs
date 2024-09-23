using UnityEngine;

public class UseInstinctSkill : MonoBehaviour
{
    public GameObject panel;
    
    
    private void OnEnable()
    {
        UiManager.instance.sonarBtn.gameObject.SetActive(true);
        FindObjectOfType<PlayerManager>().SolarSystem.solarSystemtutorial = true;
    }
}
