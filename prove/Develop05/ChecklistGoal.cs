class ChecklistGoal : Goal
{
    private int _completionTimes;
    private int _timesCompleted;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int complete, int bonus)
    :base(name, desc, points)
    {
        _completionTimes = complete;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override void Display()
    {
        if (!_done)
        {
            Console.WriteLine($"[] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_completionTimes}");
        }
        else
        {
            Console.WriteLine($"[X] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_completionTimes}");
        }
    }

    public override int Complete()
    {        
        if (_timesCompleted == (_completionTimes - 1))
        {
            _timesCompleted += 1;
            _done = true;
            return _points + _bonus;
        }
        else
        {
            _timesCompleted += 1;
            return _points;
        }
    }

    public override String StringRep()
    {
        return $"Checklist Goal,{_name},{_description},{_points},{_timesCompleted},{_completionTimes},{_bonus},{_done}";
    }
}