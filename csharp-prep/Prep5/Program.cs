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
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int birthYear = PromptUserBirthYear();
    }
}