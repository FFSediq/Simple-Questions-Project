using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            string wellnessInput = "";

            while (wellnessInput != "good" && wellnessInput != "bad")
            {
                Console.Write($"Hi {name}, how are you doing? (Good/Bad): ");
                wellnessInput = Console.ReadLine().ToLower();

                if (wellnessInput == "good")
                {
                    Console.WriteLine($"Ah {name}, glad to hear you're doing well!");
                }
                else if (wellnessInput == "bad")
                {
                    Console.WriteLine($"Ah {name}, that's unfortunate!");
                    Console.WriteLine("Do you want help?");
                    string helpAnswer = Console.ReadLine().ToLower();

                    if (helpAnswer == "yes")
                    {
                        Console.WriteLine("Lets help!");
                        Console.WriteLine("We gonna play a game to cheer you up!");
                        Console.WriteLine($"{name}! Rock Paper Scissors!");

                        // --- START ROCK PAPER SCISSORS ---
                        Random random = new Random();
                        string player = "";
                        string computer = "";

                        // Checking if player choice 
                        while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                        {
                            Console.Write("Choose ROCK, PAPER, or SCISSORS: ");
                            player = Console.ReadLine().ToUpper();
                        }

                        // Computer makes choice
                        switch (random.Next(1, 4))
                        {
                            case 1: computer = "ROCK"; break;
                            case 2: computer = "PAPER"; break;
                            case 3: computer = "SCISSORS"; break;
                        }

                        Console.WriteLine($"Computer chose: {computer}");

                        // Who is the winner
                        if (player == computer)
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if ((player == "ROCK" && computer == "SCISSORS") ||
                                 (player == "PAPER" && computer == "ROCK") ||
                                 (player == "SCISSORS" && computer == "PAPER"))
                        {
                            Console.WriteLine("You WIN! I hope that makes you feel better!");
                        }
                        else
                        {
                            Console.WriteLine("Computer wins! But hey, it was close.");
                        }
                        // End Game
                        
                    }
                    else if (helpAnswer == "no")
                    {
                        Console.WriteLine($"I Understand {name}, sometimes you need your own space!");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry {name} i can't understand you");
                    }
                }
                else
                {
                    Console.WriteLine($"Please {name}, put a valid answer!");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}