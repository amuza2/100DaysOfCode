public class MessageService
{
    public void OnVideoEncoded(object sender, VideoEventArgs e)
    {
        System.Console.WriteLine("MessageService: sending a text message. " + e.Video.Title);
    }
}