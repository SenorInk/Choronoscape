using UnityEngine;
using UnityEngine.UI;

public class SettingsScript1 : MonoBehaviour
{
    private SettingsManager manager;
    public Slider musicSlider;
    public Slider audioSlider;
    public GameObject settingsPanel;
    //public SceneLoader sceneLoader;
    void Start()
    {
        manager = SettingsManager.instance;
        if (musicSlider != null && audioSlider != null)
            UpdateSliders();
    }
    public void UpdateSliders()
    {
        musicSlider.value = manager.musicLevel;
        audioSlider.value = manager.audioLevel;
    }

    public void UpdateSettings()
    {
        manager.musicLevel = musicSlider.value;
        manager.audioLevel = audioSlider.value;
        manager.Save();
    }

    public void ShowSettings()
    {
        settingsPanel.SetActive(true);

    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }

    public void CloseFactPanel()
    {
        UpdateSettings();
        settingsPanel.SetActive(false);
    }

    /*public void OpenMainMenu(){
        UpdateSettings();
        sceneLoader.LoadScene("Main Menu");
    }*/
}
