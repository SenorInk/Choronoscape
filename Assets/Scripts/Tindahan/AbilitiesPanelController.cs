using UnityEngine;
using UnityEngine.UI;

public class AbilitiesPanelController : MonoBehaviour
{
    public GameObject AbilitiesProfilePanels; 
    public GameObject[] ABILITIES; 

    void Start()
    {

        for (int i = 0; i < ABILITIES.Length; i++)
        {
            int abilityIndex = i; 
            Button btnPurchase = ABILITIES[i].transform.Find("btnPurchase").GetComponent<Button>();
            btnPurchase.onClick.AddListener(() => ShowProfilePanel(abilityIndex));
        }
    }

    void ShowProfilePanel(int abilityIndex)
    {
        // Deactivate all profile panels
        for (int i = 0; i < AbilitiesProfilePanels.transform.childCount; i++)
        {
            AbilitiesProfilePanels.transform.GetChild(i).gameObject.SetActive(false);
        }

        // Activate the corresponding profile panel
        int profileIndex = abilityIndex + 1; // Adjust the index if it starts from 1
        AbilitiesProfilePanels.transform.GetChild(profileIndex - 1).gameObject.SetActive(true);
    }
  
}
