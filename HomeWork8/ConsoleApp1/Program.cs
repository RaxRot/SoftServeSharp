
namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter name for shape {i+1}");
                string name = Console.ReadLine();

                Console.WriteLine("Enter what figure you want to create 1-Circle 2-Square");
                string resultInput = Console.ReadLine();
                int result;

                if (!int.TryParse(resultInput, out result))
                {
                    SayGoodBye();
                    return;
                }

                switch (result)
                {
                    case 1:
                        CreateCircle(name, shapes);
                        break;
                    case 2:
                        CreateSquare(name, shapes);
                        break;
                    default:
                        CreateDefaultFigure(name, shapes);
                        break;
                }
            }

            Console.WriteLine("I added 10 figures!");
            
            PrintInfoOfAllShapes(shapes);

            PrintShapeWithBiggestPerimeter(shapes);
            
            PrintSortedShapedByArea(shapes);
        }

        private static void CreateDefaultFigure(string? name, List<Shape> shapes)
        {
            Shape shape;
            Console.WriteLine("You need to choose 1 or 2!!!");
            Console.WriteLine("Okey i wil create square with side 3  by my own");

            shape = new Square(name, 3);
            shapes.Add(shape);
        }

        private static void CreateSquare(string? name, List<Shape> shapes)
        {
            Shape shape;
            Console.WriteLine("Enter side of square");
            string sideInput = Console.ReadLine();
            double side;
            if (!double.TryParse(sideInput, out side))
            {
               SayGoodBye();
               return;
            }

            shape = new Square(name, side);
            shapes.Add(shape);
        }

        private static void CreateCircle(string? name, List<Shape> shapes)
        {
            Shape shape;
            Console.WriteLine("Enter radius of circle");
            string raduisInput = Console.ReadLine();
            double raduis;
            if (!double.TryParse(raduisInput, out raduis))
            {
                SayGoodBye();
                return;
            }

            shape = new Circle(name, raduis);
            shapes.Add(shape);
        }

        private static void PrintInfoOfAllShapes(List<Shape> shapes)
        {
            Console.WriteLine("Info of all added shapes:");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}");
                Console.WriteLine($"Area: {shape.Area():F2}");
                Console.WriteLine($"Perimeter: {shape.Perimeter():F2}");
                Console.WriteLine();
            }
        }

        private static void PrintShapeWithBiggestPerimeter(List<Shape> shapes)
        {
            double maxPerimeter = double.MinValue;
            string maxName = "";

            foreach (var shape in shapes)
            {
                if (shape.Perimeter() > maxPerimeter)
                {
                    maxPerimeter = shape.Perimeter();
                    maxName = shape.Name;
                }
            }

            Console.WriteLine($"The biggest perimeter {maxPerimeter:F2},the name is {maxName}");
        }

        private static void PrintSortedShapedByArea(List<Shape> shapes)
        {
            Console.WriteLine("Now lets sort by area");
            shapes.Sort();

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}");
                Console.WriteLine($"Area: {shape.Area():F2}");
            }
        }

        private static void SayGoodBye()
        {
            Console.WriteLine("Its not a number!Goodbye");
        }
    }
}
