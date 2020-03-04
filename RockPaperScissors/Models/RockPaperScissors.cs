using System;

namespace RockPaperScissors.Models
{
    public class Game
    {
        public string Player1;
        public string Player2;
        
        public Game(string player1, string player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public string FindWinner()
        {
            string gameWinner = "";
            if (Player1 == Player2)
            {
            gameWinner = "Try again!";
            }
            else if (Player1 == "rock" && Player2 == "paper")
            {
            gameWinner = "Player 2 wins!";
            }
            else if (Player2 == "rock" && Player1 == "paper")
            {
            gameWinner = "Player 1 wins!";
            }
            else if (Player1 == "rock" && Player2 == "scissors")
            {
            gameWinner = "Player 1 wins!";
            }
            else if (Player2 == "rock" && Player1 == "scissors")
            {
            gameWinner = "Player 2 wins!";
            }
            else if (Player1 == "scissors" && Player2 == "paper")
            {
            gameWinner = "Player 1 wins!";
            }
            else if (Player2 == "scissors" && Player1 == "paper")
            {
            gameWinner = "Player 2 wins!";
            }
            return gameWinner;
        }
    }
}   