using RestSharp;

namespace Core.Http.RestSharp;

public class RestSharpHttpRequestService : IHttpRequestService<RequestOptions, RestResponse>
{
    public RestResponse Send(RequestOptions options)
    {
        using RestClient client = getRestClient(options);
        RestRequest request = getRestRequest(options);
        RestResponse response = client.Execute(request);
        client.Dispose();
        return response;
    }

    public async Task<RestResponse> SendAsync(RequestOptions options)
    {
        using RestClient client = getRestClient(options);
        RestRequest request = getRestRequest(options);
        RestResponse response = await client.ExecuteAsync(request);
        client.Dispose();
        return response;
    }

    private RestClient getRestClient(RequestOptions options)
    {
        RestClientOptions clientOptions = new(options.BaseUrl);
        RestClient client = new(clientOptions);
        return client;
    }

    private RestRequest getRestRequest(RequestOptions options)
    {
        RestRequest request = new(options.Resource, options.Method);

        if (options.Body is not null)
            _ = request.AddBody(obj: options.Body.Body, contentType: options.Body.ContentType);

        if (options.Headers is not null)
            foreach (var header in options.Headers)
                _ = request.AddHeader(header.Key, header.Value);

        if (options.Parameters is not null)
            foreach (var param in options.Parameters)
                _ = request.AddParameter(param.Key, param.Value);

        return request;
    }
}
