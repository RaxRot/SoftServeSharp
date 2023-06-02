namespace ConsoleApp1;

public class Programmer :IDeveloper
{
    private string _name;
    private string _language;
    public string Tool { get; set; }

    public Programmer(string name,string language,string tool)
    {
        _name = name;
        _language = language;
        Tool = tool;
    }

    public void Create()
    {
        Console.WriteLine("I am a new programmer");
    }

    public void Destroy()
    {
        Console.WriteLine("I finish my code");
    }

    public int CompareTo(IDeveloper? other)
    {
        return other == null ? 1 : Tool.CompareTo(other.Tool);
    }
}