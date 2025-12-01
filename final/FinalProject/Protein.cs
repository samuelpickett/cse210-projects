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

    public override string getFood()
    {
        return base.getFood() + $", Vitamin A: {_vitaminB}, Vitamin C: {_iron}, Fiber: {_zinc}";
    }

    public override string StringRep()
    {
        return base.StringRep() + $",{_iron},{_zinc},{_vitaminB}";
    }
}