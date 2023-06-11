namespace ConsoleApp1;

public class VideoEncoder
{
    
    //1-Define Delegate
    public delegate void VideoEncodedEventHandler(object source,EventArgs args);

    //2-Define Event
    public event VideoEncodedEventHandler VideoEncoded;
    
    public void Encode(Video video)
    {
        Console.WriteLine("Encoding...");
        Thread.Sleep(3000);
        
        //3-Raise Event
        OnVideoEncoded();
    }

    protected virtual void OnVideoEncoded()
    {
        if (VideoEncoded!=null)
        {
            VideoEncoded(this,EventArgs.Empty);
        }
    }
}