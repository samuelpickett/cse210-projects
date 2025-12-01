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


    public override string getFood()
    {
        return base.getFood() + $", Vitamin A: {_vitaminA}, Vitamin C: {_vitaminC}, Fiber: {_fiber}";
    }

    public override string StringRep()
    {
        return base.StringRep() + $",{_vitaminA},{_vitaminC},{_fiber}";
    }

}