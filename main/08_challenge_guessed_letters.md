# Building a word-guessing game - Part IV

## Objectives 

* Use the `Main` method to create a CLI program.
* Use a loop.
* Read user input.
* Instantiate classes and use them from the `Main` method.

## Exercise 1: showing guessed letters

1. Duplicate the test you've written for `getWordToGuess` earlier. This time, we'll extend this test so it calls `guessLetter` to guess one letter that we know is in the word. For example, if the word is "DEVELOPER", we could call `guessLetter("E")`.
2. Assuming the word to guess is "DEVELOPER" — if we call `guessLetter("E")` and this method has been correctly implemented, what string should `getWordToGuess()` return?
3. Make sure this new test verifies the new value from `getWordToGuess()` is correct, after guessing correctly one letter.

## Exercise 2: using the CLI

To complete this exercise, you'll have to:
 * Implement a `Main` method for the `Program` class.
 * Use `System.Console.ReadKey().KeyChar` to read a letter entered in the terminal.
 * Use `System.Console.WriteLine` to print to the terminal.
 * Use a loop.

We should end up with a very simple version of the game, that we can interact with using the terminal, as shown below:

```
Welcome! Today the word to guess is:
L_____
Enter one letter to guess (10 attempts remaining):
N
Right!
L_N__N
Enter one letter to guess (10 attempts remaining):
K
Wrong...
L_N__N
Enter one letter to guess (9 attempts remaining):
O
Right!
LON_ON
Enter one letter to guess (9 attempts remaining):
(...)
```

(and yes, as you probably guessed, the word is "LONDON"!)


1. Modify the `Main` method in `Program.cs` so it instantiates the `Game` class and prints out the word to guess in the terminal. When running the app, you should now see a hidden word, such as `M_____`.
2. Implement the game loop that keeps asking the player to enter one letter (you'll likely need to do a bit of research on how to read user input). Use the `GuessLetter` method to then indicate whether the player did guess correctly one letter or not.
3. Indicate the number of remaining attempts inside the CLI prompt.

## Exercise - debugging

Someone from your cohort wrote the following code in the `Main` method, however when trying out the game, it doesn't behave at all as expected. They also tell you they've used a [`do-while` loop](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement) to implement the game loop. Can you find out what the problem is?

```csharp
WordChoser chooser = new WordChoser();
Game game = new Game(chooser);
System.Console.WriteLine("Welcome! Today the word to guess is:");

do {
    System.Console.WriteLine(game.GetWordToGuess());

    System.Console.WriteLine("Enter one letter to guess:");

    char guess = System.Console.ReadKey().KeyChar;
    Boolean result = game.guessLetter(guess);

    if () {
        System.Console.WriteLine("Right!");
    } else {
        System.Console.WriteLine("Wrong...");
    }
} while (result);
```

[Next Challenge](09_challenge_game_over.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/08_challenge_guessed_letters.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/08_challenge_guessed_letters.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/08_challenge_guessed_letters.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/08_challenge_guessed_letters.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/08_challenge_guessed_letters.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
