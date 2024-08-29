using RestSharp;

namespace Core.Http.RestSharp;

public class RequestBody
{
    public object Body { get; private set; }
    public ContentType ContentType { get; private set; }

    public RequestBody()
    {
        Body = default!;
        ContentType = ContentType.Undefined;
    }

    public RequestBody(object body, ContentType contentType)
    {
        Body = body;
        ContentType = contentType;
    }
}
