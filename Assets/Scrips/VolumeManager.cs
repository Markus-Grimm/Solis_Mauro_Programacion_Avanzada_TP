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
