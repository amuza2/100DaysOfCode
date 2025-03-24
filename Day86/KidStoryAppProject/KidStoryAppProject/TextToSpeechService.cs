
public class TextToSpeechService : ITextToSpeechService
{
    public async Task SpeakAsync(string text, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(text)) return;

        try
        {
            var settings = new SpeechOptions
            {
                Volume = 1.0f,
                Pitch = 1.0f,
                Locale = null
            };
            await TextToSpeech.Default.SpeakAsync(text, settings);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Speech error: {ex.Message}");
            throw;
        }
    }

    public async Task StopAsync()
    {
        try
        {
            await TextToSpeech.Default.SpeakAsync("");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Stop speech error: {ex.Message}");
            throw;
        }
    }
}