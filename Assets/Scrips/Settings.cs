using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
                
        if (PlayerPrefs.GetInt("MuteAudio") == 0) audioSource.mute = false;
        else audioSource.mute = true;
               

        audioSource.volume = PlayerPrefs.GetFloat("VolumeAudio");

        if (PlayerPrefs.HasKey("TimeSong"))
        {
            if (PlayerPrefs.GetInt("ResetAudio") == 0) audioSource.time = PlayerPrefs.GetFloat("TimeSong");
            else audioSource.Play();
        }
        else
        {
            audioSource.time = 0;
        }
    }

}
