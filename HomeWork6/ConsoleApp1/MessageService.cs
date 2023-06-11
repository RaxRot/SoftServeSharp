namespace ConsoleApp1;

public class MessageService
{
    public void OnVideoEncoded(object source, EventArgs args)
    {
        Console.WriteLine("Message:Sending Message");
    }
}