public class FoodJournal
{
    private List<Food> _foods = new List<Food> { };


    public void AddFood()
    {
        Console.WriteLine("What type of food would you like to add? \n1. Fruit\n2. Vegetable\n3. Grain\n4. Dairy\n5. Protein");
        String choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.Write("What is the name of the food? ");
            String name = Console.ReadLine();

            Console.Write("How many calories are in it? ");
            String cal = Console.ReadLine();
            
            Console.Write("How many grams of protien are in it? ");
            String pro = Console.ReadLine();
            
            Console.Write("How many grams of carbs are in it? ");
            String carb = Console.ReadLine();
            
            Console.Write("How many grams of fat are in it? ");
            String fat = Console.ReadLine();
            
            Console.Write("How many micrograms of vitamin A are in it? ");
            String vitA = Console.ReadLine();
            
            Console.Write("How many micrograms of vitamin C are in it? ");
            String vitC = Console.ReadLine();
            
            Console.Write("How many milligrams of fiber are in it? ");
            String fib = Console.ReadLine();
            
            Fruit food = new(name, int.Parse(cal), int.Parse(carb), int.Parse(fat), int.Parse(pro), int.Parse(vitA),int.Parse(vitC),int.Parse(fib));
            _foods.Add(food);
        }
        else if (choice == "2")
        {
            Console.Write("What is the name of the food? ");
            String name = Console.ReadLine();

            Console.Write("How many calories are in it? ");
            String cal = Console.ReadLine();

            Console.Write("How many grams of protien are in it? ");
            String pro = Console.ReadLine();

            Console.Write("How many grams of carbs are in it? ");
            String carb = Console.ReadLine();

            Console.Write("How many grams of fat are in it? ");
            String fat = Console.ReadLine();

            Console.Write("How many milligrams of potassium are in it? ");
            String pot = Console.ReadLine();

            Console.Write("How many micrograms of vitamin C are in it? ");
            String vitC = Console.ReadLine();

            Console.Write("How many milligrams of fiber are in it? ");
            String fib = Console.ReadLine();

            Vegetable food = new(name, int.Parse(cal), int.Parse(carb), int.Parse(fat), int.Parse(pro), int.Parse(vitC),int.Parse(pot),int.Parse(fib));
            _foods.Add(food);
        }
        else if (choice == "3")
        {
            Console.Write("What is the name of the food? ");
            String name = Console.ReadLine();

            Console.Write("How many calories are in it? ");
            String cal = Console.ReadLine();

            Console.Write("How many grams of protien are in it? ");
            String pro = Console.ReadLine();

            Console.Write("How many grams of carbs are in it? ");
            String carb = Console.ReadLine();

            Console.Write("How many grams of fat are in it? ");
            String fat = Console.ReadLine();

            Console.Write("How many micrograms of vitamin B are in it? ");
            String vitB = Console.ReadLine();

            Console.Write("How many milligrams of fiber are in it? ");
            String fib = Console.ReadLine();

            Grain food = new(name, int.Parse(cal), int.Parse(carb), int.Parse(fat), int.Parse(pro), int.Parse(vitB),int.Parse(fib));
            _foods.Add(food);
        }
        else if (choice == "4")
        {
            Console.Write("What is the name of the food? ");
            String name = Console.ReadLine();

            Console.Write("How many calories are in it? ");
            String cal = Console.ReadLine();

            Console.Write("How many grams of protien are in it? ");
            String pro = Console.ReadLine();

            Console.Write("How many grams of carbs are in it? ");
            String carb = Console.ReadLine();

            Console.Write("How many grams of fat are in it? ");
            String fat = Console.ReadLine();

            Console.Write("How many milligrams of calcium are in it? ");
            String calci = Console.ReadLine();

            Dairy food = new(name, int.Parse(cal), int.Parse(carb), int.Parse(fat), int.Parse(pro), int.Parse(calci));
            _foods.Add(food);
        } 
        else if (choice == "5")
        {
            Console.Write("What is the name of the food? ");
            String name = Console.ReadLine();

            Console.Write("How many calories are in it? ");
            String cal = Console.ReadLine();

            Console.Write("How many grams of protien are in it? ");
            String pro = Console.ReadLine();

            Console.Write("How many grams of carbs are in it? ");
            String carb = Console.ReadLine();

            Console.Write("How many grams of fat are in it? ");
            String fat = Console.ReadLine();

            Console.Write("How many milligrams of iron are in it? ");
            String iron = Console.ReadLine();

            Console.Write("How many micrograms of vitamin B are in it? ");
            String vitB = Console.ReadLine();

            Console.Write("How many milligrams of zinc are in it? ");
            String zinc = Console.ReadLine();

            Protein food = new(name, int.Parse(cal), int.Parse(carb), int.Parse(fat), int.Parse(pro), int.Parse(iron),int.Parse(zinc),int.Parse(vitB));
            _foods.Add(food);
        }
    }
    
    public void SaveFoods(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
        {
                foreach (Food food in _foods)
                {
                    outputFile.WriteLine(food.StringRep());
                }
            }
        }
    
    public void LoadFoods(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts[1] == "Fruit")
            {
                Fruit food = new(parts[0], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[8]));
                _foods.Add(food);
                
            }
            else if (parts[1] == "Vegetable")
            {
                Vegetable food = new(parts[0], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[8]));
                _foods.Add(food);
            }
            else if (parts[1] == "Grain")
            {
                Grain food = new(parts[0], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));    
                _foods.Add(food);            
            }
            else if (parts[1] == "Protein")
            {
                Protein food = new(parts[0], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[8]));
                _foods.Add(food);
            }
            else if (parts[1] == "Dairy")
            {
                Dairy food = new(parts[0], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _foods.Add(food);
            }
        }
    }

    public void ShowFoods()
    {
        foreach (Food food in _foods)
        {
            Console.WriteLine(food.getName());
        }
    }
    
    public void ShowDetailedFoods()
    {
        foreach (Food food in _foods)
        {
            Console.WriteLine(food.getFood());
        }
    }


}
