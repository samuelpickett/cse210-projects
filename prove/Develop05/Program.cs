using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        ListofGoals goals = new();
        do
        {
            Console.WriteLine($"\nYou have {goals.GetPoints()} points.");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Show rewards");
            Console.WriteLine("7. Add rewards");
            Console.WriteLine("8. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                goals.MakeGoal();
            }
            else if (choice == 2)
            {
                goals.DisplayGoals();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string file = Console.ReadLine();
                goals.SaveGoals(file);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string file = Console.ReadLine();
                goals.LoadGoals(file);
            }
            else if (choice == 5)
            {
                goals.MarkGoal();
            }
            else if (choice == 6)
            {
                goals.ShowRewards();
            }
            else if (choice == 7)
            {
                goals.AddReward();
            }
        }while(choice != 8);
        

    }
}