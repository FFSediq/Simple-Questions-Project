using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                }
                else
                {
                    
                    Console.WriteLine($"Please {name}, put a valid answer!");
                }
            }
            

        }



    }
    }
}
