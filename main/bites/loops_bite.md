# C# Loops

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

<!-- OMITTED -->

Learn to use *loops in C#*.

## Introduction

Loops in C# come in a few forms.

To follow along with the examples and then do the exercises, create a new project (`dotnet new console --name ScratchPad`) and define a `Program` class with a `Main` method (as below) in `Program.cs`, then add your code inside the `Main` method.

```csharp
namespace ScratchPad;
class Program
{
  public static void Main(string[] args)
  {
    // Your code goes here
  }
}
```

### The `while` Loop
`while` loops execute _while_ a given statement is true, then stop.

```csharp
// prints numbers 1 through 10
int counter = 1
while(counter <= 10)
{
  System.Console.WriteLine(counter);
  counter++;
}
```

### The `do-while` loops
`do-while` loops are similar to `while` loops but the statement is checked after each loop. So they'll always execute at least once.

```csharp
// prints number 11, then checks the statement and stops
int counter = 11
do
{
  System.Console.WriteLine(counter);
}
while(counter <= 10)
```

### The `for` loop

`for` executes a specific number of times, using a counter, based on the given statement.

There are three parts to the statement
* The initial value of our counter is `int counter = 1`
* The loop will continue while `counter <= 10`
* At the end of each loop, the counter is incremented by `counter++`

```csharp
// prints "Hello, World" 10 times
for(int counter = 1; counter <= 10; counter++)
{
  System.Console.WriteLine("Hello, World!");
}
```

### The `foreach`

`foreach` loops iterate over every item in a collection, such as an Array. The key part here is `(int number in numbers)`. Using `numbers` we refer to the array of numbers and `number` is a variable which will hold each specific number in turn. Note that we have to declare the type of object (`int`) that `number` will hold.

```csharp
// iterates through the array of numbers, printing each one
int[] numbers = {1,2,3,4,5};
foreach(int number in numbers)
{
  System.Console.WriteLine(number);
}
```

## Demonstration

[Demonstration Video](https://youtu.be/YlXQaNUYzmk)

## Exercise 1

- Using `Random()` to generate random numbers
- Implement `while` a loop that executes, and prints the number, `while` the random number is less than 10

> HINT: use `.Next(<int>)`, where `<int>` is any integer, to set the maximum value for the random number

[Example Solution](https://youtu.be/_y9pItns1Y0)

## Exercise 2

In Exercise 1 we don't get to find out what the final number is, when the loop stops. Use a `do-while` loop to ensure that the number is printed before the statement is evaluated.

[Example Solution](https://youtu.be/GD8tsTySEnU)

## Exercise 3

Use a for loop to print achieve the print the following

```
I had 10 apples
Then I ate one
And 9 remained
Then I ate one
And 8 remained
Then I ate one
And 7 remained
Then I ate one
And 6 remained
Then I ate one
And 5 remained
Then I ate one
And 4 remained
Then I ate one
And 3 remained
Then I ate one
And 2 remained
Then I ate one
And 1 remained
Then I ate one
And 0 remained
```

[Example Solution](https://youtu.be/ctc7iyWYg5M)

## Exercise 4

Do Exercise three again, this time using an array of numbers and a `foreach` loop.

> Which solution do you prefer and why?

[Example Solution](https://youtu.be/R9C5jqKsdaE)

## Challenge

Using any of the above approaches, write a loop that will count the number of vowels in a given word.

Good luck!


<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/bites/loops_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/bites/loops_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/bites/loops_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/bites/loops_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/bites/loops_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
