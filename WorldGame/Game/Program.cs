using System;

namespace MyApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Game.Game game = new Game.Game();
      game.GetWordToGuess();
      game.GetRemainingAttempts();
      // game.GetRandomWordFromDictionary();
      Console.Write("Checking if it's working!");
    }
  }
}
