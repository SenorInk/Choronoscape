using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Mathematics;

public class SceneLoader : MonoBehaviour
{
    public GameObject loaderUI;
    public Slider progressSlider;

    public void LoadScene(string name)
    {
        StartCoroutine(LoadScene_Coroutine(name));
    }

    public IEnumerator LoadScene_Coroutine(string name)
    {
        progressSlider.value = 0;
        loaderUI.SetActive(true);

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(name);
        asyncOperation.allowSceneActivation = false;
        float progress = 0;
        while(!asyncOperation.isDone)
        {
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
            progressSlider.value = progress;
            if (progress >= 0.9f)
            {
                progressSlider.value = 2;
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
