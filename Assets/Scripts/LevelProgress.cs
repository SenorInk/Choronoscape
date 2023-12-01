using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour
{
    private LevelManager levelManager;
    public List<Slider> progresses;
    void Start()
    {
        levelManager = LevelManager.instance;

        for (int i = 0; i < progresses.Count; i++)
        {
            float progress = 0f;
            progresses[i].interactable = false;
            switch(i)
            {
                case 0:
                    progress = 0.2f;
                    if (levelManager.lvl2Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl3Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl4Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl5Unlock)
                        progress += 0.2f;
                    
                    progresses[i].value = progress;
                break;

                case 1:
                    progress = 0f;
                    if (levelManager.lvl6Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl7Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl8Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl9Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl10Unlock)
                        progress += 0.2f;
                    
                    progresses[i].value = progress;
                break;

                case 2:
                    progress = 0f;
                    if (levelManager.lvl11Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl12Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl13Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl14Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl15Unlock)
                        progress += 0.2f;
                    
                    progresses[i].value = progress;
                break;

                case 3:
                    progress = 0f;
                    if (levelManager.lvl16Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl17Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl18Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl19Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl20Unlock)
                        progress += 0.2f;
                    
                    progresses[i].value = progress;
                break;

                case 4:
                    progress = 0f;
                    if (levelManager.lvl21Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl22Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl23Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl24Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl25Unlock)
                        progress += 0.2f;
                    
                    progresses[i].value = progress;
                break;

                case 5:
                    progress = 0f;
                    if (levelManager.lvl26Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl27Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl28Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl29Unlock)
                        progress += 0.2f;

                    if (levelManager.lvl30Unlock)
                        progress += 0.2f;
                    
                    progresses[i].value = progress;
                break;

            }
            
        }
    
    }

}
