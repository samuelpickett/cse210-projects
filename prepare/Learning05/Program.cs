using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new("Red", 10);
        Rectangle rectangle = new("Green", 10, 5);
        Circle circle = new("Blue", 10);
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}. ");
        }
    }
}