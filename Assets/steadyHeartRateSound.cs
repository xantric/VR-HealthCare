using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steadyHeartRateSound : MonoBehaviour
{
    public AudioSource heartRateSound;
    public AudioClip heartRateClip;
    public bool isPlaying = false;
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

    void Update()
    {
        if(isPlaying)
        {
            heartRateSound.loop = true;
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
