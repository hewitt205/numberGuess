using System;

namespace numberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int win = r.Next(0, 100);

            bool won = false;

            int userGuess = 0;

            Console.WriteLine("Guessing game! \n You know the deal type a number and see if it's right!");
           while(!won)
            {
                Console.WriteLine("Number: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out userGuess);
                if (isNumber)
                {
                    if (userGuess > win)
                    {
                        Console.WriteLine("Too high. . .\n");
                    }
                    else if (userGuess < win)
                    {
                        Console.WriteLine("Too Low. . .\n");
                    }
                    else if (userGuess == win)
                    {
                        Console.WriteLine("You guessed correctly!");
                        won = true;
                    }
                }
               else
                {
                    Console.WriteLine("That isn't an number.");
                }
            }
        }
    }
}
