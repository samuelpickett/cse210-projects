using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new();
        journal1._prompts = ["What did I do today?", "How was I able to help someone today?", "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"];
            
        string toDo = "";
        while (toDo != "5")
        {

            if (toDo == "1")
            {
                journal1.Write();
            }

            if (toDo == "2")
            {
                journal1.Display();
            }

            if (toDo == "3")
            {
                journal1.Load();
            }

            if (toDo == "4")
            {
                journal1.Save();
            }
            
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            toDo = Console.ReadLine();
        }
    }
}