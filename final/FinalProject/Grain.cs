class Grain : Food
{
    private int _vitaminB;
    private int _fiber;
    
    public Grain(String name, int cal, int carbs, int fat, int protein, int b, int fib) : 
    base(name, "Grain", cal, carbs, fat, protein)
    {
        _fiber = fib;
        _vitaminB = b;
    }

    public override string getFood()
    {
        return base.getFood() + $", Vitamin B: {_vitaminB}, Fiber: {_fiber}";
    }

    public override string StringRep()
    {
        return base.StringRep() + $",{_vitaminB},{_fiber}";
    }
}