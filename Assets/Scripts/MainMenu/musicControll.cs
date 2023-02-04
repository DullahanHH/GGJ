using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
 using UnityEngine.UI;

public class musicControll : MonoBehaviour{
    private AudioSource music;
    public Slider slider;

    void Start(){
        music = FindObjectOfType<AudioSource>();
        music.volume = PlayerPrefs.GetFloat("Volume");
        slider.value = music.volume;
    }

    public void con_sound(){
        music.volume = slider.value;
        PlayerPrefs.SetFloat("Volume", slider.value);
    }
}