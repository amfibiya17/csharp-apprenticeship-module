# Building a word-guessing game - Part V

## Objectives 

* All of the previous objectives!

We're now able to play our game using the CLI to guess the word - however we still have to implement the game over function.

## Exercise - winning or losing

1. What attribute do we need to check in order to determine if the player has lost the game?
2. Test-drive an `IsGameLost` method that informs whether, or not, the game has been lost. This test should setup the game data so we're simulating a game that has been lost — perhaps by directly calling `GuessLetter` enough times with wrong letters on purpose.
3. Implement the method `IsGameLost`.
4. Use this new method in the `Program` class to check if the game has been lost after guessing a letter. Depending on its result, display a message and exit the game loop.
5. Repeat the above steps to implement the method `IsGameWon` that verifies whether the game has been won (i.e the player has guessed the whole word).

## Exercise - debugging 

<!-- OMITTED -->

Someone in your cohort has finished coding the method `IsGameWon` — they came up with a rather simple solution and they're pretty happy with it. They can simply check that the number of letters guessed is equal to the number of letters in the word, minus 1 (the first letter of the word):

```csharp
// Game.cs

public bool IsGameWon() {
    return guessedLetters.Count() == word.Length - 1;
}
```

They've also added this code in the game loop in `Program.cs`:
```csharp
// Program.cs

if (game.IsGameWon()) {
    System.Console.WriteLine("Yeaaah! You won!");

    return;
}
```

However, when you try to run their game, you discover a bug: you found all the right letters for the word `LONDON`, but the game doesn't say you've won!

```
Welcome! Today the word to guess is:
L_____
Enter one letter to guess:
O
Right!
LO__O_
Enter one letter to guess:
N
Right!
LON_ON
Enter one letter to guess:
D
Right!
LONDON
Enter one letter to guess:
```

1. Can you see what the problem is? Even if you can't find it right away, intuitively, what is a special feature of the word "LONDON"?
2. Write a test that verifies the `IsGameWon` method is working correctly when the word to guess contains more than one occurrence of the same letter (you can use "DEVELOPER" or "COOL").
3. Implement `IsGameWon` so it passes this test as well — maybe your first solution was already working fine for this – in that case, well done!


<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/09_challenge_game_over.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/09_challenge_game_over.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/09_challenge_game_over.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/09_challenge_game_over.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/09_challenge_game_over.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
