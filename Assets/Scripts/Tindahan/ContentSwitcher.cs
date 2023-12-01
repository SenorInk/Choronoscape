using System;
using UnityEngine;
using UnityEngine.UI;

public class ContentSwitcher : MonoBehaviour
{
    public Button BtnWeapons;
    public Button BtnEnsembles;
    public Button BtnAbilities;
    public Button BtnPurchase;

    public GameObject WEAPONS;
    public GameObject ENSEMBLES;
    public GameObject ABILITIES;
    public GameObject WeaponProfilePanels;
    public GameObject EnsembleProfilePanels;
    public GameObject AbilitiesProfilePanels;

   

    void Start()
    {
       
        BtnWeapons.onClick.AddListener(ShowWEAPONS);
        BtnEnsembles.onClick.AddListener(ShowENSEMBLES);
        BtnAbilities.onClick.AddListener(ShowABILITIES);

        ShowWEAPONS();
    }


    void ShowWEAPONS()
    {

        ENSEMBLES.SetActive(false);
        ABILITIES.SetActive(false);
        WEAPONS.SetActive(true);

    }

    void ShowENSEMBLES()
    {

        WEAPONS.SetActive(false);
        ABILITIES.SetActive(false);
        ENSEMBLES.SetActive(true);

    }

    void ShowABILITIES()
    {

        WEAPONS.SetActive(false);
        ENSEMBLES.SetActive(false);
        ABILITIES.SetActive(true);

    }
}