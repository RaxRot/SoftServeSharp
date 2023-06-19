namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Task1();

            //Task2();
        }

        private static void Task1()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle("Circle1", 2.5),
                new Circle("BigCircle", 7.2),
                new Circle("LittleCircle", 0.3),
                new Square("Square1", 3),
                new Square("BigSquare", 15),
                new Square("LittleSquare", 2)
            };

            Console.WriteLine("Area >=10 but <=100");
            int minArea = 10, maxArea = 100;
            var bordedArea = shapes.Where(shape => shape.Area() >= minArea && shape.Area() <= maxArea).ToList();
            foreach (var shape in bordedArea)
            {
                Console.WriteLine(shape.Area());
            }

            Console.WriteLine("Name contains 'a'");
            string nameToCheck = "a";
            var containsA = shapes.Where(shape => shape.Name.Contains(nameToCheck));
            foreach (var shape in containsA)
            {
                Console.WriteLine(shape.Name);
            }

            Console.WriteLine("Perimeter <10");
            var removedShapes = shapes.Where(shape => shape.Perimeter() < minArea).ToList();
            foreach (var shape in removedShapes)
            {
                Console.WriteLine(shape.Perimeter());
            }
        }
        
        private static void Task2()
        {
            string path = "text.txt";
            List<string> textFormFile = new List<string>();

            using (StreamReader streamReader = new StreamReader(path))
            {
                while (!streamReader.EndOfStream)
                {
                    textFormFile.Add(streamReader.ReadLine());
                }
            }

            Console.WriteLine("Symbols in each line");
            var numbersInArea = textFormFile.Select(line => line.Length);
            foreach (var numbers in numbersInArea)
            {
                Console.WriteLine(numbers);
            }

            Console.WriteLine("Shortest Line");
            var shortestLine = textFormFile.OrderBy(line => line.Length).FirstOrDefault();
            Console.WriteLine(shortestLine);

            Console.WriteLine("Longest Line");
            var longestLine = textFormFile.OrderByDescending(line => line.Length).FirstOrDefault();
            Console.WriteLine(longestLine);

            Console.WriteLine("Line with 'var'");
            string stringToFind = "var";
            var containsVar = textFormFile.Where(line => line.Contains(stringToFind)).ToList();
            foreach (var var in containsVar)
            {
                Console.WriteLine(var);
            }
        }
    }
}