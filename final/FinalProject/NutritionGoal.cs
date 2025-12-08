using System.Formats.Tar;
using System.Security.Cryptography;
using System.Xml.Linq;

class NutritionGoal
{
    private int _calories;
    private int _protein;
    private int _fats;
    private int _carbs;
    private int _vitA;
    private int _vitB;
    private int _vitC;
    private int _pota;
    private int _fiber;
    private int _zinc;
    private int _iron;
    private int _calcium;
    private int _caloriesEaten = 0;
    private int _proteinEaten = 0;
    private int _fatsEaten = 0;
    private int _carbsEaten = 0;
    private int _vitAEaten = 0;
    private int _vitBEaten = 0;
    private int _vitCEaten = 0;
    private int _potaEaten = 0;
    private int _fiberEaten = 0;
    private int _zincEaten = 0;
    private int _ironEaten = 0;
    private int _calciumEaten = 0;

    public NutritionGoal(int cal, int pro, int fat, int carb)
    {
        _calories = cal;
        _protein = pro;
        _fats = fat;
        _carbs = carb;
        _vitA = 0;
        _vitB = 0;
        _vitC = 0;
        _pota = 0;
        _fiber = 0;
        _zinc = 0;
        _iron = 0;
    }

    public NutritionGoal(int cal, int pro, int fat, int carb, int a, int b, int c, int pota, int fiber, int zinc, int iron, int calcium)
    {
        _calories = cal;
        _protein = pro;
        _fats = fat;
        _carbs = carb;
        _vitA = a;
        _vitB = b;
        _vitC = c;
        _pota = pota;
        _fiber = fiber;
        _zinc = zinc;
        _iron = iron;
        _calcium = calcium;
    }

    // Displays how close a person is to completing their goals
    public void DisplayGoal()
    {
        if (_vitA == 0)
        {
            Console.WriteLine($"Your Goal:\nCalories: {_caloriesEaten}/{_calories} eaten\nProtein: {_proteinEaten}/{_protein} grams eaten\nFat: {_fatsEaten}/{_fats} grams eaten\nCarbs: {_carbsEaten}/{_carbs} grams eaten");
        }
        else
        {
            Console.WriteLine($"Your Goal:\nCalories: {_caloriesEaten}/{_calories} eaten\nProtein: {_proteinEaten}/{_protein} grams eaten\nFat: {_fatsEaten}/{_fats} grams eaten\nCarbs: {_carbsEaten}/{_carbs} grams eaten\nVitamin A: {_vitAEaten}/{_vitA} micrograms eaten\nVitamin B: {_vitBEaten}/{_vitB} micrograms eaten\nVitamin C: {_vitCEaten}/{_vitC} milligrams eaten\nFiber: {_fiberEaten}/{_fiber} grams eaten\nPotassium: {_potaEaten}/{_pota} grams eaten\nZinc: {_zincEaten}/{_zinc} milligrams eaten\nIron: {_ironEaten}/{_iron} milligrams eaten\nCalcium: {_calciumEaten}/{_calcium} milligrams eaten");
        }
    }
    
    // Updates the _eaten variables
    public void AddToEaten(Food food)
    {
        _caloriesEaten += food.GetCal();
        _carbsEaten += food.GetCarbs();
        _proteinEaten += food.GetPro();
        _fatsEaten += food.GetFat();
        if (_vitA != 0)
        {
            if (food is Fruit fruit)
            {
                _vitAEaten += fruit.GetVitA();
                _vitCEaten += fruit.GetVitaC();
                _fiberEaten += fruit.GetFiber();
            }
            else if (food is Vegetable veg)
            {
                _vitCEaten += veg.GetVitC();
                _fiberEaten += veg.GetFiber();
                _potaEaten += veg.GetPotassium();
            }
            else if (food is Grain grain)
            {
                _vitBEaten += grain.GetVitB();
                _fiberEaten += grain.GetFiber();
            }
            else if (food is Dairy dairy)
            {
                _calciumEaten += dairy.GetCalcium();
            }
            else if (food is Protein protein)
            {
                _ironEaten += protein.GetIron();
                _vitBEaten += protein.GetVitB();
                _zincEaten += protein.GetZinc();
            }
        }
    }
    
