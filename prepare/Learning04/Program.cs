using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Samuel Bennet", "Multiplication");
        string sum = assignment.GetSummary();
        Console.WriteLine(sum);

        MathAssignment math1 = new("John Smith", "Math", "7.3", "8-19");
        string summary = math1.GetHomeWorkList();
        Console.WriteLine(summary);

        WritingAssignment write1 = new("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        string writeSum = write1.GetWritingInformation();
        Console.WriteLine(writeSum);
    }
}