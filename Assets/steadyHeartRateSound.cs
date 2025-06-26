using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steadyHeartRateSound : MonoBehaviour
{
    public AudioSource heartRateSound;
    public AudioClip heartRateClip;
    public AudioClip deadClip;
    public bool isPlaying = false;
    public TextTimerController textTimerController; // Reference to the TextTimerController script
    private float deadTime;
    bool isdead = false;
    public void StartHeartRateSound()
    {
        isPlaying = true;
        if (!heartRateSound.isPlaying)
        {
            heartRateSound.loop = true;
            heartRateSound.clip = heartRateClip;
            heartRateSound.Play();
        }
    }

    public void StopHeartRateSound()
    {
        isPlaying = false;
        if (heartRateSound.isPlaying)
        {
            heartRateSound.Stop();
        }
    }
    void Start()
    {
        deadTime = deadClip.length;
    }
    void Update()
    {
        if(isdead) return; // If already dead, do not update sound
        if(isPlaying)
        {
            heartRateSound.loop = true;
            if(textTimerController.timer >= textTimerController.DeathTime - deadTime)
            {
                heartRateSound.clip = deadClip;
                heartRateSound.Stop();
                heartRateSound.loop = false;
                isdead = true;
                heartRateSound.PlayOneShot(deadClip);
            }
            else
                heartRateSound.clip = heartRateClip;

            if (!heartRateSound.isPlaying)
            {
                heartRateSound.Play();
            }
        }
        else
        {
            if (heartRateSound.isPlaying)
            {
                heartRateSound.Stop();
            }
        }
    }
}
