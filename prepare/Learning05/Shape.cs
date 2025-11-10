public abstract class Shape
{
    private String _color;
    public abstract double GetArea();

    public String GetColor()
    {
        return _color;
    }

    public Shape(String color)
    {
        _color = color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    
}