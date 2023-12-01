using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 20;

   private void OnTriggerEnter2D(Collider2D collision)
   {
       if(collision.transform.tag == "Player")
       {
        PlayerController.numberOfCoins += coinValue;
        PlayerPrefs.SetInt("NumberOfCoins", PlayerController.numberOfCoins);
        Destroy(gameObject);
       }
   }
}
