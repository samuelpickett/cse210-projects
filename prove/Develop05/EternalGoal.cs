class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
    :base(name, desc, points)
    {
        
    }

    public override int Complete()
    {
        _done = false;
        return _points;
    }
    public override String StringRep()
    {
        return $"Eternal Goal,{_name},{_description},{_points},{_done}";
    }
}