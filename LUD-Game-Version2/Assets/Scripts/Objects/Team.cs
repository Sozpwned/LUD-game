using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team 
{
    public string teamName;
    public List<Player> teamMembers = new List<Player>();
    public int teamScore;

    public Team(string teamName) { 
        this.teamName = teamName;
    }
    public void addPlayer(Player toAdd) {
        teamMembers.Add(toAdd);
    }
    public Player randomTeamMember() {
        return (teamMembers[Random.Range(0,teamMembers.Count)]);
    }
    public Player[] randomTeamMembers(int numberOfplayers) {
    Player[] players = new Player[numberOfplayers];
    bool unique;

    for(int i=0;i<numberOfplayers;i++) {
        do {
            players[i] = randomTeamMember();
            unique = true;
             for(int j=0;j<numberOfplayers;j++) {
                   if (j!=i && players[i] == players[j])  {
                       unique = false;
                   }
             }  
          } 
        while (!unique);
        }
        return players;
    }
}
