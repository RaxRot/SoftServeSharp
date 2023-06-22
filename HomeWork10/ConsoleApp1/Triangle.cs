namespace ConsoleApp1;

public class Triangle
{
    private Point _vertex1;
    private Point _vertex2;
    private Point _vertex3;
    
    public Point Vertex1 => _vertex1;

    public Point Vertex2 => _vertex2;

    public Point Vertex3 => _vertex3;
    

    public Triangle(Point vertex1, Point vertex2, Point vertex3)
    {
        _vertex1 = vertex1;
        _vertex2 = vertex2;
        _vertex3 = vertex3;
    }
    
    public double Distance(Point point1, Point point2)
    {
        int distanceX = point2.X - point1.X;
        int distanceY = point2.Y - point1.Y;
        return Math.Sqrt(distanceX * distanceX + distanceY * distanceY);
    }
    
    public double Perimeter()
    {
        double side1 = Distance(_vertex1, _vertex2);
        double side2 = Distance(_vertex2, _vertex3);
        double side3 = Distance(_vertex3, _vertex1);

        double perimeter = side1 + side2 + side3;
        
        return Math.Round(perimeter, 2);
    }
    public void Print()
    {
        Console.WriteLine($"Triangle :\n Point1 : {_vertex1}" +
                          $"\n Point2: {_vertex2}" +
                          $"\n Point3: {_vertex3}");
    }
    
}