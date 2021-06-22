using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour {

    public AudioMixer audioMixer;

    [Space(10)]
    public Slider musicSlider;
    public Slider SFXSlider;

    //music
    public void SetMusicVolume (float volume) {
        audioMixer.SetFloat("musicVolume", volume);
    }

    //SFX
    public void SetSFXVolume(float volume) {
        audioMixer.SetFloat("SFXVolume", volume);
    }

    private void Start()
    {

        musicSlider.value = PlayerPrefs.GetFloat("musicVolume", 1);
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume", 1);
    }

    private void OnDisable() {
        float musicVolume = 0;
        float SFXVolume = 0;

        audioMixer.GetFloat("musicVolume", out musicVolume);
        audioMixer.GetFloat("SFXVolume", out SFXVolume);

        PlayerPrefs.SetFloat("musicVolume", musicVolume);
        PlayerPrefs.SetFloat("SFXVolume", SFXVolume);
        PlayerPrefs.Save();
    }    
}
