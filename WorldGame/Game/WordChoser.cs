using System;

namespace Game {
  public class WordChoser {
    string[] DICTIONARY;
    public WordChoser()
    {
      DICTIONARY = new string[] {"MAKERS", "CANDIES", "DEVELOPER", "LONDON"};
    }

    public string GetRandomWordFromDictionary() {
      Random rand = new Random();
      return DICTIONARY[rand.Next(DICTIONARY.Length)];
    }
  }
}