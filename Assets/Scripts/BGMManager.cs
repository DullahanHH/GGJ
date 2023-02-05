using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class BGMDict
{
    public string name;
    public AudioClip audio;
}

public class BGMManager : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioDict[] audioDicts;

    public void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("BGM");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        audioSource = GetComponent<AudioSource>();

        DontDestroyOnLoad(this.gameObject);
    }

    public AudioClip GetAudioClip(string name)
    {

        foreach (var item in audioDicts)
        {
            if (item.name == name)
            {
                return item.audio;
            }
        }

        throw new Exception("Cannot find the audio clip named: " + name);
    }

    public void PlaySound(string name)
    {
        audioSource.PlayOneShot(GetAudioClip(name));
    }

    public void ReplaceSound(string name)
    {
        audioSource.clip = GetAudioClip(name);
        audioSource.Play();
    }
}
