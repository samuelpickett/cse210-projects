using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1990;
        job1._endYear = 2025;

        Job job2 = new();
        job2._company = "Apple";
        job2._jobTitle = "Marketing Director";
        job2._startYear = 2090;
        job2._endYear = 3000;

        Resume resume = new();
        resume._name = "John Smith";
        resume._jobs = [job1, job2];
        resume.Display();
    }
}