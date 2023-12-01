using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject QuizManagers;
    [SerializeField] private GameObject NextLevel;
    

    private void Awake() 
    {
        gameOverScreen.SetActive(false);
        QuizManagers.SetActive(false);
        NextLevel.SetActive(false);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        QuizManagers.SetActive(false);
    }

    public void StarQuiz()
    {
        Time.timeScale = 0f;
        QuizManagers.SetActive(true);
        
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void NextLvl()
    {
        NextLevel.SetActive(true);
    }
}
