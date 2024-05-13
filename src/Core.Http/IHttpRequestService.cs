namespace NArchitecture.Core.Http;

public interface IHttpRequestService<TRequest, TResponse>
{
    TResponse Send(TRequest request);

    Task<TResponse> SendAsync(TRequest request);
}
