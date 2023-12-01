using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    private UIManager uiManager;
    public bool isCorrect = false;
    public QuizManager quizManager;

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            quizManager.correct();
            uiManager.GameOver();
        }
    }
}
