using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1,100);
            int turnCounter = 4;

            Console.WriteLine("Guess the secret number: ");
            Console.WriteLine($"{secretNumber}");

            int answer = int.Parse(Console.ReadLine());

                
            while (turnCounter > 1)
            {
                string tooHigh = "too high";

                if (answer < secretNumber)
                {
                    tooHigh = "too low";
                }
                if (answer == secretNumber)
                {
                Console.WriteLine("Your answer was correct!");
                break;
                } else {
                    Console.WriteLine($"Your guess was {tooHigh}, you have {turnCounter-1} guesses left, guess again");
                }
                

                turnCounter--;
                answer = int.Parse(Console.ReadLine());
            }
        }
    }
}