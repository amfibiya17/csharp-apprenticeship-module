# Your first C# program

C# is a very popular language in the software world. It can be used to build a lot of different kinds of programs, including desktop, mobile and web applications. If you've previously learned a language like Ruby or Javascript, C# is going to feel really different in a number of ways - but you won't encounter anything that you cannot learn!

First things first, in this section we're going to build our first C# program. This will be a simple program that will print `Hello, Makers!` on the terminal. By writing and then executing this program, we'll learn a few things about C#.

<!-- OMITTED -->

## Objectives

 * Install C#.
 * Write a C# class.
 * Compile a C# class.
 * Run a C# class.
 * Understand the difference between compiling and running.
 * Understand that errors can happen at compile time, others at runtime.

## Installing C#

```
brew install dotnet-sdk
```

Once this is done, you should be able to check the installed .Net version by typing `dotnet --version` in the terminal. Example:

```
dotnet --version

6.0.301
```

## Hello, C#

<!-- OMITTED -->

We'll start by making a *.Net Project*. It's likely that you'll be working within a project whenever you're programming in C#, so we may as well start now. Here's the command you'll need:
```zsh
dotnet new console --name CSharp.Intro
```
That command should make a new folder wherever you are called "CSharp.Intro". This might seem like a weird folder name, but it's pretty standard for C# and .Net. You'll want to work in that folder for a while, so you might want to open it in VS Code.

Write the following code into the file named `Program.cs` in your CSharp.Intro folder, replacing what's already there. Maybe you'll see some similarities with the syntax of programming languages you've previously learned, and notice some other things that are different. Be sure to make a note of anything you're unsure about.

<!-- OMITTED -->

```cs
// imports classes, such as `Console` that are defined in the `System` namespace
using System;

// a `namespace` is a container (or scope) for classes
namespace CSharp.Intro
{
    // this is a class - don't worry about the `internal` bit for now
    internal class Program
    {
        // static methods are like Ruby's class methods
        // void means that this method returns nothing
        // the main method takes an array of strings as an arg - `string[]`
        static void Main(string[] args)
        {
            // The main method is called automatically when you execute the program
            // When that happens, you'll see "Hello, Makers!" printed to the terminal
            Console.WriteLine("Hello Makers!");
        }
    }
}
```

We're now going to run the following command:
```
dotnet build
```
 
Use `ls` to list the files in this directory. What new folders do you notice? What does `bin` mean?

Let's now run this other command:

```zsh
./bin/Debug/net6.0/CSharp.Intro 
```

If everything worked, you should see the message "Hello, Makers!" printed to the terminal. Congratulations, you just wrote your first C# program!

A few important things to take from it:
  * In C#, all the code is written within classes. Our program needs to have at least one class — the main class, here called `Program`.
  * This class name doesn't matter, but it needs to implement a `Main` method similar to the one above. This is the *entry point* of the code when the program starts.

## Compilation and runtime

You've noticed we had to go through two different steps to run this program, rather than just one, like you would do with a Ruby program, for example. But why is that? Do C# engineers just like having twice as much work to do, compared to Ruby developers?

Probably not. The truth is that, C# is different from a language like Ruby (or Javascript) in the way programs are created and run. In a language like Ruby, the code is read and interpreted by the Ruby interpreter (the `ruby` program) and executed at the same time.

In C#, however, a C# file needs first to be *compiled* to an executable program. You might notice that we called that compiled program - it's called `CSharp.Intro` and it's sitting in our `bin/Debug/net6.0` directory. That program's just sitting there, though - we need to explicitly call it to run it.

## Exercise: a second program

Let's have a look at a slightly more complex C# program:
```cs
using System;

namespace CSharp.Intro
{
  class Calculator
  {
    // what does this method return?
    public void Calculate()
    {
      // note that the we have to declare a type (int) for the variable (result)
      int result = 2 + 2;
      Console.WriteLine("The result is {0:d}", result);
    }
  }
}
```

<!-- OMITTED -->

1. *Compile* this C# code using `dotnet build`.
2. *Run* the compiled C# code using `./bin/Debug/net6.0/CSharp.Intro`.

What do you see?

```zsh
Hello, Makers!
```

Oops! We didn't call our new class :flushed:

Let's update our Program class to call it:
```cs
static void Main(string[] args)
{
    new Calculator().Calculate();
}
```

If you've done the above correctly, you should see the following printed in the terminal:
```
The result is 4
```

## Run, Dotnet, Run

Instead of first compiling with `dotnet build`, and then running the program with `./bin/Debug/net6.0/CSharp.Intro`, we can do both in one step and write:

```bash
$ dotnet run
The result is 4
```

## About Return Types / Into The Void

When a C# method doesn't need to return anything, the `void` keyword is used in the method declaration.

```csharp
public void Hello() {
  System.Console.WriteLine("Hello");
}
```

If, however, method is going to return something the type of that return value is used instead.

```csharp
// A method that returns an int

public int FavouriteNumber() {
  return 100;
}

// A method that returns a string

public string Name() {
  return "Jolene";
}
```

If the method returns something other than an `int` or `string` the type of that other thing must be used in the method signature instead.

> The next few methods you define will not return anything, so you should use `void`, but pretty soon you'll need to use something else :)

## Exercise: displaying the time

<!-- OMITTED -->

To complete this exercise, you'll have to:
  * Define a new class and call it from your `Main` method.
  * Use `Console.WriteLine`.
  * Use the `DateTime` class.

### Questions

1. Write a class `Clock` that implements a `DisplayTime` method.
2. Implement this method so it prints the current time in the terminal, like this:

```bash
$ dotnet run
The current time is 15:05
```


[Next Challenge](02_compile_error.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/01_first_csharp_program.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/01_first_csharp_program.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/01_first_csharp_program.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/01_first_csharp_program.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/01_first_csharp_program.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
