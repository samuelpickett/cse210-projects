using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breath = new();
        ReflectionActivity reflect = new();
        ListingActivity list = new();
        int option = 0;
        while (option != 4)
        {
            Console.WriteLine("Welcome to the Meditation App.");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                breath.UseBreathingActivity();
                Console.Clear();
            }
            else if (option == 2)
            {
                reflect.UseReflectionActivity();
                Console.Clear();
            }
            else if (option == 3)
            {
                list.UseListingActivity();
                Console.Clear();
            }
        }
    }
}