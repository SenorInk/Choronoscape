using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnsemblePanelController : MonoBehaviour
{
  
    public GameObject EnsembleProfilePanels; 
    public GameObject[] ENSEMBLES;

    void Start()

    {
       
            for (int i = 0; i < ENSEMBLES.Length; i++)
        {
            int ensembleIndex = i; 
            Button btnPurchase = ENSEMBLES[i].transform.Find("btnPurchase").GetComponent<Button>();
            btnPurchase.onClick.AddListener(() => ShowProfilePanel(ensembleIndex));
        }
    }

    void ShowProfilePanel(int ensembleIndex)
    {
        // Deactivate all profile panels
        for (int i = 0; i < EnsembleProfilePanels.transform.childCount; i++)
        {
            EnsembleProfilePanels.transform.GetChild(i).gameObject.SetActive(false);
        }

        // Activate the corresponding profile panel
        int profileIndex = ensembleIndex + 1; // Adjust the index if it starts from 1
       EnsembleProfilePanels.transform.GetChild(profileIndex - 1).gameObject.SetActive(true);
    }
   
}
