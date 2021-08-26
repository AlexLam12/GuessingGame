using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 43;
            int turnCounter = 4;

            Console.WriteLine("Guess the secret number: ");

            int answer = int.Parse(Console.ReadLine());

                
            while (turnCounter > 1)
            {
                if (answer == secretNumber)
                {
                Console.WriteLine("Your answer was correct!");
                } else {
                    Console.WriteLine("Your answer was wrong, guess again :(");
                }
                turnCounter--;
                answer = int.Parse(Console.ReadLine());
            }
        }
    }
}