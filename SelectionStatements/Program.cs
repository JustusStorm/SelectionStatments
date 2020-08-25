using System;
using System.Threading;
using Custom;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0; // amount of user guesses
            int maxCount = 4;
            
            Random rand = new Random();
            int number = rand.Next(1, 20);


            Console.WriteLine("I'm thinking of a number 1 to 20. I bet you can't guess what it is.");
            UI.Spacer();
            
            for ( ; count <= 4; count++) // user is only allowed 4 guesses
            {

                if (count == 4)
                {
                    Console.WriteLine("You are out of guesses! The game is over!\n" +
                        "Press Enter to end program...");
                    Console.ReadKey();
                    break;
                }
                else if (maxCount - count == 1)
                {
                    Console.WriteLine($"You have {maxCount - count} guess left. This is your last guess!");
                }
                else
                {
                    Console.WriteLine($"You have {maxCount - count} guesses left.");
                }

                UI.Spacer();
                Console.Write("Guess a number 1-20 ==>  ");
                
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == number)
                {
                    Console.WriteLine("Great job, you got my number correct!");
                    break;
                }
                else if (userGuess > number)
                {
                    Console.WriteLine("Your guess is higher than my number!");
                }
                else
                {
                    Console.WriteLine("Your guess is lower than my number!");
                }
            }
        }
    }
}
