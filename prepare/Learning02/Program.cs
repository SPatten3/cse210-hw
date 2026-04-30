using System;


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "BYU-Idaho";
        job1._jobTitle = "Academic Skills Coach";
        job1._startYear = 2024;
        job1._endYear = 2027;
        Job job2 = new Job();
        job2._company = "BYU-Idaho";
        job2._jobTitle = "Teaching Assistant";
        job2._startYear = 2025;
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "Spencer Patten";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}