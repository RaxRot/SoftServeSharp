using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //SolveTask1();
            //SolveTask2();
            //SolveTask3();
        }

        private static void SolveTask1()
        {
            Console.WriteLine("Enter side of square");
            
            var sideString = Console.ReadLine();

            if (!int.TryParse(sideString,out var side))
            {
                Console.WriteLine("Error, please ender integer");
                return;
            }

            if (side<=0)
            {
                Console.WriteLine("Impossible to calculate");
            }
            else
            {
                Console.WriteLine($"Good,you enter {side} lets calculate perimeter and square");

                var squareResult =side*side;
                var perimeterResult =side + side+side+side;

                Console.WriteLine($"Perimeter is {perimeterResult}, and square is {squareResult}");
            }
        }

        private static void SolveTask2()
        {
            Console.WriteLine("What is your name?");
            
            var name = Console.ReadLine();
            
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please enter your name");
            }
            else
            {
                Console.WriteLine("Enter your age");
                var ageString = Console.ReadLine();
                
                if (!int.TryParse(ageString,out var age))
                {
                    Console.WriteLine("Please enter correct age");
                }
                else
                {
                    Console.WriteLine(age <= 0 ? "Incorrect age" : $"Hello {name} ,your age is {age}");
                }
            }
        }

        private static void SolveTask3()
        {
            Console.WriteLine("Enter radius of circle");
            var radiusString = Console.ReadLine();

            if (!double.TryParse(radiusString, out var radius))
            {
                Console.WriteLine("Error,enter correct value");
            }
            else
            {
                if (radius<=0)
                {
                    Console.WriteLine("Incorrect value");
                }
                else
                {
                    var lenght = 2 * Math.PI * radius;
                    var area = Math.PI * Math.Pow(radius, 2);
                    var volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);

                    Console.WriteLine($"Lenght {lenght:F2}, area is {area:F2}, volume is {volume:F2}");
                }
            }
        }
    }
}
