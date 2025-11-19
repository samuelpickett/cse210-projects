public class Goal
{
    protected String _name;
    protected string _description;
    protected int _points;
    protected bool _done;

    public Goal(string name, string desc, int point)
    {
        _name = name;
        _description = desc;
        _points = point;
        _done = false;
    }

    public virtual void Display()
    {
        if (!_done)
        {
            Console.WriteLine($"[] {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"[X] {_name} ({_description})");
        }
    }
    
    public virtual int Complete()
    {
        _done = true;
        return _points;
    }

    public virtual String StringRep()
    {
        return $"Goal,{_name},{_description},{_points},{_done}";
    }
}