using System.Net;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;

namespace webApiClient;

public class RunApiKey
{
    private static string _textAnalysisApiKey { get; } = EnvironmentVariable.GetOrThrow("TextRazorApiKey");
    private static string _textAnalysisEndpoint { get; } = EnvironmentVariable.GetOrThrow("TextRazorEndpoint");
    private static string _textToAnalyze = "Today is a great day. I has a wonderful dinner with my family!";
    private static readonly HttpClient client = new HttpClient();
    public static async Task<string> Run()
    {
        try
        {
            var response = await CallTextRazorApi(_textAnalysisApiKey, _textToAnalyze);
            Console.WriteLine("response from TextRazor API:");
            return response;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return string.Empty;
        } 
    }
    

    private static async Task<string> CallTextRazorApi(string textAnalysisApiKey, string textToAnalyze)
    {
        var content = new StringContent($"extractors=entities,entailments&text={Uri.EscapeDataString(textAnalysisApiKey)}", Encoding.UTF8, "application/x-www-form-urlencoded");

        client.DefaultRequestHeaders.Remove("x-textrazor-key");
        client.DefaultRequestHeaders.Add("x-textrazor-key", textAnalysisApiKey);

        HttpResponseMessage response = await client.PostAsync(_textAnalysisEndpoint, content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}
