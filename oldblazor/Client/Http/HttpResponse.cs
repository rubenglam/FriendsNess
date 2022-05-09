namespace FriendsNess.Client.Http;

public class HttpResponse
{
    public HttpResponse(bool error, HttpResponseMessage httpResponseMessage)
    {
        Error = error;
        HttpResponseMessage = httpResponseMessage;
    }

    public bool Error { get; set; }
    public HttpResponseMessage HttpResponseMessage { get; set; }

    public async Task<string> GetBody()
    {
        return await HttpResponseMessage.Content.ReadAsStringAsync();
    }
}

public class HttpResponse<T> : HttpResponse
{
    public HttpResponse(T response, bool error, HttpResponseMessage httpResponseMessage) : base(error, httpResponseMessage)
    {
        Error = error;
        Response = response;
        HttpResponseMessage = httpResponseMessage;
    }

    public T Response { get; set; }
}

