using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using Unity.VisualScripting;

public class TindahanScript : MonoBehaviour
{
    private TindahanManager tindahanManager;
    private int playerBalance;
    public TextMeshProUGUI moneyText;
    public GameObject detailsPanel;
    public List<GameObject> itemWeaponDetailList;
    public List<GameObject> itemEnsembleDetailList;
    public List<GameObject> itemWeaponButtonList;
    public List<GameObject> itemEnsemblesButtonList;
    public List<GameObject> itemWeaponDetailBtnList;
    public List<GameObject> itemEnsembleDetailBtnList;
    public GameObject successPanel;
    public GameObject failPanel;
    void Start()
    {
        tindahanManager = TindahanManager.instance;
        playerBalance = PlayerPrefs.GetInt("NumberOfCoins");
    }

    // Update is called once per frame
    void Update()
    {
        // Update the player balance periodically
        PlayerPrefs.SetInt("NumberOfCoins", playerBalance);
        //Save changes in real time
        tindahanManager.Save();
        moneyText.SetText("" + playerBalance);
        bindButtonTexts();
        checkEquipment();
    }

    private void checkEquipment()
    {
        for (int i = 0; i < itemWeaponDetailBtnList.Count; i++)
        {
            switch (i)
            {
                case 0:
                    Debug.Log("Sibat: " + tindahanManager.hasSibat);
                    if (tindahanManager.hasSibat)
                    {
                        itemWeaponDetailBtnList[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Gamitin");
                        itemWeaponDetailBtnList[i].GetComponent<Button>().onClick.AddListener(() => EquipItem("Sibat"));
                    }
                    else
                        itemWeaponDetailBtnList[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Bilhin");
                    break;
                case 1:
                    Debug.Log("Kris: " + tindahanManager.hasKris);
                    if (tindahanManager.hasKris)
                    {
                        itemWeaponDetailBtnList[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Gamitin");
                        itemWeaponDetailBtnList[i].GetComponent<Button>().onClick.AddListener(() => EquipItem("Kris"));
                    }
                    else
                        itemWeaponDetailBtnList[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Bilhin");
                    break;
                case 2:
                    Debug.Log("Kampilan: " + tindahanManager.hasKampilan);
                    if (tindahanManager.hasKampilan)
                    {
                        itemWeaponDetailBtnList[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Gamitin");
                        itemWeaponDetailBtnList[i].GetComponent<Button>().onClick.AddListener(() => EquipItem("Kampilan"));
                    }
                    else
                        itemWeaponDetailBtnList[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Bilhin");
                    break;
            }
        }

        for (int i = 0; i < itemEnsembleDetailBtnList.Count; i++)
        {
            switch (i)
            {
                case 0:
                    if (tindahanManager.hasBahag)
                    {
                        itemEnsembleDetailBtnList[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Gamitin");
                        itemEnsembleDetailBtnList[i].GetComponent<Button>().onClick.AddListener(() => EquipItem("Bahag"));
                    }
                    else
                        itemEnsembleDetailBtnList[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Bilhin");
                    break;
                case 1:
                    if (tindahanManager.hasKangan)
                    {
                        itemEnsembleDetailBtnList[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Gamitin");
                        itemEnsembleDetailBtnList[i].GetComponent<Button>().onClick.AddListener(() => EquipItem("Kangan"));
                    }
                    else
                        itemEnsembleDetailBtnList[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Bilhin");
                    break;
                case 2:
                    if (tindahanManager.hasPudong)
                    {
                        itemEnsembleDetailBtnList[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Gamitin");
                        itemEnsembleDetailBtnList[i].GetComponent<Button>().onClick.AddListener(() => EquipItem("Pudong"));
                    }
                    else
                        itemEnsembleDetailBtnList[i].GetComponentInChildren<TextMeshProUGUI>().SetText("Bilhin");
                    break;
            }
        }
    }

    private void EquipItem(string name)
    {
        string key = "";
        switch (name.ToLower())
        {
            case "sibat":
                key = "isSibatEquiped";
                break;

            case "kris":
                key = "isKrisEquiped";
                break;

            case "kampilan":
                key = "isKampilanEquiped";
                break;

            case "bahag":
                key = "isBahagEquiped";
                break;

            case "kangan":
                key = "isKanganEquiped";
                break;

            case "pudong":
                key = "isPudongEquiped";
                break;
        }


        tindahanManager.Equip(key);
    }

    private void bindButtonTexts()
    {
        for (int i = 0; i < itemWeaponButtonList.Count; i++)
        {
            if (i >= 1)
                itemWeaponButtonList[i].GetComponent<Button>().interactable = false;
            switch (i)
            {
                case 0:
                    if (tindahanManager.hasSibat)
                        itemWeaponButtonList[i].GetComponent<TextMeshProUGUI>().SetText("Equip");
                    break;
                case 1:
                    if (tindahanManager.hasKris)
                        itemWeaponButtonList[i].GetComponent<TextMeshProUGUI>().SetText("Equip");
                    break;
                case 2:
                    if (tindahanManager.hasKampilan)
                        itemWeaponButtonList[i].GetComponent<TextMeshProUGUI>().SetText("Equip");
                    break;
            }
        }

        for (int i = 0; i < itemEnsemblesButtonList.Count; i++)
        {
            switch (i)
            {
                case 0:
                    if (tindahanManager.hasBahag)
                        itemEnsemblesButtonList[i].GetComponent<TextMeshProUGUI>().SetText("Equip");
                    break;
                case 1:
                    if (tindahanManager.hasKangan)
                        itemEnsemblesButtonList[i].GetComponent<TextMeshProUGUI>().SetText("Equip");
                    break;
                case 2:
                    if (tindahanManager.hasPudong)
                        itemEnsemblesButtonList[i].GetComponent<TextMeshProUGUI>().SetText("Equip");
                    break;
            }
        }
    }

    public void ShowWeaponItem(int index)
    {
        detailsPanel.SetActive(true);
        itemWeaponDetailList[index].SetActive(true);
    }
    public void ShowEnsembleItem(int index)
    {
        detailsPanel.SetActive(true);
        itemEnsembleDetailList[index].SetActive(true);
    }

    public void BuyItem(string name)
    {
        int cost = 0;
        string key = "";
        Debug.Log("Trying to buy " + name);
        switch (name.ToLower())
        {
            case "sibat":
                cost = 0;
                key = "hasSibat";
                break;

            case "kris":
                cost = 450;
                key = "hasKris";
                break;

            case "kampilan":
                cost = 600;
                key = "hasKampilan";
                break;

            case "sumpit":
                cost = 200;
                key = "hasSumpit";
                break;

            case "lantaka":
                cost = 500;
                key = "hasLantaka";
                break;

            case "panabas":
                cost = 250;
                key = "hasPanabas";
                break;

            case "balaraw":
                cost = 300;
                key = "hasBalaraw";
                break;

            case "kalasag":
                cost = 900;
                key = "hasKalasag";
                break;

            case "espadaydaga":
                cost = 2000;
                key = "hasEspadaYDaga";
                break;

            case "helmet":
                cost = 500;
                key = "hasHelmet";
                break;

            case "bahag":
                cost = 0;
                key = "hasBahag";
                break;

            case "kangan":
                cost = 300;
                key = "hasKangan";
                break;

            case "pudong":
                cost = 150;
                key = "hasPudong";
                break;

            case "tattoo":
                cost = 500;
                key = "hasTattoo";
                break;

            case "salakot":
                cost = 300;
                key = "hasSalakot";
                break;

            case "camisa":
                cost = 300;
                key = "hasCamisa";
                break;

            case "sandalyas":
                cost = 450;
                key = "hasSandalyas";
                break;

            case "barong":
                cost = 2000;
                key = "hasBarong";
                break;

            case "balintawak":
                cost = 1000;
                key = "hasBalintawak";
                break;

        }
        Debug.Log("Player money: " + playerBalance);
        Debug.Log("Cost: " + cost);
        Debug.Log("Transaction result: " + (playerBalance >= cost));
        if (playerBalance < cost)
        {
            ShowFailedPanel();
            return;
        }
        playerBalance -= cost;
        tindahanManager.SetBoolean(key, true);
        ShowSuccessPanel();
    }

    public void ShowSuccessPanel()
    {
        successPanel.SetActive(true);
    }

    public void ShowFailedPanel()
    {
        failPanel.SetActive(true);
    }

    public void CloseAllPanels()
    {
        detailsPanel.SetActive(false);
        successPanel.SetActive(false);
        failPanel.SetActive(false);
        foreach (GameObject item in itemWeaponDetailList)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in itemEnsembleDetailList)
        {
            item.SetActive(false);
        }
    }
}
