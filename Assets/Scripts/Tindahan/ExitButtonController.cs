using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ExitPanelButton : MonoBehaviour
{
    public GameObject panelToExit; // Reference to the panel you want to exit
    public Button exitButton; // Use the existing variable instead of declaring a new one
    public TextMeshProUGUI ItemPurchasedText;
    void Start()
    {
        
        if (panelToExit == null)
        {
            Debug.LogError("Please assign the panelToExit reference in the Inspector.");
            return;
        }

        
        if (exitButton != null)
        {
            exitButton.onClick.AddListener(ExitPanel);
        }
        else
        {
            Debug.LogError("Button component not found on the GameObject.");
        }
    }

    void ExitPanel()
    {
        
        panelToExit.SetActive(false);
        if (ItemPurchasedText != null)
        {
            ItemPurchasedText.enabled = false;
        }
    }
}

