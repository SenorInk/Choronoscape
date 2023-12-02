using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            musicSource = GetComponent<AudioSource>();
        }
    }
    private AudioSource musicSource;
    public List<AudioClip> track;
    private int currentIndex = 0;
    // Update is called once per frame
    void Update()
    {
        musicSource.volume = SettingsManager.instance.musicLevel;
    }

    public void Play(int index)
    {
        currentIndex = index;
        musicSource.clip = track[currentIndex];
    }

    public void Next()
    {
        Play(currentIndex++);
    }

    public void Previous()
    {
        Play(currentIndex--);
    }
}
