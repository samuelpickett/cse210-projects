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

    // Getters
    public override string GetFood()
    {
        return base.GetFood() + $", Potassium: {_potassium}, Vitamin C: {_vitaminC}, Fiber: {_fiber}";
    }

    public int GetVitC()
    {
        return _vitaminC;
    }

    public int GetPotassium()
    {
        return _potassium;
    }

    public int GetFiber()
    {
        return _fiber;
    }

    // String Rep for the Load function in FoodJournal
    public override string StringRep()
    {
        return base.StringRep() + $",{_vitaminC},{_potassium},{_fiber}";
    }
}