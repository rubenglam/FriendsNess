using System.Text;
using System.Text.Json;

namespace FriendsNess.Client.Http;

public interface IRepository
{
    Task<HttpResponse> Delete(string url);
    Task<HttpResponse<TResponse>> Get<TResponse>(string url, Dictionary<string, string> query = null);
    Task<HttpResponse> Post<TRequest>(string url, TRequest item);
    Task<HttpResponse<TResponse>> Post<TRequest, TResponse>(string url, TRequest item);
    Task<HttpResponse> Put(string url);
    Task<HttpResponse> Put<TRequest>(string url, TRequest item);
}

public class Repository : IRepository
{
    private readonly HttpClient _httpClient;

    public Repository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    private JsonSerializerOptions DefaultJsonSerializerSettings =>
        new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };

    public async Task<HttpResponse<TResponse>> Get<TResponse>(string url, Dictionary<string, string> query = null)
    {
        if (_httpClient.DefaultRequestHeaders.Authorization != null)
        {
            Console.WriteLine(_httpClient.DefaultRequestHeaders.Authorization.ToString());
        }
        if (query != null)
        {
            var defaultValues = new List<string>() { "false", "", "0" };
            url += "?" + string.Join("&", query
                .Where(x => !defaultValues.Contains(x.Value.ToLower()))
                .Select(x => $"{x.Key}={System.Web.HttpUtility.UrlEncode(x.Value)}").ToArray());
        }
        var httpResponse = await _httpClient.GetAsync(url);
        if (httpResponse.IsSuccessStatusCode)
        {
            var response = await DeserializeResponse<TResponse>(httpResponse);
            return new HttpResponse<TResponse>(response, false, httpResponse);
        }
        else
        {
            return new HttpResponse<TResponse>(default, true, httpResponse);
        }
    }

    public async Task<HttpResponse> Post<TRequest>(string url, TRequest item)
    {
        var httpPostJson = JsonSerializer.Serialize(item, DefaultJsonSerializerSettings);
        var httpPostContent = new StringContent(httpPostJson, Encoding.UTF8, "application/json");
        var httpResponse = await _httpClient.PostAsync(url, httpPostContent);
        return new HttpResponse(!httpResponse.IsSuccessStatusCode, httpResponse);
    }

    public async Task<HttpResponse<TResponse>> Post<TRequest, TResponse>(string url, TRequest item)
    {
        var httpPostJson = JsonSerializer.Serialize(item, DefaultJsonSerializerSettings);
        var httpPostContent = new StringContent(httpPostJson, Encoding.UTF8, "application/json");
        var httpResponse = await _httpClient.PostAsync(url, httpPostContent);
        if (httpResponse.IsSuccessStatusCode)
        {
            var response = await DeserializeResponse<TResponse>(httpResponse);
            return new HttpResponse<TResponse>(response, false, httpResponse);
        }
        else
        {
            return new HttpResponse<TResponse>(default, true, httpResponse);
        }
    }

    public async Task<HttpResponse> Put(string url)
    {
        var httpPostContent = new StringContent(null, Encoding.UTF8, "application/json");
        var httpResponse = await _httpClient.PutAsync(url, httpPostContent);
        return new HttpResponse(!httpResponse.IsSuccessStatusCode, httpResponse);
    }

    public async Task<HttpResponse> Put<TRequest>(string url, TRequest item)
    {
        var httpPostJson = JsonSerializer.Serialize(item, DefaultJsonSerializerSettings);
        var httpPostContent = new StringContent(httpPostJson, Encoding.UTF8, "application/json");
        var httpResponse = await _httpClient.PutAsync(url, httpPostContent);
        return new HttpResponse(!httpResponse.IsSuccessStatusCode, httpResponse);
    }

    public async Task<HttpResponse> Delete(string url)
    {
        var httpResponse = await _httpClient.DeleteAsync(url);
        return new HttpResponse(!httpResponse.IsSuccessStatusCode, httpResponse);
    }

    private async Task<TResponse> DeserializeResponse<TResponse>(HttpResponseMessage httpResponse)
    {
        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<TResponse>(stringResponse, DefaultJsonSerializerSettings);
    }
}