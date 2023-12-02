using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNavigation : MonoBehaviour
{
    public string[] contentSceneNames; // Replace with the names of your content scenes
    public int sceneIndex; // Set this in the Inspector to indicate which scene this button will lead to

    private void Start()
    {
        // Ensure the array is not null and has enough elements
        if (contentSceneNames == null || sceneIndex < 0 || sceneIndex >= contentSceneNames.Length)
        {
            Debug.LogError("Invalid configuration. Please set the contentSceneNames array and sceneIndex for the button.");
            return;
        }
    }

    public void OnButtonClick()
    {
        // Load the specified content scene
        SceneManager.LoadScene(contentSceneNames[sceneIndex]);
    }
}
