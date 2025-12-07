class Program
{
    static void Main(string[] args)
    {
        Console.Write("Before we being, would you like to\n1. Input your own goal\n2. Import a saved goal\n3. Allow us to set the goal\n> ");
        int goalChoice = int.Parse(Console.ReadLine());
        NutritionGoal _goal = new(2000, 80, 60, 275);

        if (goalChoice == 1)
        {
            _goal.CreateGoal();
        } 
        else if (goalChoice == 2)
        {
            Console.Write("Where would you like to load from?\n> ");
            _goal.LoadGoal(Console.ReadLine());
        }

        FoodJournal _todaysFoods = new();
        FoodJournal _totalFoods = new();
        _totalFoods.LoadFoods("foods.csv");
        int choice = 0;
        Console.WriteLine("Welcome to the Food Journal.");
    
        do
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add to today's list of foods");
            Console.WriteLine("2. Add to the saved list of foods");
            Console.WriteLine("3. Show today's list of foods");
            Console.WriteLine("4. Quit");
            Console.Write("> ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Please choose from this list of foods");
                _totalFoods.ShowFoods();
                int foodChoice = int.Parse(Console.ReadLine());
                Food food = _totalFoods.GetFood(foodChoice);
                _todaysFoods.AddSavedFood(food);
                _goal.AddToEaten(food);

            }
            else if (choice == 2)
            {
                Console.WriteLine("Please provide the necessary information");
                _totalFoods.AddFood();
            }
            else if (choice == 3)
            {
                _todaysFoods.ShowFoods();
                _goal.DisplayGoal();
            }
            Console.WriteLine();
        } while (choice != 4);
        
        _totalFoods.SaveFoods("foods.csv");
        Console.Write("Would you like to save your goal? Y/N\n> ");
        String confirm = Console.ReadLine();
        if (confirm == "Y")
        {
            Console.Write("Where would you like to save to?\n> ");
            _goal.SaveGoal(Console.ReadLine());
        }
    }
}