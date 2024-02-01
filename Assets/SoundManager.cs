using System;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider mainMusicVolume;
    public Slider sfxVolume;

    [Header("Main Menu")] public AudioSource mainMusicSource;

    public void Start()
    {
        mainMusicSource = GetComponent<AudioSource>();
        mainMusicVolume.onValueChanged.AddListener(delegate { MainMusicVolume(); });
        sfxVolume.onValueChanged.AddListener(delegate { SfxVolume(); });
        MainMusicVolume();
        SfxVolume();
    }

    public void MainMusicVolume()
    {
        mainMusicSource.volume = mainMusicVolume.value;
    }

    public void SfxVolume()
    {
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();

        for (int i = 0; i < audioSources.Length; i++)
        {
            if (!audioSources[i].GetComponent<GameManager>())
                audioSources[i].volume = sfxVolume.value;
        }
    }
}