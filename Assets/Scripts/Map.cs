using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Manages the display of descriptions and associated sound effects on a map.
/// </summary>
public class Map : MonoBehaviour
{
    [Header("Container")]
    public GameObject detailsPanel;

    [Header("Contents")]
    public List<GameObject> descriptions;

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

        source.volume = settingsManager.audioLevel;
    }

    void Update()
    {
        if (source == null)
        {
            audioIsEnabled = false;
            return;
        }

        source.volume = settingsManager.audioLevel;
    }


    /// <summary>
    /// Opens the description at the specified index, activates details panel, and plays the "open" sound effect.
    /// </summary>
    /// <param name="index">Index of the description to be opened.</param>
    public void OpenDescription(int index)
    {
        // Check if descriptions list is empty
        if (descriptions.Count == 0)
        {
            Debug.LogError("[SFX Manager | Map] Unable to open the given description, the descriptions list is empty! Please set your description indexes");
            return;
        }

        // Check if the provided index is valid
        if (index >= descriptions.Count)
        {
            Debug.LogError("[SFX Manager | Map] Unable to open the given index. NOT FOUND!");
            return;
        }

        // Activate the specified description and details panel
        GameObject description = descriptions[index];
        description.SetActive(true);
        detailsPanel.SetActive(true);

        // Play the "open" sound effect
        PlaySFX("open");

        //Give out rewards
        if (!PlayerPrefs.HasKey("GivenMapReward1") && index == 0)
            GiveReward("GivenMapReward1");
        if ((!PlayerPrefs.HasKey("GivenMapReward2") && index == 1))
            GiveReward("GivenMapReward2");
        if ((!PlayerPrefs.HasKey("GivenMapReward3") && index == 2))
            GiveReward("GivenMapReward3");
        if ((!PlayerPrefs.HasKey("GivenMapReward4") && index == 3))
            GiveReward("GivenMapReward4");
        if ((!PlayerPrefs.HasKey("GivenMapReward5") && index == 4))
            GiveReward("GivenMapReward5");
        if ((!PlayerPrefs.HasKey("GivenMapReward6") && index == 5))
            GiveReward("GivenMapReward6");
    }

    void GiveReward(string key)
    {
        PlayerController.numberOfCoins += 200;
        PlayerPrefs.SetInt("NumberOfCoins", PlayerController.numberOfCoins);
        PlayerPrefs.SetInt(key, 1);
    }

    /// <summary>
    /// Closes all descriptions, deactivates details panel, and plays the "close" sound effect.
    /// </summary>
    public void CloseDescriptions()
    {
        // Check if descriptions list is empty
        if (descriptions.Count == 0)
        {
            Debug.LogError("[SFX Manager | Map] Unable to open the given description, the descriptions list is empty! Please set your description indexes");
            return;
        }

        // Deactivate all descriptions and the details panel
        foreach (GameObject desc in descriptions)
        {
            Debug.Log("[SFX Manager | Map] Closed a ui");
            desc.SetActive(false);
        }
        detailsPanel.SetActive(false);

        // Play the "close" sound effect
        PlaySFX("close");
    }

    /// <summary>
    /// Placeholder method for opening the calendar scene.
    /// </summary>
    public void OpenCalendar()
    {
        // Load Scene - Placeholder for future implementation
    }

    /// <summary>
    /// Plays the specified sound effect based on the given name.
    /// </summary>
    /// <param name="name">Name of the sound effect ("open" or "close").</param>
    private void PlaySFX(string name)
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
