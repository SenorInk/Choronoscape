using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionMarkScript : MonoBehaviour
{

    public GameObject aboutPanel;
    public void ShowAbout()
    {
        aboutPanel.SetActive(true);
        
    }

    public void CloseAboutPanel()
    {
        aboutPanel.SetActive(false);
    }
}
