using UnityEngine;

public class Task2 : MonoBehaviour
{
    public float coverPrice; // Cover price of the book
    public int numCopiesSold; // Number of copies sold

    void Start()
    {
        if (coverPrice > 0)
        {
            // Calculate wholesale price per book
            float wholesalePricePerBook = 0.60f * coverPrice;

            // Calculate shipping cost
            float shippingCost = 3 + 0.75f * (numCopiesSold - 1);

            // Total wholesale cost
            float totalWholesaleCost = numCopiesSold * wholesalePricePerBook + shippingCost;

            // Total revenue from selling Y copies
            float revenue = numCopiesSold * coverPrice;

            // Profit before operational costs
            float profit = revenue - totalWholesaleCost;

            // Output the results
            Debug.Log("Total Wholesale Cost: " + totalWholesaleCost);
            Debug.Log("Profit: " + profit);
        }
        else
        {
            Debug.LogError("Error");
        }
    }
}