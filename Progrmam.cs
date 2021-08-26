using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number: ");
            int answer = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your answer was {answer}");
        }
    }
}