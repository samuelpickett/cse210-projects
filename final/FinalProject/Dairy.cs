class Dairy : Food
{

    private int _calcium;

    public Dairy(String name, int cal, int carbs, int fat, int protein, int calcium) : 
    base(name, "Dairy", cal, carbs, fat, protein)
    {
        _calcium = calcium;
    }

    // Getters
    public override string GetFood()
    {
        return base.GetFood() + $", Calcium: {_calcium}";
    }

    public int GetCalcium()
    {
        return _calcium;
    }

    // String Rep for the Load function in FoodJournal
    public override string StringRep()
    {
        return base.StringRep() + $",{_calcium}";
    }
}