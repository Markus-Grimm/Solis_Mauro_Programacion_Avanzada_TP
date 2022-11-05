using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    //Mute
    GameObject Mute;
    Toggle toggleMute;

    //Mute
    GameObject Reset;
    Toggle toggleReset;

    //Volume
    GameObject Volume;
    Slider slider;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        Mute = GameObject.Find("Mute");
        toggleMute = Mute.gameObject.GetComponent<Toggle>();

        Reset = GameObject.Find("Reset");
        toggleReset = Reset.gameObject.GetComponent<Toggle>();

        Volume = GameObject.Find("Volume");
        slider = Volume.gameObject.GetComponent<Slider>();
                        
        if (PlayerPrefs.HasKey("VolumeAudio")) slider.value = PlayerPrefs.GetFloat("VolumeAudio");
        else slider.value = 0;

        if (PlayerPrefs.HasKey("MuteAudio"))
        {
            if (PlayerPrefs.GetInt("MuteAudio") == 0) toggleMute.isOn = false;
            else toggleMute.isOn = true;
        } else toggleMute.isOn = false;

        if (PlayerPrefs.HasKey("ResetAudio"))
        {
            if (PlayerPrefs.GetInt("ResetAudio") == 0) toggleReset.isOn = false;
            else toggleReset.isOn = true;
        }
        else toggleReset.isOn = false;
    }

    public void MuteAudio()
    {
        PlayerPrefs.SetInt("MuteAudio", (toggleMute.isOn ? 1 : 0));
    }

    public void ResetAudio()
    {
        PlayerPrefs.SetInt("ResetAudio", (toggleReset.isOn ? 1 : 0));
    }

    public void VolumeAudio()
    {
        PlayerPrefs.SetFloat("VolumeAudio", slider.value);
    }
}
