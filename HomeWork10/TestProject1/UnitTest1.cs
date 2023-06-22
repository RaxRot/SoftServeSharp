using ConsoleApp1;

namespace TestProject1;

public class Tests
{
    private Point _point1;
    private Point _point2;
    private Point _point3;

    private Triangle _triangle;

    [SetUp]
    public void Setup()
    {
        _point1 = new Point(1, 2);
        _point2 = new Point(3, 4);
        _point3 = new Point(5, 6);

        _triangle = new Triangle(_point1, _point2, _point3);
    }

    [Test]
    public void TestTriangle()
    {
        var finalPerimeter = 11.31;

        var perimeter = _triangle.Perimeter();

        Assert.AreEqual(finalPerimeter, perimeter);
    }

    [Test]
    public void TestDistance()
    {
        var finalDistance = 5;
        
        var pointA = new Point(0, 0);  
        var pointB = new Point(3, 4);

        var distance = _triangle.Distance(pointA, pointB);

        Assert.AreEqual(finalDistance, distance);
    }
}