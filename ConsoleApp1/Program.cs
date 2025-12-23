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
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write($"Hi {name} ,  how are you doing? : Good or bad? : "  );
                string wellnessInput = Console.ReadLine();
                wellnessInput.ToLower();

                bool wellness = (wellnessInput == "good");

                if ( wellness )
                {
                    Console.WriteLine($"Ah {name} , You are doing {wellness} at this moment! ");
                }
                else if ( wellness )
                {
                    Console.WriteLine($"Ah {name} , That's unfortunate!");
                }
                else
                {
                    Console.WriteLine($"Please {name} put a valid answer!";
                }

            }

            

            }
    }
}
