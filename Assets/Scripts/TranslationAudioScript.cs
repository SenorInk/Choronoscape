using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslationAudioScript : MonoBehaviour
{
    int musicActual = 0;
    AudioSource audioSource;
    public AudioClip[] clipNames;

    public Slider musicLength;
    private bool stop = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartAudio();
    }

    void Update()
    {
        if (!stop)
        {
            musicLength.value += Time.deltaTime;
            if(musicLength.value >= audioSource.clip.length)
            {
                musicActual++;
                if(musicActual >= clipNames.Length)
                musicActual = 0;
                StartAudio();
            }
        }
    }

    public void StartAudio(int changeMusic = 0)
    {
        musicActual += changeMusic;
        if(musicActual >= clipNames.Length)
        {
            musicActual = 0;
        }
        else if(musicActual < 0)
        {
            musicActual = clipNames.Length - 1;
        }

        if(audioSource.isPlaying && changeMusic == 0)
        {
            return;
        }
        if(stop)
        {
            stop = false;
        }

        audioSource.clip = clipNames[musicActual];
        musicLength.maxValue = audioSource.clip.length;
        musicLength.value = 0;
        audioSource.Play();
    }

    public void StopAudio()
    {
        audioSource.Stop();
        stop = true;
    }
}
