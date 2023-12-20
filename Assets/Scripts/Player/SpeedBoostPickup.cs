using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostPickup : MonoBehaviour
{
    public float speedBoostAmount = 2f; 
    public float duration = 5f; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            
            if (playerController != null)
            {

                playerController.StartCoroutine(SpeedBoost(playerController));
                
                Destroy(gameObject);
            }
        }
    }

    private IEnumerator SpeedBoost(PlayerController player)
    {

        float originalSpeed = player.speed;

        player.speed += speedBoostAmount;

        yield return new WaitForSeconds(duration);

        player.speed = originalSpeed;

    }
}
