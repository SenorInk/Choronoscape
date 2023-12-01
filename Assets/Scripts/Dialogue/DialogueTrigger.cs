using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Collider2D dialogueCollider;
    public Message[] messages;
    public Actor[] actors;
    private bool dialogueStarted = false;
    public SpriteRenderer spriteRenderer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!dialogueStarted && other.CompareTag("Player"))
        {
            StartDialogue();
        }else{
            EndDialogue();
        }
    }
    public void StartDialogue()
    {
        if (!dialogueStarted)
        {
            dialogueStarted = true;
            FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
            
        }
    }

    public void EndDialogue()
    {
        
        
        dialogueStarted = false;

        if (dialogueCollider != null)
        {
            dialogueCollider.enabled = false;
        }

        if (spriteRenderer != null)
        {
            Color invisibleColor = spriteRenderer.color;
            invisibleColor.a = 0f;
            spriteRenderer.color = invisibleColor;
        }
    }
    
}

[System.Serializable]
public class Message 
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actor
{
    public string name;
    public Sprite sprite;

}
