class Dairy : Food
{

    private int _calcium;

    public Dairy(String name, int cal, int carbs, int fat, int protein, int calcium) : 
    base(name, "Dairy", cal, carbs, fat, protein)
    {
        _calcium = calcium;
    }

    public override string getFood()
    {
        return base.getFood() + $", Calcium: {_calcium}";
    }

    public override string StringRep()
    {
        return base.StringRep() + $",{_calcium}";
    }
}