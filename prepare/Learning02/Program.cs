using System;

public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

// public class Resume
// {
//     public string _name;
//     public List<Job> _jobs = new List<Job>();

//     public void Display()
//     {
        
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "BYU-Idaho";
        job1._jobTitle = "Academic Skills Coach";
        job1._startYear = 2024;
        job1._endYear = 2027;

        job1.Display();

    }
}