using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    private LevelManager levelManager;
    public List<GameObject> levels;

    void Start()
    {
        levelManager = LevelManager.instance;

        for (int i = 0; i < levels.Count; i++)
        {
            levels[i].GetComponent<Button>().interactable = false;
            switch (i)
            {
                case 0:
                    if (levelManager.lvl2Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 1:
                    if (levelManager.lvl3Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 2:
                    if (levelManager.lvl4Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 3:
                    if (levelManager.lvl5Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 4:
                    if (levelManager.lvl6Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 5:
                    if (levelManager.lvl7Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 6:
                    if (levelManager.lvl8Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 7:
                    if (levelManager.lvl9Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 8:
                    if (levelManager.lvl10Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 9:
                    if (levelManager.lvl11Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 10:
                    if (levelManager.lvl12Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 11:
                    if (levelManager.lvl13Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 12:
                    if (levelManager.lvl4Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 13:
                    if (levelManager.lvl15Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 14:
                    if (levelManager.lvl16Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 15:
                    if (levelManager.lvl17Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 16:
                    if (levelManager.lvl18Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 17:
                    if (levelManager.lvl19Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 18:
                    if (levelManager.lvl20Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 19:
                    if (levelManager.lvl21Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 20:
                    if (levelManager.lvl22Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 21:
                    if (levelManager.lvl23Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 22:
                    if (levelManager.lvl24Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 23:
                    if (levelManager.lvl25Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 24:
                    if (levelManager.lvl26Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 25:
                    if (levelManager.lvl27Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 26:
                    if (levelManager.lvl28Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 27:
                    if (levelManager.lvl29Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;

                case 28:
                    if (levelManager.lvl30Unlock)
                    {
                        levels[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                        levels[i].transform.GetChild(0).gameObject.SetActive(false);
                        levels[i].GetComponent<Button>().interactable = true;
                    }
                    break;
            }
        }
    }
}
