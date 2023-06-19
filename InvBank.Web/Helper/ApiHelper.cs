using System.Net.Http.Headers;
using System.Text;
using Blazored.LocalStorage;
using InvBank.Web.Helper.Authentication;

namespace InvBank.Web.Helper;

public class ApiHelper
{
    private readonly ILocalStorageService _localStorage;
    private readonly string apiUrl = "https://localhost:7022";
    private readonly IConfiguration _configuration;
    private readonly HttpClient _httpClient;

    public ApiHelper(IConfiguration configuration, HttpClient httpClient, ILocalStorageService localStorage)
    {
        _configuration = configuration;
        _httpClient = httpClient;
        _localStorage = localStorage;
    }

    public async Task<HttpResponseMessage> DoGet(string endpoint)
    {
        var url = apiUrl + endpoint;
        var request = new HttpRequestMessage(HttpMethod.Get, url);

        return await _httpClient.SendAsync(request);
    }

    public async Task<HttpResponseMessage> DoGet(string endpoint, string token)
    {
        var url = apiUrl + endpoint;
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await _localStorage.GetItemAsStringAsync(CookieValue.AccessToken));

        try
        {
            return await _httpClient.SendAsync(request);
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e);
        }

        return await _httpClient.SendAsync(request);
    }

    public async Task<HttpResponseMessage> DoPost(string endpoint, string payload)
    {
        var url = apiUrl + endpoint;
        var request = new HttpRequestMessage(HttpMethod.Post, url);

        request.Content = new StringContent(payload, Encoding.UTF8, "application/json");

        return await _httpClient.SendAsync(request);
    }

    public async Task<HttpResponseMessage> DoPost(string endpoint, string payload, string token)
    {
        var url = apiUrl + endpoint;
        var request = new HttpRequestMessage(HttpMethod.Post, url);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await _localStorage.GetItemAsStringAsync(CookieValue.AccessToken));

        request.Content = new StringContent(payload, Encoding.UTF8, "application/json");

        return await _httpClient.SendAsync(request);
    }

    public async Task<HttpResponseMessage> DoUpdate(string endpoint, string payload, string token)
    {
        var url = apiUrl + endpoint;
        var request = new HttpRequestMessage(HttpMethod.Put, url);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await _localStorage.GetItemAsStringAsync(CookieValue.AccessToken));

        request.Content = new StringContent(payload, Encoding.UTF8, "application/json");

        return await _httpClient.SendAsync(request);
    }

    public async Task<HttpResponseMessage> DoDelete(string endpoint, string token)
    {
        var url = apiUrl + endpoint;
        var request = new HttpRequestMessage(HttpMethod.Delete, url);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await _localStorage.GetItemAsStringAsync(CookieValue.AccessToken));

        return await _httpClient.SendAsync(request);
    }

}