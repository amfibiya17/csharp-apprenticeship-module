using System;

namespace MyApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Game.WordChoser wordChoser = new Game.WordChoser();
      Game.Game game = new Game.Game(wordChoser);

      System.Console.WriteLine("Welcome! Today the word to guess is:");

      do
      {
        System.Console.WriteLine(game.GetWordToGuess());
        System.Console.WriteLine($"Enter one letter to guess ({game.GetRemainingAttempts()} attempts remaining):");
        
        char letter = System.Console.ReadKey().KeyChar;

        if (game.GuessLetter(letter) == true) {
          System.Console.WriteLine("\nYour guess is right!");
          
        } else {
          System.Console.WriteLine("\nYour guess is wrong...");
        }
      } while (game.counter >= 1);
    }
  }
}