    // Creates a goal based on the user's input
    public void CreateGoal()
    {
        Console.Write("Which goal would you like to make?\n1. Simple\n2. Complex\n> ");
        int goalChoice = int.Parse(Console.ReadLine());
        if (goalChoice == 1)
        {
            Console.WriteLine("How many calories would you like to eat each day? ");
            _calories = int.Parse(Console.ReadLine());

            Console.WriteLine("How many grams of protein would you like to eat each day? ");
            _protein = int.Parse(Console.ReadLine());

            Console.WriteLine("How many grams of carbs would you like to eat each day? ");
            _carbs = int.Parse(Console.ReadLine());

            Console.WriteLine("How many grams of fat would you like to eat each day? ");
            _fats = int.Parse(Console.ReadLine());
        }
        else if (goalChoice == 2)
        {
            Console.WriteLine("How many calories would you like to eat each day? ");
            _calories = int.Parse(Console.ReadLine());

            Console.WriteLine("How many grams of protein would you like to eat each day? ");
            _protein = int.Parse(Console.ReadLine());

            Console.WriteLine("How many grams of carbs would you like to eat each day? ");
            _carbs = int.Parse(Console.ReadLine());

            Console.WriteLine("How many grams of fat would you like to eat each day? ");
            _fats = int.Parse(Console.ReadLine());

            Console.WriteLine("How many micrograms of Vitamin A would you like to eat each day? ");
            _vitA = int.Parse(Console.ReadLine());

            Console.WriteLine("How many micrograms of Vitamin B would you like to eat each day? ");
            _vitB = int.Parse(Console.ReadLine());

            Console.WriteLine("How many milligrams of Vitamin C would you like to eat each day? ");
            _vitC = int.Parse(Console.ReadLine());

            Console.WriteLine("How many grams of fiber would you like to eat each day? ");
            _fiber = int.Parse(Console.ReadLine());

            Console.WriteLine("How many grams of potassium would you like to eat each day? ");
            _pota = int.Parse(Console.ReadLine());

            Console.WriteLine("How many milligrams of zinc would you like to eat each day? ");
            _zinc = int.Parse(Console.ReadLine());

            Console.WriteLine("How many milligrams of iron would you like to eat each day? ");
            _iron = int.Parse(Console.ReadLine());

            Console.WriteLine("How many milligrams of calcium would you like to eat each day? ");
            _calcium = int.Parse(Console.ReadLine());
        }
    }

    // Saves the goal to a file
    public void SaveGoal(String fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, append: false))
        {
            outputFile.WriteLine(_calories);
            outputFile.WriteLine(_carbs);
            outputFile.WriteLine(_fats);
            outputFile.WriteLine(_protein);
            outputFile.WriteLine(_vitA);
            outputFile.WriteLine(_vitB);
            outputFile.WriteLine(_vitC);
            outputFile.WriteLine(_pota);
            outputFile.WriteLine(_fiber);
            outputFile.WriteLine(_zinc);
            outputFile.WriteLine(_iron);
            outputFile.WriteLine(_calcium); 
        }
    }

    // Loads goal from a file
    public void LoadGoal(String fileName)
    {
        string[] goals = File.ReadAllLines(fileName);
        _calories = int.Parse(goals[0]);
        _carbs = int.Parse(goals[1]);
        _fats = int.Parse(goals[2]);
        _protein = int.Parse(goals[3]);
        _vitA = int.Parse(goals[4]);
        _vitB = int.Parse(goals[5]);
        _vitC = int.Parse(goals[6]);
        _pota = int.Parse(goals[7]);
        _fiber = int.Parse(goals[8]);
        _zinc = int.Parse(goals[9]);
        _iron = int.Parse(goals[10]);
        _calcium = int.Parse(goals[11]);
    }
}