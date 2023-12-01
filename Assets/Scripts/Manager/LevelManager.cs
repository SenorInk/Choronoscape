using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            if (!PlayerPrefs.HasKey("lvl2Unlock"))
                return;
            Load();
        }
    }

    public void Load()
    {
        lvl2Unlock = PlayerPrefs.GetInt("lvl2Unlock") == 1;
        lvl3Unlock = PlayerPrefs.GetInt("lvl3Unlock") == 1;
        lvl4Unlock = PlayerPrefs.GetInt("lvl4Unlock") == 1;
        lvl5Unlock = PlayerPrefs.GetInt("lvl5Unlock") == 1;
        lvl6Unlock = PlayerPrefs.GetInt("lvl6Unlock") == 1;
        lvl7Unlock = PlayerPrefs.GetInt("lvl7Unlock") == 1;
        lvl8Unlock = PlayerPrefs.GetInt("lvl8Unlock") == 1;
        lvl9Unlock = PlayerPrefs.GetInt("lvl9Unlock") == 1;
        lvl10Unlock = PlayerPrefs.GetInt("lvl10Unlock") == 1;

        lvl11Unlock = PlayerPrefs.GetInt("lvl11Unlock") == 1;
        lvl12Unlock = PlayerPrefs.GetInt("lvl12Unlock") == 1;
        lvl13Unlock = PlayerPrefs.GetInt("lvl13Unlock") == 1;
        lvl14Unlock = PlayerPrefs.GetInt("lvl14Unlock") == 1;
        lvl15Unlock = PlayerPrefs.GetInt("lvl15Unlock") == 1;
        lvl16Unlock = PlayerPrefs.GetInt("lvl16Unlock") == 1;
        lvl17Unlock = PlayerPrefs.GetInt("lvl17Unlock") == 1;
        lvl18Unlock = PlayerPrefs.GetInt("lvl18Unlock") == 1;
        lvl19Unlock = PlayerPrefs.GetInt("lvl19Unlock") == 1;
        lvl20Unlock = PlayerPrefs.GetInt("lvl20Unlock") == 1;

        lvl21Unlock = PlayerPrefs.GetInt("lvl21Unlock") == 1;
        lvl22Unlock = PlayerPrefs.GetInt("lvl22Unlock") == 1;
        lvl23Unlock = PlayerPrefs.GetInt("lvl23Unlock") == 1;
        lvl24Unlock = PlayerPrefs.GetInt("lvl24Unlock") == 1;
        lvl25Unlock = PlayerPrefs.GetInt("lvl25Unlock") == 1;
        lvl26Unlock = PlayerPrefs.GetInt("lvl26Unlock") == 1;
        lvl27Unlock = PlayerPrefs.GetInt("lvl27Unlock") == 1;
        lvl28Unlock = PlayerPrefs.GetInt("lvl28Unlock") == 1;
        lvl29Unlock = PlayerPrefs.GetInt("lvl29Unlock") == 1;
        lvl30Unlock = PlayerPrefs.GetInt("lvl30Unlock") == 1;
    
    }

    public void Save()
    {
        SetBoolean("lvl2Unlock",lvl2Unlock);
        SetBoolean("lvl3Unlock",lvl3Unlock);
        SetBoolean("lvl4Unlock",lvl4Unlock);
        SetBoolean("lvl5Unlock",lvl5Unlock);
        SetBoolean("lvl6Unlock",lvl6Unlock);
        SetBoolean("lvl7Unlock",lvl7Unlock);
        SetBoolean("lvl8Unlock",lvl8Unlock);
        SetBoolean("lvl9Unlock",lvl9Unlock);
        SetBoolean("lvl10Unlock",lvl10Unlock);

        SetBoolean("lvl11Unlock",lvl11Unlock);
        SetBoolean("lvl12Unlock",lvl12Unlock);
        SetBoolean("lvl13Unlock",lvl13Unlock);
        SetBoolean("lvl14Unlock",lvl14Unlock);
        SetBoolean("lvl15Unlock",lvl15Unlock);
        SetBoolean("lvl16Unlock",lvl16Unlock);
        SetBoolean("lvl17Unlock",lvl17Unlock);
        SetBoolean("lvl18Unlock",lvl18Unlock);
        SetBoolean("lvl19Unlock",lvl19Unlock);
        SetBoolean("lvl20Unlock",lvl20Unlock);

        SetBoolean("lvl21Unlock",lvl21Unlock);
        SetBoolean("lvl22Unlock",lvl22Unlock);
        SetBoolean("lvl23Unlock",lvl23Unlock);
        SetBoolean("lvl24Unlock",lvl24Unlock);
        SetBoolean("lvl25Unlock",lvl25Unlock);
        SetBoolean("lvl26Unlock",lvl26Unlock);
        SetBoolean("lvl27Unlock",lvl27Unlock);
        SetBoolean("lvl28Unlock",lvl28Unlock);
        SetBoolean("lvl29Unlock",lvl29Unlock);
        SetBoolean("lvl30Unlock",lvl30Unlock);
    }

    public void Reset()
    {
        lvl2Unlock = false;
        lvl3Unlock = false;
        lvl4Unlock = false;
        lvl5Unlock = false;
        lvl6Unlock = false;
        lvl7Unlock = false;
        lvl8Unlock = false;
        lvl9Unlock = false;
        lvl10Unlock = false;

        lvl11Unlock = false;
        lvl12Unlock = false;
        lvl13Unlock = false;
        lvl14Unlock = false;
        lvl15Unlock = false;
        lvl16Unlock = false;
        lvl17Unlock = false;
        lvl18Unlock = false;
        lvl19Unlock = false;
        lvl20Unlock = false;

        lvl21Unlock = false;
        lvl22Unlock = false;
        lvl23Unlock = false;
        lvl24Unlock = false;
        lvl25Unlock = false;
        lvl26Unlock = false;
        lvl27Unlock = false;
        lvl28Unlock = false;
        lvl29Unlock = false;
        lvl30Unlock = false;

        Save();
    }
    public void SetBoolean(string key, bool value)
    {
        PlayerPrefs.SetInt(key, value ? 1 : 0);
        PlayerPrefs.Save();
    }

    public bool lvl2Unlock { get; set; }
    public bool lvl3Unlock { get; set; }
    public bool lvl4Unlock { get; set; }
    public bool lvl5Unlock { get; set; }
    public bool lvl6Unlock { get; set; }
    public bool lvl7Unlock { get; set; }
    public bool lvl8Unlock { get; set; }
    public bool lvl9Unlock { get; set; }
    public bool lvl10Unlock { get; set; }
    public bool lvl11Unlock { get; set; }
    public bool lvl12Unlock { get; set; }
    public bool lvl13Unlock { get; set; }
    public bool lvl14Unlock { get; set; }
    public bool lvl15Unlock { get; set; }
    public bool lvl16Unlock { get; set; }
    public bool lvl17Unlock { get; set; }
    public bool lvl18Unlock { get; set; }
    public bool lvl19Unlock { get; set; }
    public bool lvl20Unlock { get; set; }
    public bool lvl21Unlock { get; set; }
    public bool lvl22Unlock { get; set; }
    public bool lvl23Unlock { get; set; }
    public bool lvl24Unlock { get; set; }
    public bool lvl25Unlock { get; set; }
    public bool lvl26Unlock { get; set; }
    public bool lvl27Unlock { get; set; }
    public bool lvl28Unlock { get; set; }
    public bool lvl29Unlock { get; set; }
    public bool lvl30Unlock { get; set; }
}
