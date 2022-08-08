# ...And your first compile error

Software engineers often spend a large chunk of their time finding and fixing errors in programs — and C# engineers are definitely not exempt from this! In this section, we'll have a look at how a compile error can arise in a C# program. It'll also bring us to an important concept in C#: typing.

## Objectives

 * Understand what a compile error is.
 * Understand what the type of a variable is.
 * Understand the type of variable restricts the number of things we can do with it.
 * Declare a variable with its type.
 * Use `Console.WriteLine` to print the value of a variable.

## Breaking the program

<!-- OMITTED -->

Let's take the previous class `Calculator` and modify it slightly. Replace the line
```cs
int result = 2 + 2;
```

with:

```cs
string result = 2 + 2;
```

You might intuitively think this is going the wrong way. Or maybe not! After all, maybe C# will be smart enough to think we want to combine the two integers 2 and 2 to make the string "22"? Or perhaps "4"?

Let's find out. Once again, run `dotnet run` to compile and run the `Calculator` class. We get a different result this time:

```
/path/to/repo/CSharp.Intro/Calculator.cs(5,23): error CS0029: Cannot implicitly convert type 'int' to 'string' [/path/to/repo/CSharp.Intro/CSharp.Intro.csproj]

The build failed. Fix the build errors and run again.
```

You've just experienced you first *compile* error. This kind of error happens at *compile* time, when `dotnet` uses the C# compiler to transform a C# file into an executable program.

We've also just touched on a very important concept of C# - typing.

## Typing and classes

Simply put, *type* refers to the "kind" of data a variable holds. In a language like Ruby, a given variable can hold any *type* of data. Which is why we can do the following:

```
age = 28
age = "Adam"
```

However, in C#, each variable needs to be assigned a specific *type* and this type cannot be changed later! So we need to be way more thoughtful about what value a variable is going to hold, and what a variable is going to be used for.

<!-- OMITTED -->

Here's a few examples of C# variables:
```cs
int age = 30;

double amount = 99.99;

string name = "Adam";

bool isPriceDiscounted = true; // or false
```

Something that is important to note is that, in C# — like in other languages like Ruby — almost everything is an object. Therefore every object is an instance of a class such as `string` or `int` or `Calculator`. So, when talking about the "type" of a variable, we are actually referring to its class. *Saying that the type of a variable is `String` means that this variable is an instance of the `String` class, and that methods from `String` can be called on it.*

<!-- OMITTED -->

## Exercise - a better calculator

<!-- OMITTED -->

1. What type would we need for our variable `result` to hold the result of `2.5 + 2.5`? Modify the `Calculator` class to reflect this.
2. Compile and run the class again by running `dotnet run`. What error do you get? You might need to do a bit of research about [string formatting in C#](https://zetcode.com/csharp/stringformat/).
3. What change do you need to make in order for the program to work? Make that change and run the code again. If everything went well, you should see the following output in your terminal:
```
The result is 5
```
4. Let's be clear about just how exactly this number is 5, and show that it's 5.000000 (to 6 decimal places). You should see:
```
The result is 5.000000
```

Quite a lot of work just to display the result of an addition! In the next section, we'll see how some tools can make our life easier while programming with C#.

## Exercise - the price is right

<!-- OMITTED -->

1. Write a new class `PriceDisplay` with a `display` method that defines two variables:
    * one holding an item name (such as "Coffee machine")
    * one holding a non-integer price (such as `15.99`)
2. Use `Console.WriteLine` and the format specifiers (using `{0:d}` or similar) to print a string such as `"The price of the item Coffee machine is 15.99"`

## Why bother with types?

<!-- OMITTED -->

You will also have noticed that the type of everything is specified by you, the programmer instead of inferred by the compiler. Why bother to do this? One reason is that it makes it easier to find mistakes and perform automatic fixes.

Let's look at an example - consider the following Ruby program:
```ruby
def longest_name(names)
  longest = ''
  names.each do |name|
    if longest.length < name
      longest = name
    end
  end
  longest
end

people = ['Adam', 'Clara', 'George', 'Jane'];
```

1. Can you spot the problem with this code?
2. Whether or not you found the issue, now run this code in `irb`. Call the `longest_name` function by entering `puts longest_name(people)`.
3. Did the bug happen when *creating* the function, or only when *calling* the function?
4. In C#, would the behaviour with such a bug be the same, or different? Why?
5. To convince yourself, you can run the same code (with the same bug) in C#:

<!-- OMITTED -->

```cs
class LongestName
{
  public string GetLongest(string[] names)
  {
    string longest = "";
    foreach (string name in names)
    {
      if (longest.Length < name)
      {
        longest = name;
      }
    }
    return longest;
  }
}
```

6. Compile and run this code using. What happens? Note that we haven't called the `longestName` method yet, we've just tried to compile the code.
7. From those two examples, what can you say about the benefit of having static typing in C#?


[Next Challenge](03_ide.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/02_compile_error.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/02_compile_error.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/02_compile_error.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/02_compile_error.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=main/02_compile_error.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
