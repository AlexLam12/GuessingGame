using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 43;
            int turnCounter = 1;

            Console.WriteLine("Guess the secret number: ");

            int answer = int.Parse(Console.ReadLine());

                
            while (turnCounter < 4)
            {
                if (answer == secretNumber)
                {
                Console.WriteLine("Your answer was correct!");
                break;
                } else {
                    Console.WriteLine($"Your guess {turnCounter} was wrong, guess again");
                }
                turnCounter++;
                answer = int.Parse(Console.ReadLine());
            }
        }
    }
}