using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "Y";

        while (choice == "Y")
        {
            
            Random rng = new Random();
            int magicNumber = rng.Next(0,100);

            int guessNumber = 0;
            int userGuess = -1;

            Console.WriteLine("I have a magic number, and you must guess it.");

            while (userGuess != magicNumber)
            {
                
            Console.Write("Enter your guess:  ");
            userGuess = int.Parse(Console.ReadLine());
            guessNumber += 1;

            if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                } else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                } else
                {
                    Console.WriteLine($"That is correct! You got in in {guessNumber} guesses");
                }

            }

            Console.Write("Would you like to play again? (Y/N).  ");
            choice = Console.ReadLine();


        }
        


    }
}