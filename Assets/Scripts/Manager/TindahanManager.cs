using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TindahanManager : MonoBehaviour
{
    public static TindahanManager instance;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            if (!PlayerPrefs.HasKey("hasSibat"))
                return;
            Load();
        }
    }
    public void Load()
    {
        hasSibat = PlayerPrefs.GetInt("hasSibat") == 1;
        hasKris = PlayerPrefs.GetInt("hasKris") == 1;
        hasKampilan = PlayerPrefs.GetInt("hasKampilan") == 1;
        hasSumpit = PlayerPrefs.GetInt("hasSumpit") == 1;
        hasLantaka = PlayerPrefs.GetInt("hasLantaka") == 1;
        hasPanabas = PlayerPrefs.GetInt("hasPanabas") == 1;
        hasBalaraw = PlayerPrefs.GetInt("hasBalaraw") == 1;
        hasKalasag = PlayerPrefs.GetInt("hasKalasag") == 1;
        hasEspadaYDaga = PlayerPrefs.GetInt("hasEspadaYDaga") == 1;
        hasHelmet = PlayerPrefs.GetInt("hasHelmet") == 1;
        hasBahag = PlayerPrefs.GetInt("hasBahag") == 1;
        hasKangan = PlayerPrefs.GetInt("hasKangan") == 1;
        hasPudong = PlayerPrefs.GetInt("hasPudong") == 1;
        hasTattoo = PlayerPrefs.GetInt("hasTattoo") == 1;
        hasSalakot = PlayerPrefs.GetInt("hasSalakot") == 1;
        hasCamisa = PlayerPrefs.GetInt("hasCamisa") == 1;
        hasSandalyas = PlayerPrefs.GetInt("hasSandalyas") == 1;
        hasBarongTagalog = PlayerPrefs.GetInt("hasBarongTagalog") == 1;
        hasBalintawak = PlayerPrefs.GetInt("hasBalintawak") == 1;
    }

    public void Save()
    {
        SetBoolean("hasSibat", hasSibat);
        SetBoolean("hasKris", hasKris);
        SetBoolean("hasKampilan", hasKampilan);
        SetBoolean("hasSumpit", hasSumpit);
        SetBoolean("hasLantaka", hasLantaka);
        SetBoolean("hasPanabas", hasPanabas);
        SetBoolean("hasBalaraw", hasBalaraw);
        SetBoolean("hasKalasag", hasKalasag);
        SetBoolean("hasEspadaYDaga", hasEspadaYDaga);
        SetBoolean("hasHelmet", hasHelmet);
        SetBoolean("hasBahag", hasBahag);
        SetBoolean("hasKangan", hasKangan);
        SetBoolean("hasKangan", hasKangan);
        SetBoolean("hasPudong", hasPudong);
        SetBoolean("hasTattoo", hasTattoo);
        SetBoolean("hasSalakot", hasSalakot);
        SetBoolean("hasCamisa", hasCamisa);
        SetBoolean("hasSandalyas", hasSandalyas);
        SetBoolean("hasBarongTagalog", hasBarongTagalog);
        SetBoolean("hasBalintawak", hasBalintawak);
    }

    public void Reset()
    {
        hasSibat = false;
        hasKris = false;
        hasKampilan = false;
        hasSumpit = false;
        hasLantaka = false;
        hasPanabas = false;
        hasBalaraw = false;
        hasKalasag = false;
        hasEspadaYDaga = false;
        hasHelmet = false;
        hasBahag = false;
        hasKangan = false;
        hasPudong = false;
        hasTattoo = false;
        hasSalakot = false;
        hasCamisa = false;
        hasSandalyas = false;
        hasBarongTagalog = false;
        hasBalintawak = false;
        Save();
    }

    public void SetBoolean(string key, bool value)
    {
        PlayerPrefs.SetInt(key, value ? 1 : 0);
        PlayerPrefs.Save();
    }

    public Boolean hasSibat { get; set; }
    public Boolean hasKris { get; set; }
    public Boolean hasKampilan { get; set; }
    public Boolean hasSumpit { get; set; }
    public Boolean hasLantaka { get; set; }
    public Boolean hasPanabas { get; set; }
    public Boolean hasBalaraw { get; set; }
    public Boolean hasKalasag { get; set; }
    public Boolean hasEspadaYDaga { get; set; }
    public Boolean hasHelmet { get; set; }
    public Boolean hasBahag { get; set; }
    public Boolean hasKangan { get; set; }
    public Boolean hasPudong { get; set; }
    public Boolean hasTattoo { get; set; }
    public Boolean hasSalakot { get; set; }
    public Boolean hasCamisa { get; set; }
    public Boolean hasSandalyas { get; set; }
    public Boolean hasBarongTagalog { get; set; }
    public Boolean hasBalintawak { get; set; }
}
