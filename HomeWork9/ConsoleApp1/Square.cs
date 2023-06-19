namespace ConsoleApp1;

public class Square : Shape
{
    private double _side;

    public Square(string name,double side) : base(name)
    {
        _side = side;
    }

    protected internal override double Area()
    {
        double area = _side * _side;
        return area;
    }

    protected internal override double Perimeter()
    {
        double perimeter = _side + _side + _side + _side;
        return perimeter;
    }
}