using System;
using System.Collections;
using System.Threading.Channels;

namespace ConsoleApp1
{
  
    public class Program
    {
        public static void Main(string[] args)
        {
            //Task1();
            //Task2();
        }

        private static void Task1()
        {
            IDeveloper proger1 = new Programmer("Vlad","c#","PC");
            IDeveloper proger2 = new Programmer("Dasha","Java","Mac");
            IDeveloper proger3 = new Programmer("Oleh","C++","Phone");

            IDeveloper builder1 = new Builder("Roma","shovel");
            IDeveloper builder2 = new Builder("Katia","knife");
            IDeveloper builder3 = new Builder("Inesa","fork");

            var developers = new List<IDeveloper>()
                { proger1, proger2, proger3, builder1, builder2, builder3 };
            
            developers.Sort();

            foreach (var devs in developers)
            {
                Console.WriteLine(devs.Tool);
                devs.Create();
                devs.Destroy();
                Console.WriteLine();
            }
        }

        private static void Task2()
        {
            Dictionary<uint, string> persons = new Dictionary<uint, string>();

            Console.WriteLine("Hello we need to fill form");
            int sizeOfForm = 7;

            for (int i = 0; i < sizeOfForm; i++)
            {
                Console.WriteLine("Enter uniq Key consist from numbers!");
                string keyName = Console.ReadLine();

                Console.WriteLine("Enter Name");
                string valueName = Console.ReadLine();

                if (!uint.TryParse(keyName, out var key) ||persons.ContainsKey(key))
                {
                    Console.WriteLine("Error! Please enter numbers and remember,key should be uniq");
                    return;
                }
                else
                {
                    persons.Add(key, valueName);
                    Console.WriteLine("Added!");
                }
            }

            Console.WriteLine("Very good,we fill form");

            Console.WriteLine("Lets find name by id,please enter id");
            string idFromPersons = Console.ReadLine();
            if (!uint.TryParse(idFromPersons,out var id))
            {
                Console.WriteLine("Error irs not a key");
                return;
            }
            else
            {
                int counter = 0;
                
                foreach (var person in persons)
                {
                    if (person.Key==id)
                    {
                        Console.WriteLine("I found by id");
                        Console.WriteLine("Uniq key"+person.Key + " Value " + person.Value);
                        counter++;
                    }
                }

                if (counter==0)
                {
                    Console.WriteLine("I cant find(((");
                }
            }
        }
    }

}
  


