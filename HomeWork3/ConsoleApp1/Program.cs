using System;
using System.Collections;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //SolveTask1();
            //SolveTask2();
            //SolveTask3();
        }

        private static void SolveTask1()
        {
            Console.WriteLine("Enter All that you want,i will count <a,o,i,e> letters");
            var userInput = Console.ReadLine();

            int aSymbol = 0, oSymbol = 0, iSymbol = 0, eSymbol = 0;

            if (userInput == null) return;
            foreach (var letter in userInput)
            {
                switch (letter)
                {
                    case 'a':
                        aSymbol++;
                        break;
                    case 'o':
                        oSymbol++;
                        break;
                    case 'i':
                        iSymbol++;
                        break;
                    case 'e':
                        eSymbol++;
                        break;
                }
            }

            Console.WriteLine($"In your word you have  {aSymbol} a symbols, {oSymbol} o symbols, " +
                              $"{iSymbol} i symbols, {eSymbol} e symbols");
        }

        private static void SolveTask2()
        {
            Console.WriteLine("Enter number of month,i will say how much day this month have");
            var month = Console.ReadLine();
            
            if (!int.TryParse(month, out var monthNumber))
            {
                Console.WriteLine("Error,its not a number");
                return;
            }
            
            switch (monthNumber)
            {
                case 1: case 3: case 5: case 7:
                case 8: case 10: case 12:
                    Console.WriteLine("31 Days In this month");
                    break;
                
                case 4: case 6: case 9: case 11:
                    Console.WriteLine("30 Day In this month");
                    break;
                
                case 2:
                    Console.WriteLine("28 or 29 days in this month");
                    break;
                default:
                    Console.WriteLine("You enter wrong number of month(((");
                    break;
            }
        }

        private static void SolveTask3()
        {
            List<int> array = new List<int>();

            int pointsToStartCulculateSum = 0;
            int neededPointsToStartCalculate = 10;

            Console.WriteLine("Enter 10 numbers");

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter {i+1} number");
                var inputFromUser = Console.ReadLine();
                
                if (!int.TryParse(inputFromUser,out var userInteger))
                {
                    Console.WriteLine("Please be careful!Its not a number!");
                    return;
                }

                if (userInteger>0)
                {
                    pointsToStartCulculateSum++;
                }
                array.Add(userInteger);
            }

            Console.WriteLine(pointsToStartCulculateSum);
            if (pointsToStartCulculateSum==neededPointsToStartCalculate)
            {
                int sum = 0;

                for (int i = 0; i < 5; i++)
                {
                    sum += array[i];
                }

                Console.WriteLine($"Sum is {sum}");
            }
            else
            {
                int product = 1;
                
                for (int i = 5; i < array.Count; i++)
                {
                    product *= array[i];
                }

                Console.WriteLine($"Product is {product}");
            }
        }
    }
}

  


