using UnityEngine;
using TMPro;

public class PurchaseButton : MonoBehaviour
{
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI insufficientBalanceText;
    public TextMeshProUGUI ItemPurchased;


    private int price;
    private int money;

    private void Start()
    {
        // Initialize price and money values (you can set these in the Unity Editor)
        if (int.TryParse(priceText.text, out int parsedPrice))
        {
            price = parsedPrice;
        }
        else
        {
            Debug.LogError("Invalid format for priceText. Ensure it contains a valid integer.");
        }

        if (int.TryParse(moneyText.text, out int parsedMoney))
        {
            money = parsedMoney;
        }
        else
        {
            Debug.LogError("Invalid format for moneyText. Ensure it contains a valid integer.");
        }

        
        ItemPurchased.gameObject.SetActive(false);
        insufficientBalanceText.gameObject.SetActive(false);


    }


    public void OnButtonClick()
    {
        // Check if the money is sufficient for the purchase
        if (money >= price)
        {
            // Subtract the price from the money
            money -= price;

            // Update the money text
            moneyText.text = money.ToString();

            ItemPurchased.gameObject.SetActive(true);
            // Reset the insufficient balance text
            insufficientBalanceText.gameObject.SetActive(false);
            
        }
        else
        {
            // Display insufficient balance message
            insufficientBalanceText.gameObject.SetActive(true);
            ItemPurchased.gameObject.SetActive(false);
        }
    }
}
