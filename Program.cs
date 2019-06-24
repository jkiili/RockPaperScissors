using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string rounds = " ";
            int i = 0;
            int uWins = 0, cWins = 0, tie = 0, gameCount = 0;
            bool keepPlaying = true;
            while (keepPlaying)
            {
                Console.WriteLine("How many games of Rock, Paper, Scissors would you like to play?");
                rounds = Console.ReadLine();
                if (int.TryParse(rounds, out i))
                {
                    while (gameCount < i)
                    {
                        Console.WriteLine("What's your pick? 1 = Rock, 2 = Paper, 3 = Scissors");
                        {
                            if (i < 1 || i > 10)
                            {
                                Console.WriteLine("Enter a number between 1 - 10.");
                                continue;
                            }
                        }
                        int userChoice = Convert.ToInt32(Console.ReadLine()), compChoice;
                        Random rand = new Random();
                        compChoice = rand.Next(1, 4);
                        Console.WriteLine("The computer chose " + compChoice);
                        if ((((userChoice == 1) && (compChoice == 3)) || ((userChoice == 3) && (compChoice == 2)) || ((userChoice == 2) && (compChoice == 1))))
                        {
                            Console.WriteLine("\n You won!");
                            ++uWins;
                            ++gameCount;
                        }
                        else if (((userChoice == 1) && (compChoice == 2)) || ((userChoice == 2) && (compChoice == 3)) || ((userChoice == 3) && (compChoice == 1)))
                        {
                            Console.WriteLine("\n You lost.");
                            ++cWins;
                            ++gameCount;
                        }
                        else if (userChoice == compChoice)
                        {
                            Console.WriteLine("\n It's a tie.");
                            ++tie;
                            ++gameCount;
                        }
                        else if (userChoice != 1 || userChoice != 2 || userChoice != 3)
                        {
                            Console.WriteLine("Invalid option. Choose 1 = Rock, 2 = Paper, 3 = Scissors ");
                            continue;
                        }
                        Console.WriteLine("The final results are in!\n");
                        if (uWins > cWins)
                        {
                            Console.WriteLine("XXXX\nYOU WON!\nXXXX\n");
                        }
                        else if (cWins > uWins)
                        {
                            Console.WriteLine("XXXX\nCOMPUTER WON!\nXXXX\n");
                        }
                        else
                        {
                            Console.WriteLine("XXXX\nIt's a tie!\nXXXX\n");
                        }
                        Console.WriteLine("Do you want to keep playing? Y or N");
                        string response = null; // Why does this have to be null?
                        response = Console.ReadLine();
                        if (response == "n")
                            keepPlaying = false;
                    }
                }
                else
                {
                    Console.WriteLine("Enter a number between 1 - 10.");
                    continue;
                }
            }
        }
    }
}
