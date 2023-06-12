
namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string filePath = "phones.txt";
            string filePath2 = "phones2.txt";
            string filePath3 = "ukrainianPhones.txt";
            string filePath4 = "New.txt";
            
            
            //Task1(filePath,filePath2);
            //Task2(filePath);
            //Task3(filePath3,filePath4);
        }

        private static void Task1(string filePath,string filePath2)
        {
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] parts = line.Split(" ");

                    using (StreamWriter streamWriter = new StreamWriter(filePath2,true))
                    {
                        streamWriter.WriteLine(parts[1]);
                    }
                }
            }
        }

        private static void Task2(string filePath)
        {
            
            Console.WriteLine("Enter a name and i will find its number");
            string name = Console.ReadLine();
            bool isFonded = false;

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] parts = line.Split(" ");
                    if (parts[0]==name)
                    {
                        Console.WriteLine("I found");
                        Console.WriteLine(line);
                        isFonded = true;
                    }
                }
            }

            if (!isFonded)
            {
                Console.WriteLine("I cant find(");
            }
        }

        private static void Task3(string filePath3,string filePath4)
        {
            Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();
            using (StreamReader streamReader = new StreamReader(filePath3))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] parts = line.Split(" ");
                    string addedLine = parts[1];
                    if (parts[1].StartsWith("80"))
                    {
                        addedLine = "+3" + parts[1];
                        Console.WriteLine(parts[0] + " " +addedLine);
                        
                    }
                    phoneNumbers.Add(parts[0],addedLine);
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(filePath4))
            {
                foreach (var data in phoneNumbers)
                {
                    streamWriter.WriteLine(data.Key + " " + data.Value);
                }
            }
        }
    }
}