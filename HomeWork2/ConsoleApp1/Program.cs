using System;
using System.Collections;

namespace ConsoleApp1
{
    public class Program
    {
        static string errorMessage = "Incorrect value,try again";

        public static void Main(string[] args)
        {
            //SolveHomework1();
            //SolveHomework2();
            //SolveHomework3();
            //SolveHomework4();
            //AdditionalTask1();
            //AdditionalTask2();
        }

        private static void SolveHomework1()
        {

            var countOfNumbers = 3;
            var countOfNumbersInRange = 0;
            float minRange = -5;
            float maxRange = 5;

            for (var i = 0; i < countOfNumbers; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " value");
                var inputNumber = Console.ReadLine();

                if (!float.TryParse(inputNumber, out var number))
                {
                    Console.WriteLine(errorMessage);
                    return;
                }

                if (number >= minRange && number <= maxRange)
                {
                    countOfNumbersInRange++;
                }
            }

            Console.WriteLine(countOfNumbersInRange == countOfNumbers
                ? "All numbers was in range"
                : "Not all numbers was in range");
        }

        private static void SolveHomework2()
        {
            var countOfNumbers = 3;
            var numberList = new List<int>();

            for (var i = 0; i < countOfNumbers; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " value");
                var inputNumber = Console.ReadLine();

                if (!int.TryParse(inputNumber, out var number))
                {
                    Console.WriteLine(errorMessage);
                    return;
                }

                numberList.Add(number);
            }

            var minValue = numberList.Min();
            var maxValue = numberList.Max();

            Console.WriteLine($"Min value is {minValue}, max value is {maxValue}");
        }

        private static void SolveHomework3()
        {
            Console.WriteLine("Enter name of error");
            var errorName = Console.ReadLine();

            if (int.TryParse(errorName, out var errorCode))
            {
                switch (errorCode)
                {
                    case (int)HTTP_Error.BadRequest:
                        Console.WriteLine("Bad Request");
                        break;
                    case (int)HTTP_Error.Unauthorized:
                        Console.WriteLine("Unauthorized");
                        break;
                    case (int)HTTP_Error.PaymentRequired:
                        Console.WriteLine("Payment Required");
                        break;
                    case (int)HTTP_Error.Forbidden:
                        Console.WriteLine("Forbidden");
                        break;
                    default:
                        Console.WriteLine(errorMessage);
                        break;
                }
            }
        }

        enum HTTP_Error
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403
        }

        private static void SolveHomework4()
        {
            Console.WriteLine("Enter dog name");
            var dogName = Console.ReadLine();

            Console.WriteLine("Enter dog mark");
            var dogMark = Console.ReadLine();

            Console.WriteLine("Enter dog age");
            var dogAge = Console.ReadLine();
            if (int.TryParse(dogAge, out int age))
            {
                var dog = new Dog();
                dog.Name = dogName;
                dog.Mark = dogMark;
                dog.Age = age;

                Console.WriteLine(dog.ToString());
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }

        struct Dog
        {
            public string Name { get; set; }
            public string Mark { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"I am {Name},my mark is {Mark},my age is {Age}";
            }
        }

        private static void AdditionalTask1()
        {
            Cat cat = new Cat();
            Food food = Food.Fish;
            cat.FeedTheCat(food);
            cat.ShowInfo();
        }

        class Cat
        {
            public string FullnessLevel { get; set;}

            public void FeedTheCat(Food food)
            {
                switch (food)
                {
                    case Food.Fish:
                        FullnessLevel += 10;
                        break;
                    case Food.Mouse:
                        FullnessLevel += 20;
                        break;
                    case Food.CatFood:
                        FullnessLevel += 30;
                        break;
                }
            }

            public void ShowInfo()
            {
                Console.WriteLine($"I am a cat, a have {FullnessLevel} fullnessLevel");
            }
        }
        enum Food
        {
            Mouse,
            Fish,
            CatFood
        }

        private static void AdditionalTask2()
        {
            Student student1 = new Student();
            student1.LastName = "Bulahov";
            student1.GroupNumber = 1;

            Student student2 = new Student();
            student2.LastName = "Hukalo";
            student2.GroupNumber = 2;

            Student student3 = new Student();
            student3.LastName = "Narbut";
            student3.GroupNumber = 3;

            var students = new List<Student> { student1, student2, student3 };

            Console.WriteLine("Enter group");
            string groupName = Console.ReadLine();

            if (int.TryParse(groupName, out var group))
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].GroupNumber.Equals(group))
                    {
                        students[i].ShowInfo();
                    }
                }
            }
           
        }

        struct Student
        {
            public string LastName { get; set; }
            public int GroupNumber { get; set; }

            public void ShowInfo()
            {
                Console.WriteLine($"I am a student {LastName} , my Id is {GroupNumber}");
            }
        }
        
    }
}

  


