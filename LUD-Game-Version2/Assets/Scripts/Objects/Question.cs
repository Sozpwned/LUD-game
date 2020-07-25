using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Question
{
    //Text Fields for cards//
    public string title="Title missing :(";
    public string categori = "Unlabeled!";
    public string text = "This card has no text. What the fuck did you do Lasse?";

    //Internal logic variables for player selection//
    public int playerCount = 0;
    public int[] chosenPlayers;

    //Values for controlling drinks//
    public int minDrinks = 1;
    public int maxDrinks = 5;
    private int drinks;

    public Question() {
        chosenPlayers = new int[playerCount];
    }
}
