using System;
using System.Text;

namespace Game{
  public class Game
  {
    string wordToGuess;
    int counter;
    public Game(string word) 
    {
      wordToGuess = word;
      counter = 10;
    }

    // public int GetCounter
    // {
    //   get
    //   {
    //     return counter;
    //   }
    // }

    public string GetWordToGuess() 
    {
      StringBuilder clue = new StringBuilder();
      for (int i = 0; i < wordToGuess.Length; i++)
      {
        if (i == 0)
        {
          clue.Append(wordToGuess[i]);
        } else {
          clue.Append("_");
        }
      }
      return clue.ToString();
    }
    public int GetRemainingAttempts()
    {
      return counter;
    }
  }
}
