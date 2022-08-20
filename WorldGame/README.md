C# Word Game (README in progress )
===

## What is this project about
This is an old school favorite — a word-guessing game in the terminal!   
Here's the specification for this game:
- When the game starts, it will choose a random word from a list of words
- The game will then display the word to guess, with only the first letter visible (e.g H____ for "HOUSE")
- The player starts a counter of 10 attempts
- The player will then be prompted to enter a letter they think might be in the word
- If the letter is in the word, the game will display the word to guess, with the new letter visible
- If the letter is not in the word, the game will display the same letters as before, and decrease the counter of remaining attempts
- If the counter of attempts reaches zero, the player loses
- If the player finds all the letters in the word, they win

---


## Examples of usage:  

When the user wins:  
![screen1](https://i.postimg.cc/L84yG33x/Screenshot-2022-08-20-at-13-05-54.png)    

When the user lost:  
![screen2](https://i.postimg.cc/8sQ2hJ2q/Screenshot-2022-08-20-at-13-06-39.png)  


---


## How to run the program    

```
dotnet run
```
---