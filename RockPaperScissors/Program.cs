using System;
using System.Collections.Generic;
using RockPaperScissors.Models;
namespace RockPaperScissors.Program
{
    public class Program
    {
        public static void Main()
        {
            Console.ResetColor();
            Console.Clear();
            Program.ChooseGame();
        }

        public static void ChooseGame()
        {
            Program.TypeLine("Would you like to play PvP, or PvC?");
            string userGameChoice = Console.ReadLine().ToLower();

            Game newGame = new Game("", "", userGameChoice);

            if (newGame.UserGameChoice == "pvc")
            {
                Program.PlayerVsComputer(newGame);
            }
            else if (newGame.UserGameChoice == "pvp")
            {
                Program.PlayerVsPlayer(newGame);
            }
        }
        public static void PlayerVsComputer(Game newGame)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Environment.NewLine);
            Program.TypeLine("Player 1 enter rock, paper, or scissors");
            string userInput = Console.ReadLine();
            Program.CheckWordAgainstlist(userInput, newGame);
        }
        public static void PlayerVsPlayer(Game newGame)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Environment.NewLine);
            Program.TypeLine("Player 1 enter rock, paper, or scissors");
            string password1 = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password1 += key.KeyChar;
            }
            newGame.Player1 = password1;
            Program.CheckWordAgainstlist(password1, newGame);

            Program.TypeLine("Player 2 enter rock, paper, or scissors");
            string password2 = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password2 += key.KeyChar;
            }
            Program.CheckWordAgainstlist(password2, newGame);
            Program.TypeLine("------------------------");
            newGame.Player1 = password1;
            newGame.Player2 = password2;
            // Game newGame1 = new Game(password1, password2, userGameChoice);

            Program.readResultsPVP(password1, password2, newGame);
        }
        public static void CheckWordAgainstlist(string userInput, Game newGame)
        {
            List<string> possibleResponses = new List<string> { "rock", "paper", "scissors" };
            // string userInput = Console.ReadLine();
            if (newGame.UserGameChoice == "pvc")
            {
                if (!possibleResponses.Contains(userInput))
                {
                    Console.Write(Environment.NewLine);
                    Program.TypeLine("No, you must enter 'rock', 'paper' or 'scissors'!");
                    Program.PlayerVsComputer(newGame);
                }
                else
                {
                    Console.Clear();
                    string result = Program.numberGenerator();
                    // Game newGame = new Game(userInput, result);
                    Program.readResultsPVC(userInput, result, newGame);
                    Console.ResetColor();
                }

            }
            else if (newGame.UserGameChoice == "pvp")
            {
                if (!possibleResponses.Contains(userInput))
                {
                    Console.Write(Environment.NewLine);
                    Program.TypeLine("No, you must enter 'rock', 'paper' or 'scissors'!");
                    Program.PlayerVsPlayer(newGame);
                }
                else
                {
                    Console.Clear();
                    // string result = Program.numberGenerator();
                    // Game newGame = new Game(userInput, result);
                    Program.readResultsPVP(newGame.Player1, newGame.Player2, newGame);
                    Console.ResetColor();
                }
            }

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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Environment.NewLine);
            Program.TypeLine("Player 1 chose: " + userInput);
            Program.TypeLine("computer chose: " + result);
            Program.TypeLine("------------------------");
            Program.TypeLine(newGame.FindWinner());
            Console.ResetColor();
        }
        public static void readResultsPVP(string userInput, string password, Game newGame)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Environment.NewLine);
            Program.TypeLine("Player 1 chose: " + userInput);
            Program.TypeLine("Player 2 chose: " + password);
            Program.TypeLine("------------------------");
            Program.TypeLine(newGame.FindWinner());
            Console.ResetColor();
        }



        public static void TypeLine(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                System.Threading.Thread.Sleep(25);
            }
            Console.Write(Environment.NewLine);
            Console.Write(Environment.NewLine);
        }

    }
}
