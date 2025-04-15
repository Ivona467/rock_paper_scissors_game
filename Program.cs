using System;
using System.ComponentModel.Design;

namespace RockPaperScissorsGame
{
    class Game
    {

        const string Rock = "Rock";
        const string Paper = "Paper";
        const string Scissors = "Scissors";

        static void Main(string[] args)
        {
            Console.WriteLine("Choose [r]ock , [p]aper, or [s]cissors:");

            string userInput = Console.ReadLine().ToLower();
            string userChoice = "";

            if (userInput == "r" || userInput == "rock")
            {
                userChoice = Rock;
            }
            else if (userInput == "p" || userInput == "paper") 

            {
                userChoice = Paper;
            }
            else if (userInput == "s" || userInput == "scissors")
            {
                userChoice = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid input. Please chooce rock,paper, or scissors.");
                return;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerChoice = "";

            switch (computerRandomNumber)
            {
                case 1:
                    computerChoice = Rock;
                    break;
                case 2:
                    computerChoice = Scissors;
                    break;
                case 3:
                    computerChoice = Paper;
                    break;
            }
            Console.WriteLine($"The computer chose {computerChoice}.");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It is a draw!");
            }
            else if ((userChoice == Rock && computerChoice == Scissors) ||
                (userChoice == Scissors && computerChoice == Paper) ||
                (userChoice == Paper && computerChoice == Rock))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}
        