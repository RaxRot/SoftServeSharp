namespace ConsoleApp1;

public class Person
{
    
        private string _name;
        private DateTime _birthDate;
        
        DateTime year=DateTime.Today;
        public string Name { get { return _name; }}
        public DateTime BirthDate { get { return _birthDate; } }

        public Person()
        {
            
        }

        public Person(string name, DateTime birthDate)
        {
            _name = name;
            _birthDate = birthDate;
        }

        public void CalculateAge()
        {
            int currentYear = year.Year;
            int yearOfPerson = currentYear - _birthDate.Year;
            Console.WriteLine($"My year is {yearOfPerson}");
        }

        public int GetAge()
        {
            return year.Year - _birthDate.Year;
        }

        public void Input()
        {
            Console.WriteLine("Enter person name");
            string personName = Console.ReadLine();

            Console.WriteLine("Enter person year of birth");
            string personYear = Console.ReadLine();

            Console.WriteLine("Enter person month of birth");
            string personMonth = Console.ReadLine();

            Console.WriteLine("Enter person day of birth");
            string personDay = Console.ReadLine();

            if (!int.TryParse(personYear,out var year) ||!int.TryParse(personMonth,out var month)
                || !int.TryParse(personDay,out var day))
            {
                Console.WriteLine("Error,please enter symbols");
            }
            else
            {
                _name = personName;
                _birthDate = new DateTime(year, month, day);
                
                Console.WriteLine("Entered data!");
            }
        }

        public void ChangeName()
        {
            Console.WriteLine($"Your name is {_name},enter new name to change");
            string newName = Console.ReadLine();

            if (!string.IsNullOrEmpty(newName))
            {
                _name = newName;
                Console.WriteLine("You change name!");
            }
            else
            {
                Console.WriteLine("Error,please enter a value");
            }
          
        }

        public override string ToString()
        {
            return $"Name: {_name}, Birth Date: {_birthDate.ToShortDateString()}";
        }

        public void OutPut()
        {
            Console.WriteLine($"My name is {_name} ,My birthday is {_birthDate.Day},birthmonth {_birthDate.Month}," +
                              $"bithyear {_birthDate.Year}");
        }
}
