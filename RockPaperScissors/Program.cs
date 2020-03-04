using System;
using RockPaperScissors.Models;
namespace RockPaperScissors.Program
{
    public class Program
    {
        public static void Main()
        {
            Program.ChooseGame();
        }

        public static string numberGenerator()
        {
            Random r = new Random(); int rInt = r.Next(1, 4);
            string computerInput = "";
            if (rInt == 1)
            {
                computerInput = "rock";
            }
            else if (rInt == 2)
            {
                computerInput = "paper";
            }
            else if (rInt == 3)
            {
                computerInput = "scissors";
            }
            return computerInput;
        }

        public static void readResultsPVC(string userInput, string result, Game newGame)
        {
            Console.WriteLine("Player 1 chose: " + userInput);
            Console.WriteLine("computer chose: " + result);
            Console.WriteLine(newGame.FindWinner());
        }
        public static void readResultsPVP(string userInput, string result, Game newGame)
        {
            Console.WriteLine("Player 1 chose: " + userInput);
            Console.WriteLine("Player 2 chose: " + result);
            Console.WriteLine(newGame.FindWinner());
        }

        public static void ChooseGame()
        {
            Console.WriteLine("Would you like to play CvC, PvP, or PvC?");
            string userGameChoice = Console.ReadLine().ToLower();
            if (userGameChoice == "pvc")
            {
                Program.PlayerVsComputer();
            }
            else if (userGameChoice == "pvp")
            {
                Program.PlayerVsPlayer();
            }
        }

        public static void PlayerVsComputer()
        {
            Console.WriteLine("Player 1 enter rock, paper, or scissors");
            string userInput = Console.ReadLine();
            string result = Program.numberGenerator();
            Game newGame = new Game(userInput, result);
            Program.readResultsPVC(userInput, result, newGame);
        }

        public static void PlayerVsPlayer()
        {
            Console.WriteLine("Player 1 enter rock, paper, or scissors");
            string userInput = Console.ReadLine();
            Console.WriteLine("Player 2 enter rock, paper, or scissors");
            string user2Input = Console.ReadLine();
            Game newGame = new Game(userInput, user2Input);
            Program.readResultsPVP(userInput, user2Input, newGame);
        }
    }
}
