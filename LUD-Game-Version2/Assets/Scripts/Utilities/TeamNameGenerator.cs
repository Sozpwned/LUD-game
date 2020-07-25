using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamNameGenerator
{
    private string[] startWords = {"ægte", "mægtige", "voldsomme","usædvanelige",
    "værdige"};

    private string[] secondWords = {"snus-elskere", "kammerater"};
    public TeamNameGenerator() {

    }
    public string generateTeamName() {
        string teamName ="";

        teamName+=startWords[Random.Range(0,startWords.Length)];
        teamName+=" ";
        teamName+=secondWords[Random.Range(0,secondWords.Length)];

        return teamName;
    }
    public string[] generateTeamNames(int numberOfTeams) {
        string[] teamNames = new string[numberOfTeams];
        bool unique;

        for(int i=0;i<numberOfTeams;i++) {
            do {
            teamNames[i] = generateTeamName();
            unique = true;
             for(int j=0;j<numberOfTeams;j++) {
                   if (j!=i && teamNames[i] == teamNames[j])  {
                       unique = false;
                   }
             }   
            } while (!unique);
        }
        return teamNames;
    }
}

