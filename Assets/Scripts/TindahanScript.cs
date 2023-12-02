using UnityEngine;

public class TindahanScript : MonoBehaviour
{
    private TindahanManager tindahanManager;
    private int playerBalance;
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
    }

    public void BuyItem(string name)
    {
        int cost = 0;
        string key = "";
        switch (name.ToLower())
        {
            case "sibat":
                cost = 300;
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
                cost = 200;
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

    }

    public void ShowFailedPanel()
    {

    }
}
