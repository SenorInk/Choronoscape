using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Manages the display of descriptions and associated sound effects on a map.
/// </summary>
public class AudioScript : MonoBehaviour
{
    [Header("Sound Effects | Optional")]
    private AudioSource source;
    public AudioClip openClip;
    public AudioClip closeClip;

    // Private fields (Class specific)
    private bool audioIsEnabled = true;
    private SettingsManager settingsManager;

    void Start()
    {
        // Initialize AudioSource component for sound effects
        source = GetComponent<AudioSource>();
        settingsManager = SettingsManager.instance;

        // Disable audio if AudioSource component is not found
        if (source == null)
        {
            audioIsEnabled = false;
            return;
        }
        source.volume = PlayerPrefs.GetFloat("audioLevel");
    }

    void Update()
    {
        if (source == null)
        {
            audioIsEnabled = false;
            return;
        }
        source.volume = PlayerPrefs.GetFloat("audioLevel");
    }
    public void PlaySFX(string name)
    {
        Debug.Log("[SFX Manager | Map] Audio source is enabled: " + audioIsEnabled);
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
            //f
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
