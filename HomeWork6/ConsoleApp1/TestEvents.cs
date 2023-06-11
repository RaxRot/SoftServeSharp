namespace ConsoleApp1;

public class TestEvents
{
    public event EventHandler OnDoingSomething;

    public void DoSomething()
    {
        OnDoingSomething.Invoke(this,EventArgs.Empty);
    }

    private void TestDoing(object sender, EventArgs eventArgs)
    {
        
    }
}