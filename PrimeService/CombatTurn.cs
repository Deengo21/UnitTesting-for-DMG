using System;

namespace Prime.Services
{
    
    public class CombatTurn

    {
    private List<string> players;
    private int currentPlayerIndex = 0;
    
     public CombatTurn (List<string> currentPlayers)
   {

      players = currentPlayers;
      
   }
        public string? GetNextTurn()
        {
            if(players.Count == 0)
            {
                return null;
            }
            string currentPlayer = players [currentPlayerIndex];
            currentPlayerIndex= (currentPlayerIndex+1) % players.Count;
            return currentPlayer;
            

            
        }


    }
    
}