namespace ConsoleApp1;

public abstract class Shape 
{
    protected string name;

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }
        
    protected Shape(string name)
    {
        this.name = name;
    }
        
    protected internal abstract double Area();
    protected internal abstract double Perimeter();

    public int CompareTo(Shape? other)
    {
        double area1 = Area();
        double area2 = other.Area();

        if (area1 < area2)
        {
            return -1;
        }else if (area1 > area2)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}