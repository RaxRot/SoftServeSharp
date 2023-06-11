using System.Collections;
using System.Threading.Channels;


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
            try
            {
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Div(firstNumber, secondNumber);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("I cant divide number to zero");
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Wrong Format(What are you doing?(");
            }
            catch (OverflowException exception)
            {
                Console.WriteLine("Number is too large or too small for an int.");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Its an error(");
            }
        }

        private static void Div(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Answer is {firstNumber / secondNumber}");
        }

        private static void Task2()
        {
            ReadNumber(0, 100);
        }

        private static int ReadNumber(int start, int end)
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number >= start && number <= end)
                {
                    return number;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong Format(What are you doing?(");
                return 0;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number is out of range");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is too large or too small for an int.");
                return 0;
            }
            catch (Exception)
            {
                Console.WriteLine("It's an error(");
                return 0;
            }
        }
    }
}
    