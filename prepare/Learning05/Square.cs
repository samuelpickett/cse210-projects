class Square : Shape
{
    private Double _side;


    public Square(String color, double side): base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}