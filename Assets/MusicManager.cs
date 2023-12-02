using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager  : MonoBehaviour
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
    // Update is called once per frame
    void Update()
    {
        musicSource.volume = SettingsManager.instance.musicLevel;
    }
}
