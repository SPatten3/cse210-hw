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
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
    }
}