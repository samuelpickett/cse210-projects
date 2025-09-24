using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int squaredNumber = SquareNumber(PromptUserNumber());
        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(name, squaredNumber, birthYear);
    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favorite = int.Parse(Console.ReadLine());
            return favorite;
        }

        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("Please enter the year you were born: ");
            birthYear = int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string userName, int squaredNumber, int year)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
            Console.WriteLine($"{userName}, you will turn {2025 - year} this year");
        }
    
}