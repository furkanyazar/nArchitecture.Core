using RestSharp;

namespace Core.Http.RestSharp;

public class RequestOptions
{
    public string BaseUrl { get; set; }
    public Method Method { get; set; }
    public string? Resource { get; set; }
    public RequestBody? Body { get; set; }
    public Dictionary<string, string>? Headers { get; set; }
    public Dictionary<string, string>? Parameters { get; set; }

    public RequestOptions()
    {
        BaseUrl = string.Empty;
    }

    public RequestOptions(
        string baseUrl,
        Method method,
        string? resource = null,
        RequestBody? requestBody = null,
        Dictionary<string, string>? headers = null,
        Dictionary<string, string>? parameters = null
    )
    {
        BaseUrl = baseUrl;
        Method = method;
        Resource = resource;
        Body = requestBody;
        Headers = headers;
        Parameters = parameters;
    }
}
