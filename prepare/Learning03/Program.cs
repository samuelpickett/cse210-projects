using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new();
        Fraction fraction2 = new(5);
        Fraction fraction3 = new(3, 4);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}