using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    //Mute
    GameObject Mute;
    Toggle toggle;

    //Volume
    GameObject Volume;
    Slider slider;

    void Start()
    {                
        Mute = GameObject.Find("Mute");
        toggle = Mute.gameObject.GetComponent<Toggle>();

        Volume = GameObject.Find("Volume");
        slider = Volume.gameObject.GetComponent<Slider>();
                        
        if (PlayerPrefs.HasKey("VolumeAudio")) slider.value = PlayerPrefs.GetFloat("VolumeAudio");
        else slider.value = 0;

        if (PlayerPrefs.HasKey("MuteAudio"))
        {
            if (PlayerPrefs.GetInt("MuteAudio") == 0) toggle.isOn = false;
            else toggle.isOn = true;
        } else toggle.isOn = false;
    }

    public void MuteAudio()
    {
        PlayerPrefs.SetInt("MuteAudio", (toggle.isOn ? 1 : 0));
    }

    public void VolumeAudio()
    {
        PlayerPrefs.SetFloat("VolumeAudio", slider.value);
    }
}
