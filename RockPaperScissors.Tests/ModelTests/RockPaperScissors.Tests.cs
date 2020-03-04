using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
[TestClass]

public class RockPaperScissorsTests
{
    [TestMethod]
    public void FindWinner_RockPaper_Player2()
    {
    Game testGame = new Game("rock", "paper");
    // testGame.FindWinner();
    Assert.AreEqual("Player 2 wins!", testGame.FindWinner());
    }

    [TestMethod]
    public void FindWinner_PaperRock_Player1()
    {
    Game testGame = new Game("paper", "rock");
    // testGame.FindWinner();
    Assert.AreEqual("Player 1 wins!", testGame.FindWinner());
    }
    
    [TestMethod]

    public void FindWinner_RockScissors_ReturnPlayer1()
    {
    Game testGame = new Game("rock", "scissors");
    // testGame.FindWinner();
    Assert.AreEqual("Player 1 wins!", testGame.FindWinner());
    }

    [TestMethod]
    public void FindWinner_ScissorsRock_Player2()
    {
    Game testGame = new Game("scissors", "rock");
    // testGame.FindWinner();
    Assert.AreEqual("Player 2 wins!", testGame.FindWinner());
    }

    [TestMethod]
    public void FindWinner_ScissorsPaper_Player1()
    {
    Game testGame = new Game("scissors", "paper");
    // testGame.FindWinner();
    Assert.AreEqual("Player 1 wins!", testGame.FindWinner());
    }

    [TestMethod]
    public void FindWinner_PaperScissors_Player2()
    {
    Game testGame = new Game("paper", "scissors");
    // testGame.FindWinner();
    Assert.AreEqual("Player 2 wins!", testGame.FindWinner());
    }

    [TestMethod]
    public void FindWinner_SameInput_TryAgain()
    {
    Game testGame = new Game("paper", "paper");
    // testGame.FindWinner();
    Assert.AreEqual("Try again!", testGame.FindWinner());
    }
}
}