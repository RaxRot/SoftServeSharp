namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
        }

        public static void Task1()
        {
            var vertex1 = new Point { X = 1, Y = 2 };
            var vertex2 = new Point { X = 3, Y = 4 };
            var vertex3 = new Point { X = 5, Y = 6 };
            
            List<Triangle> triangles = new List<Triangle>
            {
                new (vertex1, vertex2, vertex3),
                new (vertex2, vertex3, vertex1),
                new (vertex3, vertex1, vertex2)
            };
            
            foreach (var triangle in triangles)
            {
                triangle.Print();
                var perimeter = triangle.Perimeter();
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine();
            }
            
            Triangle closestTriangle = null;
            double minDistance = double.MaxValue;

            foreach (var triangle in triangles)
            {
                double distance = triangle.Distance(new Point(0, 0), triangle.Vertex1);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestTriangle = triangle;
                }
            }
            closestTriangle.Print();
        }
    }
}