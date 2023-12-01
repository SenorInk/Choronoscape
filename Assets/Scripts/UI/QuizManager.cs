using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public Transform startingPoint;
    private UIManager uiManager;

    public List<QuestionAndAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject GoPanel;

    public GameObject QuizManagers;

    public Text QuestionTxt;
    
    private void Awake()
    {
        
        uiManager = FindObjectOfType<UIManager>();

    }

    private void Start()
    {
        
        GoPanel.SetActive(false);
        generateQuestion();
    }

    public void GoBackGame()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void WrongAnswerRestart()
    {
        uiManager.GameOver();
    }

    public void GameOvers()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(true);
    }

    public void correct()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();

        GameObject player = GameObject.FindGameObjectWithTag("Player"); 
        if (player != null && startingPoint != null)
        {
            player.transform.position = startingPoint.position;
            player.transform.rotation = startingPoint.rotation;
        }
    }

    void SetAnswers()
    {
        for(int i = 0; i< options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }

    }

    void generateQuestion()
    {
        if(QnA.Count > 0 )
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else 
        {
            Debug.Log("Out of Questions");
            GameOvers();
        }

        
    }

    public void StartQuiz()
    {
        Quizpanel.SetActive(true);
        Time.timeScale = 0f; 
        generateQuestion();
    }

}