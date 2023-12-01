using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StaticDialogue : MonoBehaviour
{
    [Header("Dialogues Binding")]
    public List<string> dialogues;
    public TextMeshProUGUI dialogueText;

    [Header("Backgrounds Binding")]
    public List<Sprite> backgrounds;
    public List<int> indexOfDialogueToChangeBackground;
    public Image backgroundImage;

    [Header("Next Scene")]
    public string nextSceneName;
    public SceneLoader loader;

    [Header("Sound Effect || Can be empty")]
    public AudioClip sound;
    public AudioSource audioSource;

    [Header("Dialogue Settings")]
    public float delay = 0.05f;

    // Class-specific
    private int dialogueIndex = 0;
    private int imageIndex = 0;
    private bool isAnimating = false;

    public void Start()
    {
        dialogueText.text = "";
        backgroundImage.sprite = backgrounds[imageIndex];
        StartDialogue();
    }

    public void NextDialogue()
    {
        if (dialogues.Count <= 2)
        {
            loader.LoadScene(nextSceneName);
        }
        if (dialogueIndex == (dialogues.Count - 1))
        {
            loader.LoadScene(nextSceneName);
            return;
        }
        if (dialogueIndex == dialogues.Count - 1 && dialogueText.text == dialogues[dialogueIndex])
        {
            dialogueText.gameObject.transform.parent.gameObject.SetActive(false);
            loader.LoadScene(nextSceneName);
        }
        if (dialogueText.text == dialogues[dialogueIndex])
        {
            NextLine();
        }
        else
        {
            StopAllCoroutines();
            dialogueText.text = dialogues[dialogueIndex];
        }
    }

    public void NextBackgroundImage()
    {
        imageIndex += 1;
        backgroundImage.sprite = backgrounds[imageIndex];
    }

    void StartDialogue()
    {
        dialogueIndex = 0;
        if (sound != null && audioSource != null)
        {
            PlayTypewriterSound();
            Debug.Log("Found source and clip. Playing dialogue sound!");
        }
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char letter in dialogues[dialogueIndex].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(delay);
        }
        if (sound != null && audioSource != null)
        {
            audioSource.Stop();
        }
    }

    void NextLine()
    {
        if (dialogueIndex < dialogues.Count - 1)
        {
            dialogueIndex++;
            dialogueText.text = string.Empty;
            if (sound != null && audioSource != null)
            {
                PlayTypewriterSound();
                Debug.Log("Found source and clip. Playing dialogue sound!");
            }
            try
            {
                foreach (int i in indexOfDialogueToChangeBackground)
                {
                    if (dialogueIndex == i)
                        NextBackgroundImage();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Debug.Log("No background to show.. skipping feature");
            }
            finally
            {
                StartCoroutine(TypeLine());
            }
        }
        else
        {
            dialogueText.gameObject.SetActive(false);
        }
    }

    void PlayTypewriterSound()
    {
        if (sound != null && audioSource != null)
        {
            audioSource.clip = sound;
            audioSource.Play();
        }
    }
}
