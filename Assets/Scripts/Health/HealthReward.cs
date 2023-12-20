using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthReward : MonoBehaviour
{
    [SerializeField] private float healthValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().AddHealth(healthValue);
            gameObject.SetActive(false);
        }
    }

    private void AddHealth()
    {
        // Assuming the player has a Health component
        Health playerHealth = FindObjectOfType<Health>(); // You might need a more robust way to find the player's Health component
        if (playerHealth != null)
        {
            playerHealth.AddHealth(healthValue);
        }
    }
}
