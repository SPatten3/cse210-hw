using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        int age;

        do
        {
            Console.Write("Enter your age:  ");
            age = int.Parse(Console.ReadLine());
        } while(age < 0 || age > 125);

    }
}