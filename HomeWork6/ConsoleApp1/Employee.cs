using System.Collections;
namespace ConsoleApp1;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Job { get; set; }
    public double Salary { get; set; }
}

public class Organization :IEnumerable
{
    private List<Employee> emps = new List<Employee>();
    public void Add(Employee emp)
    {
        emps.Add(emp);
    }

    public IEnumerator GetEnumerator()
    {
        return new OrganizationEnumerator();
    }
}

public class OrganizationEnumerator : IEnumerator
{
    public object Current { get; }
    
    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
    
}