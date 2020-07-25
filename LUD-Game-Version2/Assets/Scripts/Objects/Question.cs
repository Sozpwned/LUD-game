using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Question
{
    public string title="Hey";
    public string text;

    public int playerCount = 0;
    public int[] chosenPlayers;


    public Question() {
        chosenPlayers = new int[playerCount];
    }
}
