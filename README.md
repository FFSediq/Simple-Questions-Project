# Simple Wellness & RPS Game

A beginner-friendly C# Console Application that interacts with the user, performs wellness checks, and includes a built-in Rock-Paper-Scissors game to cheer you up!

## 🚀 Features

- **User Validation**: Uses `while` loops to ensure the user provides valid input.
- **Normalisation**: Automatically handles case-sensitivity using `.ToLower()` and `.ToUpper()`.
- **Nested Logic**: A branching story-line that reacts to the user's emotional state.
- **Mini-game**: A fully functional Rock-Paper-Scissors game against a Randomized AI.

## 🛠️ Concepts Used

This project was built to practice the core fundamentals of C#:
* **Variables & Data Types**: Storing names and choices.
* **Control Flow**: `if`, `else if`, and `else` statements.
* **Loops**: `while` loops for input validation and game cycles.
* **Randomization**: Using the `Random` class for AI decision-making.
* **Switch Case**: For clean translation of numeric values to game choices.

## 📖 How to Play

1. **Run the application.**
2. **Enter your name.**
3. **Wellness Check**: Tell the computer how you are doing (Good/Bad).
4. **Secret Branch**: If you say "bad", the computer will offer help. If you accept, a game of **Rock-Paper-Scissors** begins!

## 💻 Code Example

One of the key features of this project is the input validation loop:

```csharp
while (wellnessInput != "good" && wellnessInput != "bad")
{
    Console.Write("How are you doing? (Good/Bad): ");
    wellnessInput = Console.ReadLine().ToLower();
}


Hope you enjoy!
