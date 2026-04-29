using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> ints = new List<int>();
        int newInt;
        int sum = 0;
        int largestNumber = -100000;
        int smallestNumber = 999999;
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        do
        {
            Console.Write("Enter a whole number: ");
            newInt = int.Parse(Console.ReadLine());
            sum += newInt;
            ints.Add(newInt);

            if (newInt > largestNumber)
            {
                largestNumber = newInt;
            }
            if (newInt < smallestNumber && newInt > 0)
            {
                smallestNumber = newInt;
            }

        } while(newInt != 0);

        double average = (sum/ints.Count);
        
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"The largest number is {largestNumber}.");
        Console.WriteLine($"The smallest positive number is {smallestNumber}.");
        

    }
}