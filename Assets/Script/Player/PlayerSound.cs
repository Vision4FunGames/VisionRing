using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public AudioClip[] swordHitSound;
    public AudioClip[] hitMeSound;
    public AudioClip footStep;
    public AudioClip swim;
    public AudioSource audioSource;
    public AudioSource hitSource;
    public AudioClip jump;  
    public AudioSource swordAudioSource;

    public AudioClip ringSound;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


}
