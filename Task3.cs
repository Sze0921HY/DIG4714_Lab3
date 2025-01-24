using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour

{
    // Input
    public int x;

    // Bills
    private int hundreds, fifties, twenties, tens, fives, ones;

    void Start()
    {
        //If the amount is more than 100
        if (x >= 100)
        {
            hundreds = x / 100;
            x -= 100 * hundreds;
        }

        //If the amount is more than 50
        if (x >= 50)
        {
            fifties = x / 50;
            x -= 50 * fifties;
        }

        //If the amount is more than 20
        if (x >= 20)
        {
            twenties = x / 20;
            x -= 20 * twenties;
        }

        //If the amount is more than 10
        if (x >= 10)
        {
            tens = x / 10;
            x -= 10 * tens;
        }

        //If the amount is more than 5
        if (x >= 5)
        {
            fives = x / 5;
            x -= 5 * fives;
        }

        //If the amount is more than 1
        if (x >= 1)
        {
            ones = x;
        }

        Debug.Log("Hundreds: " + hundreds + "\nFifties: " + fifties + "\nTwenties: " + twenties + "\nTens: " + tens + "\nFives: " + fives + "\nOnes: " + ones);
    }
}