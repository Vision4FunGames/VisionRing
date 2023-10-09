using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [Header("Main Menu")] 
    public Slider mainMenu; 
    public AudioSource mainMusicSource;

    private void Update()
    {
        mainMusicSource.volume = mainMenu.value;
    }
}