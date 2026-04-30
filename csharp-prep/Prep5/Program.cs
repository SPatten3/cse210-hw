using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name:  ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number:  ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int PromptUserBirthYear()
    {
        Console.Write("Enter the year you were born:  ");
        int birthYear = int.Parse(Console.ReadLine());
        return birthYear;
    }

    static int SquareNumber(int favNumber)
    {
        int numberSquared = (int)Math.Pow(favNumber, 2);
        return numberSquared;

    }

    static void DisplayResult(string userName, int birthYear, int favNumber)
    {
        int favNumberSquared = SquareNumber(favNumber);
        Console.WriteLine($"{userName}, the square of your number is {favNumberSquared}.");
        Console.WriteLine($"{userName}, you will turn {2026 - birthYear} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int birthYear = PromptUserBirthYear();
        DisplayResult(name, birthYear, favNumber);
    }
}