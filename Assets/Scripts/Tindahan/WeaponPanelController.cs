using UnityEngine;
using UnityEngine.UI;

public class WeaponPanelController : MonoBehaviour
{
    public GameObject WeaponProfilePanels;
    public GameObject[] WEAPONS;
   

    void Start()
    {
        
        for (int i = 0; i < WEAPONS.Length; i++)
        {
            int weaponIndex = i;
            Button btnPurchase = WEAPONS[i].transform.Find("btnPurchase").GetComponent<Button>();
            btnPurchase.onClick.AddListener(() => ShowProfilePanel(weaponIndex));
        }
    }

    void ShowProfilePanel(int weaponIndex)
    {
        // Deactivate all profile panels
        for (int i = 0; i < WeaponProfilePanels.transform.childCount; i++)
        {
            WeaponProfilePanels.transform.GetChild(i).gameObject.SetActive(false);
        }

        // Activate the corresponding profile panel
        int profileIndex = weaponIndex + 1; // Adjust the index if it starts from 1
       WeaponProfilePanels.transform.GetChild(profileIndex - 1).gameObject.SetActive(true);
    }

}
