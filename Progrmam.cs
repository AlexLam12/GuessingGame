using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1,100);
            int turnCounter = 4;
            int difficulty = 0;

            Console.WriteLine("Guess the secret number");
            Console.WriteLine($"{secretNumber}");
            Console.WriteLine("Choose a difficulty 1, 2, or 3");
            while(difficulty == 0)
            {
                switch(int.Parse(Console.ReadLine()))
                {
                   case 1:
                        difficulty = 1;
                        turnCounter = 8;
                        Console.WriteLine("You have eight guesses to find the secret number, start guessing!");
                        break;

                    case 2:
                        difficulty = 2;
                        turnCounter = 6;
                        Console.WriteLine("You have six guesses to find the secret number, start guessing!");
                        break;

                    case 3:
                        difficulty = 3;
                        turnCounter = 4;
                        Console.WriteLine("You have four guesses to find the secret number, start guessing!");
                        break;

                    default:
                        Console.WriteLine("You must enter a number between 1 and 3 to continue:");
                        break; 
                }
            }

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