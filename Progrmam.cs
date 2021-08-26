using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 43;
            Console.WriteLine("Guess the secret number: ");
            int answer = int.Parse(Console.ReadLine());
            if (answer == secretNumber)
            {
            Console.WriteLine("Your answer was correct!");
            } else {
                Console.WriteLine("Your answer was wrong :(");
            }
        }
    }
}