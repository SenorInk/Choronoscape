using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private UIManager uiManager;

    private bool levelCompleted = false;

    private void Awake()
    {

        uiManager = FindObjectOfType<UIManager>();

    }
    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            levelCompleted = true;
            Invoke("CompleteLevel", 0f);
        }
    }

    private void CompleteLevel()
    {
        uiManager.NextLvl();
    }

    public void LoadNextLevel()
    {
        ///
        /// Save the progress of the user by setting this flag
        ///   
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 13:
                LevelManager.instance.lvl2Unlock = true;
                LevelManager.instance.Save();
                break;
            case 14:
                LevelManager.instance.lvl3Unlock = true;
                LevelManager.instance.Save();
                break;
            case 15:
                LevelManager.instance.lvl4Unlock = true;
                LevelManager.instance.Save();
                break;

        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
