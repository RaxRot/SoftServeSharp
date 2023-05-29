using System;
using System.Collections;
using System.Threading.Channels;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime person1DateTime = new DateTime(2010, 08, 10);
            Person person1 = new Person("Vlad",person1DateTime);
            
            DateTime person2DateTime = new DateTime(2008, 12, 11);
            Person person2 = new Person("Roma",person2DateTime);
            
            DateTime person3DateTime = new DateTime(1995, 01, 15);
            Person person3 = new Person("Vlad",person3DateTime);
            
            DateTime person4DateTime = new DateTime(1976, 10, 29);
            Person person4 = new Person("Vlad",person4DateTime);
            
            DateTime person5DateTime = new DateTime(2013, 12, 17);
            Person person5 = new Person("Vlad",person5DateTime);
            
            DateTime person6DateTime = new DateTime(2010, 07, 02);
            Person person6 = new Person("Vlad",person6DateTime);

            var allPersons = new List<Person>() { person1, person2, person3, person4, person5, person6 };

            foreach (var person in allPersons)
            {
                Console.WriteLine("My name is" + person.Name);
                person.CalculateAge();

                if (person.GetAge()<=16)
                {
                    person.ChangeName();
                }

                Console.WriteLine();
            }
            
            FindSameNames(allPersons);
            
        }

        private static void FindSameNames(List<Person> persons)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = i+1; j < persons.Count; j++)
                {
                    if (persons[i].Name==persons[j].Name)
                    {
                        Console.WriteLine("Person with same name");

                        Console.WriteLine( persons[i].ToString());
                        Console.WriteLine(persons[j].ToString());
                    }
                }
            }
        }
    }
}

  


