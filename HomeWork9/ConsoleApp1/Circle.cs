namespace ConsoleApp1;

public class Circle : Shape
{
    private double _raduis;

    public Circle(string name,double radius) : base(name)
    {
        _raduis = radius;
    }

    protected internal override double Area()
    {
        double area=Math.PI * Math.Pow(_raduis, 2);
        return area;
    }

    protected internal override double Perimeter()
    {
        double perimeter = 2 * Math.PI * _raduis;
        return perimeter;
    }
}