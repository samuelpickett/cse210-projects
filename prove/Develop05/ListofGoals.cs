class ListofGoals
{
    private List<Goal> _goals = new List<Goal> {};
    private int _totalPoints;
    private List<String> _rewards = new List<String> {"Milkshake", "Meal from restaurant", "New Game", "New Computer Component"};

    public ListofGoals()
    {
        _totalPoints = 0;
    }

    public void MakeGoal()
    {
        Console.Write("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.Write("What is the name of the goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string desc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Goal goal = new(name, desc, points);
            _goals.Add(goal);
        }
        else if (choice == 2)
        {
            Console.Write("What is the name of the goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string desc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            EternalGoal goal = new(name, desc, points);
            _goals.Add(goal);
        }
        else if (choice == 3)
        {
            Console.Write("What is the name of the goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string desc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int times = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing this goal? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new(name, desc, points, times, bonus);
            _goals.Add(goal);
        }
    }
    
    public void DisplayGoals()
    {
        for(int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].Display();
        }
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, append: false))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (Goal goal in _goals) {
                outputFile.WriteLine(goal.StringRep());
            }
        }
    }
    
    public void LoadGoals(string fileName)
    {
        string[] oldLines = File.ReadAllLines(fileName);
        _totalPoints += int.Parse(oldLines[0]);
        string itemToRemove = oldLines[0];
        string[] lines = oldLines.Where(item => item != itemToRemove).ToArray();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts[0] == "Goal")
            {
                Goal goal = new(parts[1], parts[2], int.Parse(parts[3]));
                if (parts[4] == "True")
                {
                    goal.Complete();
                }
                _goals.Add(goal);
            }
            else if (parts[0] == "Eternal Goal")
            {
                EternalGoal goal = new(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }
            else if (parts[0] == "Checklist Goal")
            {
                ChecklistGoal goal = new(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                if (parts[7] == "True")
                {
                    for (int i = 0; i < int.Parse(parts[5]); i++)
                        {
                            goal.Complete();
                        }
                }
                else
                {
                    for (int i = 0; i < int.Parse(parts[4]); i++)
                        {
                            goal.Complete();
                        }
                }
                _goals.Add(goal);
            }
        }
    }

    public void MarkGoal()
    {
        Console.WriteLine("The goals are:");
        DisplayGoals();
        Console.WriteLine("Which goal did you accomplish");
        int goalDone = int.Parse(Console.ReadLine());
        int p = _goals[goalDone - 1].Complete();
        _totalPoints += p;
        Console.WriteLine($"Congratulations! You have earned {p} points!");
        Console.WriteLine($"You now have {_totalPoints} points.");
    }

    public int GetPoints()
    {
        return _totalPoints;
    }

    public void ShowRewards()
    {
            for (int i = 0; i < _rewards.Count; i++)
            {
                if (_totalPoints > (i+1) * 100)
                {
                    Console.WriteLine($"You have unlocked a {_rewards[i]} as a reward.");
                }
                else
                {
                    Console.WriteLine($"You have not unlocked a {_rewards[i]} as a reward.");
                }
            }
        }
    

    public void AddReward()
    {
        Console.Write("What reward would you like to add to the list? ");
        _rewards.Add(Console.ReadLine());
    }
}