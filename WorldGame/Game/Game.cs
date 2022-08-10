using System;
using System.Text;

namespace Game{
  public class Game
  {
    int counter;
    string wordToGuess;
    public Game(WordChoser wordChoser) // <- it means that you need to give a WordChoser(type) when you create a game and we will call it wordChoser
    {
      counter = 10;
      wordToGuess = wordChoser.GetRandomWordFromDictionary(); //<- assign the result of the method on the injected dependency
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
