class Protein : Food
{
    private int _iron;
    private int _zinc;
    private int _vitaminB;
    
    public Protein(String name, int cal, int carbs, int fat, int protein, int iron, int zinc, int b) : 
    base(name, "Protein", cal, carbs, fat, protein)
    {
        _iron = iron;
        _zinc = zinc;
        _vitaminB = b;
    }

    // Getters
    public override string GetFood()
    {
        return base.GetFood() + $", Vitamin A: {_vitaminB}, Vitamin C: {_iron}, Fiber: {_zinc}";
    }

    public int GetIron()
    {
        return _iron;
    }

    public int GetZinc()
    {
        return _zinc;
    }

    public int GetVitB()
    {
        return _vitaminB;
    }

    // String Rep for the Load function in FoodJournal
    public override string StringRep()
    {
        return base.StringRep() + $",{_iron},{_zinc},{_vitaminB}";
    }
}