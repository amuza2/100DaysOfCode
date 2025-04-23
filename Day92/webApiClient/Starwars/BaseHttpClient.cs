using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace webApiClient;

public class BaseHttpClient
{
    private HttpClient _client;
    HttpClientHandler handler;

    public BaseHttpClient(string url)
    {
        _client = new HttpClient();
        handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = (HttpRequestMessage req, X509Certificate2 cert, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
        _client = new HttpClient(handler) { BaseAddress = new Uri(url) };

    }

    protected HttpRequestMessage CreateGetRequest(string url)
    {
        return new HttpRequestMessage(HttpMethod.Get, new Uri(url, UriKind.Relative));
    }

    protected async Task<T> SendRequest<T>(HttpRequestMessage request)
    {
        var response = await _client.SendAsync(request);

        if (!response.IsSuccessStatusCode)
            throw new HttpRequestException(response.ReasonPhrase);

        var content = await response.Content.ReadAsStringAsync();
        var apiResult = JsonSerializer.Deserialize<T>(content);
        return apiResult;
    }

    protected Task<ApiResult<IEnumerable<T>>> SendGetManyRequests<T>(HttpRequestMessage request)
        => SendRequest<ApiResult<IEnumerable<T>>>(request);
}