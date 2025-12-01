class Vegetable : Food
{
    private int _vitaminC;
    private int _potassium;
    private int _fiber;
    public Vegetable(String name, int cal, int carbs, int fat, int protein, int c, int pot, int fib) : 
    base(name, "Vegetable", cal, carbs, fat, protein)
    {
        _vitaminC = c;
        _fiber = fib;
        _potassium = pot;
    }

    public override string getFood()
    {
        return base.getFood() + $", Potassium: {_potassium}, Vitamin C: {_vitaminC}, Fiber: {_fiber}";
    }
    public override string StringRep()
    {
        return base.StringRep() + $",{_vitaminC},{_potassium},{_fiber}";
    }
}