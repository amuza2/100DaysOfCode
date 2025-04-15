using System.Text.Json.Serialization;

namespace webApiClient;

public record ApiResult<T>
{
    public int Count { get; set; }
    public string Next { get; set; }
    public string Previous { get; set; }
    [JsonPropertyName("results")]
    public T Data { get; set; }
}
