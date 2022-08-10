using System;

namespace MyApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Game.WordChoser wordChoser = new Game.WordChoser();
      Game.Game game = new Game.Game(wordChoser);
      game.GetWordToGuess();
      game.GetRemainingAttempts();
      wordChoser.GetRandomWordFromDictionary();
      Console.Write("Checking if it's working!");
    }
  }
}
