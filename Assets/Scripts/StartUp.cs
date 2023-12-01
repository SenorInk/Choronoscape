using UnityEngine;

public class StartUp : MonoBehaviour
{
    public SceneLoader loader;
    void Start()
    {
        /** REMOVE THIS ON PRODUCTION
        if(!PlayerPrefs.HasKey("ShownPrologue"))
        {
            loader.LoadScene("PrologueScene");
            PlayerPrefs.SetInt("ShownPrologue", 1);
        }
        else
            loader.LoadScene("MainMenuScene");
        */
        loader.LoadScene("PrologueScene");
    }
}
