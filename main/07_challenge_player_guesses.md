# Building a word-guessing game - Part III

We'll now have a look at how to implement the next part of the game specifications — guessing the letters of the secret word.

## Objectives 
 * Understanding the difference between `string` and `char` and how they're both defined.
 * Checking if a `char` is in a `string`.
 * Use conditionals.
 * Use `List` to store a dynamic list of values.
 * Define attributes, read and update their values.

## About Strings and Characters

<!-- OMITTED -->

Remember that a string is a series of single characters: "developer" for example, is a string, made of individual characters 'd', 'e', 'v', etc.

In C#, we have types to represent both of them: `string` and `char`. As you guessed, when dealing with only a single character (digit or letter, for example), we can use the `char` type. Be mindful that, unlike other more permissive languages, C# will infer the type of value depending on the quotes used to write literal values: `"developer"` will be a `string` and so too will `"d"` (they both use double quotes). To indicate a character, you should use single quotes — `'d'` or `'e'` will be correctly interpreted as `char` values. 

```csharp
string name = "Tomas";
char firstLetter = 'T';

string city = 'London'; // won't work — single quotes are for characters
```

## Exercise: the `GuessLetter` method

<!-- OMITTED -->

To complete this exercise, you'll need to:
 * Write some tests for the `GuessLetter` method.
 * Use the `char` type.
 * Check if a character is present within a string.
 * Use the [`List` class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0) — it can store a "dynamic" array of values (we can add items to it).

### Questions

1. Test-drive a new method `GuessLetter` which will take one argument – the letter to guess. This new method will need to check that the given letter is *at least once* inside the word to guess.
    * If it is *not* in the word, it will need to decrement the number of remaining attempts.
    * If it is in the word, it should store the fact that this letter has been already guessed — how will you store the letters that have already been guessed?
3. Make sure the `GuessLetter` method returns a value that clearly indicates whether, or not, the guess was correct.  What type will you use here?
4. Make sure your test verifies the return value of `GuessLetter`.
5. If the player tries to guess a letter, it can be either right or wrong. How many different paths can your code then follow? How many test cases will you need to make sure you cover those different paths?

## Exercise: debugging

<!-- OMITTED -->

Someone from your cohort wrote some similar code, however their test does not compile — can you see why? You can replace your own method `GuessLetter` with theirs, to make sure you found all the issues with it.

```csharp
public bool GuessLetter(string letter) {
    if (this.word.IndexOf(letter) == -1) {
        remainingAttempts--;
        return 0;
    } else {
        guessedLetters.Add(letter);
        return 1;
    }
}
```

## Generic types

In C#, the class `List` is what we call a *generic type* (or simply a "generic"). It's similar to Ruby's Array class in that it can be used to store a collection, or list, of things.

One big difference is that, unlike Ruby Arrays, all elements in a C# `List` must be of the same _type_. Why? Well, a list of numbers is not going to have the same size in memory than a list of strings, data objects, or even a list of lists! So C# needs to know what type of thing a `List` will hold so that an appropriate amount of memory can be allocated.

All `List`s have the same functionality, regardless of their contents — we can add, remove and list out all items in the `List`, which is why we call such a type "generic".

When creating a `List`, we must provide a type parameter, like this...

```csharp
// An empty List of strings
List<string> names = new List<string>();
// An empty List of ints
List<int> numbers = new List<int>{1,2,3,4,5};
```

Those would create empty `List`s, that are ready for you to `.Add` some `string`s or `int`s. If you want to create a `List` with some stuff already in it, you can do this...

```csharp
List<string> names = new List<string>{"Sue", "Radha", "Pawel"};
List<int> numbers = new List<int>{1,2,3,4,5};
```

The type parameter can be a native C# class (i.e type), but also a custom class. Therefore, assuming we have a class `Student`, it's possible to declare a `List` of students using `List<Student>`

## Exercise - shopping list

<!-- OMITTED -->

This exercise is a little break from our game. You should work on it in a different project directory. To complete it, you'll have to:
* Write NUnit tests.
* Declare a class and its methods.
* Use the generic type `List` with different type parameters.

### Questions

1. Test-drive a `ShoppingList` class such that:
    * the instance is initialised with an empty list of item names (`string`)
    * it has an `AddItem` method which adds a string to a list of items.
    * it has a `GetItems` method which returns the list of items.
2. Create a new `ShoppingItem` class that holds two properties: a name and a price (`double`). Its constructor can be used to pass the two arguments: `new ShoppingItem("Salad", 6.90)`.
3. Modify the tests and `ShoppingList` class so it holds an array of `ShoppingItem` instances rather than just `string`s. It should therefore be possible to use the class like this:

```csharp
ShoppingList list = new ShoppingList();

list.addItem(new ShoppingItem("HP sauce", 4.99));
list.addItem(new ShoppingItem("Ketchup", 3.99));

list.getItems(); // should return a List<ShoppingItem> of size 2.
```

## Exercise - debugging

<!-- OMITTED -->

Your pair did work on the exercise above, however they get an error when trying to run this code:

```csharp
ShoppingList list = new ShoppingList();

list.addItem(new ShoppingItem('HP sauce', 4.99));
```

[Next Challenge](08_challenge_guessed_letters.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/07_challenge_player_guesses.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/07_challenge_player_guesses.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/07_challenge_player_guesses.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/07_challenge_player_guesses.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/07_challenge_player_guesses.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
