using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numToAdd;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        do
        {
            Console.Write("Enter number: ");
            numToAdd = int.Parse(Console.ReadLine());
            if (numToAdd != 0)
            {
                numbers.Add(numToAdd);
            }

        } while (numToAdd != 0);

        int sum = numbers.Sum();
        double average = numbers.Average();
        int largestNumber = numbers.Max();
        int smallesNumber = numbers.Where(i => i > 0).Min();
        numbers.Sort();

        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest number is {largestNumber}.");
        Console.WriteLine($"The smallest positive integer is {smallesNumber}");
        Console.WriteLine($"The sorted list is");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    
}