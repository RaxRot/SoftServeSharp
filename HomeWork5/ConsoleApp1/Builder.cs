namespace ConsoleApp1;

public class Builder : IDeveloper
{
    private string _name;
    private string _tool;
    
    public string Tool { get; set; }

    public Builder(string name, string tool)
    {
        _name = name;
       Tool = tool;
    }
    
    
    public void Create()
    {
        Console.WriteLine("I am a new builder");
    }

    public void Destroy()
    {
        Console.WriteLine("I finish build");
        
    }

    public int CompareTo(IDeveloper? other)
    {
        return other == null ? 1 : Tool.CompareTo(other.Tool);
    }
}