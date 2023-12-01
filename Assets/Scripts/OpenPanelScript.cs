using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OpenPanelScript : MonoBehaviour
{
    public GameObject Panel;
    
    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            
            if(isActive)
            {
                Time.timeScale = 1f;
                Panel.SetActive(false);
            }
            else
            {
                Panel.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void ClosePanel()
    {
        if (Panel != null && Panel.activeSelf)
        {
            Panel.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
