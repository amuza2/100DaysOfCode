public class MailService
{
    public void OnVideoEncoded(object sender, VideoEventArgs e)
    {
        System.Console.WriteLine("Mail Service: Sending an email... " + e.Video.Title);
    }
}