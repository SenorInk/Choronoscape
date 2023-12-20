using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomFactsScript : MonoBehaviour
{
    [Header("List of facts")]
    public List<String> facts;

    [Header("List of facts")]
    [Tooltip("This must have the same order as facts")]
    public List<AudioClip> voiceOvers;
    [Header("Translation Audio Channel")]
    public AudioSource translationSource;
    [Header("Elements")]

    [Header("Sound Effects | Optional")]
    public AudioSource source;
    public AudioClip openClip;
    public AudioClip closeClip;
    private bool audioIsEnabled = true;
    public GameObject randomfactPanel;
    public TextMeshProUGUI factText;
    void Start()
    {
        // Disable audio if AudioSource component is not found
        if (source == null)
            audioIsEnabled = false;
    }
    public void ShowRandomFact()
    {
        randomfactPanel.SetActive(true);
        bool factServed = true;
        do
        {
            try
            {
                int currentIndex = new System.Random().Next(0, facts.Count);
                factText.text = facts[currentIndex];
                translationSource.clip = voiceOvers[currentIndex];
                Debug.Log("Translation Clip: " + translationSource.clip);
            }
            catch (IndexOutOfRangeException)
            {
                factServed = false;
            }
        } while (!factServed);

        PlaySFX("open");
    }

    public void PlayTransalation()
    {
        Debug.Log("Playing Clip: " + translationSource.clip);
        translationSource.Play();
    }

    public void StopTransalation()
    {
        source.Stop();
    }

    public void CloseFactPanel()
    {
        randomfactPanel.SetActive(false);

        PlaySFX("close");
    }

    public void PlaySFX(string name)
    {
        // Return if audio is not enabled
        if (!audioIsEnabled)
            return;

        // Set the AudioClip based on the provided name
        if (name.ToLower().Equals("close"))
        {
            if (closeClip != null)
                source.clip = closeClip;
            else
                return;
        }
        else if (name.ToLower().Equals("open"))
        {
            if (openClip != null)
                source.clip = openClip;
            else
                return;
        }
        else
        {
            // Log an error if an invalid name is provided
            Debug.LogError("[SFX Manager | Map] Unable to play SFX. Invalid name!"
             + "Please check your code if it matches the given argument requirements.");
            return;
        }

        // Play the sound effect if not already playing
        if (!source.isPlaying)
            source.Play();
    }
}