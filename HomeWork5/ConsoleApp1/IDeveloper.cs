namespace ConsoleApp1;

public interface IDeveloper: IComparable<IDeveloper>
{
    public string Tool { get; set; }
    void Create();
    void Destroy();
}