class Fruit : Food
{
    private int _vitaminA;
    private int _vitaminC;
    private int _fiber;
    public Fruit(String name, int cal, int carbs, int fat, int protein, int vitaminA, int vitaminC, int fiber): 
    base(name, "Fruit", cal, carbs, fat, protein)
    {
        _vitaminA = vitaminA;
        _vitaminC = vitaminC;
        _fiber = fiber;
    }

    // Getters
    public override string getFood()
    {
        return base.getFood() + $", Vitamin A: {_vitaminA}, Vitamin C: {_vitaminC}, Fiber: {_fiber}";
    }


    public int GetVitA()
    {
        return _vitaminA;
    }

    public int GetVitaC()
    {
        return _vitaminC;
    }

    public int GetFiber()
    {
        return _fiber;
    }

    // String Rep for the Load function in FoodJournal
    public override string StringRep()
    {
        return base.StringRep() + $",{_vitaminA},{_vitaminC},{_fiber}";
    }
}