using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public static SettingsManager instance;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            if (!PlayerPrefs.HasKey("musicLevel"))
                return;
            Load();
        }
    }

    public void Load()
    {
        musicLevel = PlayerPrefs.GetFloat("musicLevel");
        audioLevel = PlayerPrefs.GetFloat("audioLevel");
    }

    public void Save()
    {
        SetFloat("musicLevel", musicLevel);
        SetFloat("audioLevel", audioLevel);
    }

    public void Reset()
    {
        musicLevel = 100f;
        audioLevel = 100f;
        Save();
    }

    public void SetFloat(string key, float value)
    {
        PlayerPrefs.SetFloat(key, value);
        PlayerPrefs.Save();
    }

    public float musicLevel { get; set; }
    public float audioLevel { get; set; }
}
