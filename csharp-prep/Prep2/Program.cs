using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the Grade:  ");
        string strGrade = Console.ReadLine();
        double dblGrade = double.Parse(strGrade);

        string letterGrade;

        double ones = dblGrade % 10;
        string modifier;
        
        if (dblGrade >= 90)
        {
            letterGrade = "A";
        } else if (dblGrade >= 80)
        {
            letterGrade = "B";
        } else if (dblGrade >= 70)
        {
            letterGrade = "C";
        } else if (dblGrade >= 60)
        {
            letterGrade = "D";
        } else
        {
            letterGrade = "F";
        }

        if (dblGrade < 93 && dblGrade >= 60)
        {
            if (ones >= 0 && ones < 3)
            {
                modifier = "-";
            } else if (ones >= 7)
            {
                modifier = "+";
            } else
            {
                modifier = "";
            }
        } else
        {
            modifier = "";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}{modifier}.");
    }
}