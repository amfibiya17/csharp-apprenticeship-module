# Building a word-guessing game - Part II

So far the `Game` class is doing two things:
 * It picks a random word from the `DICTIONARY`
 * It displays the word to guess with hidden letters

It looks like there is an opportunity for us to tidy the codebase and achieve better separation of concerns.

## Objectives 
 * Extract functionality to a new class.
 * Use dependency injection.
 * Mock a class and stub a method result in a unit test.

## Exercise - extracting the random word

<!-- OMITTED -->

To complete this exercise, you'll need to:
  * Create a new class.
  * Use dependency injection to inject a class instance into the `Game` constructor.

### Questions

1. Write the tests for a new `WordChoser` class that will contain the `DICTIONARY` array attribute as well as the `GetRandomWordFromDictionary()` method. Those things will then be moved from `Game` to this new class.
2. Make sure the `Game` class calls the method `GetRandomWordFromDictionary` of a `WordChoser` instance to get a random word.

## Installing NSubstitute

<!-- OMITTED -->

We'll use the NSubstitute library in order to mock classes and isolate our unit tests. Let's add it to our `Game.Tests` project now.

When the current directory is `Game.Tests`

```shell
; dotnet add package nsubstitute
```

## Exercise - mocking `WordChoser`

To complete this exercise, you'll need to:
  * [Use NSubstitute to create a mock of a class](https://nsubstitute.github.io/help/creating-a-substitute/)
  * [Stub the return value](https://nsubstitute.github.io/help/set-return-value/) for the mock class's `GetRandomWordFromDictionary` method

> IMPORTANT: NSubstitute's guidance will suggest that you mock an `Interface` rather than a `Class`. Ignore that for now, and mock your `WordChoser` class, but note that you'll need to mark the `GetRandomWordFromDictionary` method as being `virtual` so that [NSubstitute can override it](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual).

### Questions

1. Modify your `Game` tests so they mock the `WordChoser` class (to get a predictable word) and inject this mock into `Game`. If something seems wrong, make sure you've stubbed the `GetRandomWordFromDictionary` method *before* it is called to get the word.

> Note: You'll know if you've mocked `WordChoser` correctly if you can change all the words in the `WordChoser` dictionary to different ones, but the `GameTest` tests still pass.

## Exercise: debugging

<!-- OMITTED -->

Someone from your cohort worked on the previous exercise to implement the class `WordChoser` and mock it in the `GameTest` test class. However, their test does not work — it seems the word is always chosen at random, even when testing. Here's the test they wrote, and the `Game` constructor:

```csharp
// GameTest.cs

[Test]
public void WordToGuess_ReturnsRandomWordFromWordChoser() {
    WordChoser mockWordChoser = Substitute.For<WordChoser>;
    mockWordChoser.GetRandomWordFromDictionary().Returns("DEVELOPER")

    Game game = new Game();

    assertEquals(game.getWordToGuess(), "D________");
}
```

```java
// Game.java

public Game() {
    WordChoser chooser = new WordChoser();
    this.word = chooser.getRandomWordFromDictionary();
}
```

1. Can you see what the problem is?
2. How would you fix it to make sure the word returned by `GetRandomWordFromDictionary` is *always* "DEVELOPER" when running the tests?

[Next Challenge](07_challenge_player_guesses.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/06_challenge_word_chooser.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/06_challenge_word_chooser.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/06_challenge_word_chooser.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/06_challenge_word_chooser.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/06_challenge_word_chooser.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
