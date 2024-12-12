using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class AudioSourceController : MonoBehaviour
{
    public static AudioSourceController Instance;
    public Sound_Index[] MusicLable;
    public AudioSource Music_Src;
    #region AWAKE
    private void Awake()
    {
        if (Instance == null)//if there is no instance in the audio source
        {
            Instance = this;//set instance to the index of the sound name.
            DontDestroyOnLoad(gameObject);//do not destroy
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion
    private void Start()
    {
        PlayMusic("Music");
    }
    public void PlayMusic(string Name)
    {
        Sound_Index s = Array.Find(MusicLable, X => X.Sound_Name == Name);

        if (s == null)
        {
            Debug.Log("Sound Error");
        }
        else
        {
            Music_Src.clip = s.SoundClip;
            Music_Src.Play();
        }
    }
}