using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Transform currentCheckpoint;
    private Health playerHealth;
    private UIManager uiManager;

    public GameObject fallDetector;

    private bool quizStarted = false;

    private int falls = 0;

    private void Awake()
    {
        playerHealth = GetComponent<Health>();
        uiManager = FindObjectOfType<UIManager>();
    }

    public void CheckRespawn()
    {
        if(currentCheckpoint == null)
        {
            Debug.Log("No checkpoint set. Game Over.");
            uiManager.GameOver();
            return;
        }
        
        playerHealth.Respawn();
        transform.position = currentCheckpoint.position;

        // Reactivate the collider of the checkpoint
        currentCheckpoint.GetComponent<Collider2D>().enabled = true;

        // Check if the 'Animator' component is attached before using it
        Animator checkpointAnimator = currentCheckpoint.GetComponent<Animator>();
        if (checkpointAnimator != null)
        {
            // Play the "appear" animation again
            checkpointAnimator.SetTrigger("appear");
        }

        falls = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Checkpoint")
        {
            currentCheckpoint = collision.transform;
            collision.GetComponent<Collider2D>().enabled = false;
            
            // Check if the 'Animator' component is attached before using it
            Animator checkpointAnimator = collision.GetComponent<Animator>();
            if (checkpointAnimator != null)
            {
                checkpointAnimator.SetTrigger("appear");
            }

            // Reset falls counter when a checkpoint is triggered
            falls = 0;
        }
        else if (collision.transform.tag == "StartingPoint")
        {
            
            collision.GetComponent<Collider2D>().enabled = false;
            
            // Check if the 'Animator' component is attached before using it
            Animator startingPointAnimator = collision.GetComponent<Animator>();
            if (startingPointAnimator != null)
            {
                // Use startingPointAnimator if needed
            }
        }
        else if (collision.transform.tag == "FallDetector")
        {
            if (!quizStarted)
            {
                uiManager.StarQuiz();
                quizStarted = true;
            }
            else
            {
                // Player has fallen again, check if a checkpoint is tagged
                if (currentCheckpoint == null)
                {
                    // Increment the falls counter
                    falls++;

                    // Check if the falls counter reaches the threshold
                    if (falls >= 1)
                    {
                        Debug.Log("Player fell twice without triggering a checkpoint. Game Over.");
                        uiManager.GameOver();
                    }
                }
                else
                {
                    // Respawn at the checkpoint
                    CheckRespawn();
                }
            }
        }
    }
    void Update() 
    {
        fallDetector.transform.position = new Vector2(transform.position.x, fallDetector.transform.position.y);
    }
}
