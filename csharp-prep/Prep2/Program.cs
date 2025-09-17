using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage did you get in your course? ");
        string strPercent = Console.ReadLine();
        int percent = int.Parse(strPercent);
        string letter = "";

        if (percent >= 90)
        {
            if (percent < 93)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }
        }
        else if (percent >= 80)
        {
            if (percent >= 87)
            {
                letter = "B+";
            }
            else if (percent < 83)
            {
                letter = "B-"; ;
            }
            else
            {
                letter = "B"; ;
            }
        }
        else if (percent >= 70)
        {
            if (percent >= 77)
            {
                letter = "C+";
            }
            else if (percent < 73)
            {
                letter = "C-";
            }
            else
            {
                letter = "C";
            }
        }
        else if (percent >= 60)
        {
            if (percent >= 67)
            {
                letter = "D+";
            }
            else if (percent < 63)
            {
                letter = "D-";
            }
            else
            {
                letter = "D";
            }
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");
        if (percent >= 70)
        {
            Console.WriteLine("You passed the class.");
        }
        else
        {
            Console.WriteLine("You will need to retake the class.");
        }
    }
}