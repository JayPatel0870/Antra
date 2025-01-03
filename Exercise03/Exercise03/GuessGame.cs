using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class GuessGame
    {
        public void game()
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Enter your guess: ");
            int guess = Convert.ToInt16(Console.ReadLine());
            if (guess > 3 || guess < 1)
            {
                Console.WriteLine("Invalid Entry");
            }
            else if (guess > correctNumber)
            {
                Console.WriteLine("Your Guess is High");
            }
            else if (guess < correctNumber)
            {
                Console.WriteLine("Your Guess is Low");
            }
            else
            {
                Console.WriteLine("Correct Answer");
            }

        }
    }
}
