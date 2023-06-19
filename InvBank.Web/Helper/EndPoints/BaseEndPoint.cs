using System.Net;
using System.Text.Json;
using ErrorOr;

namespace InvBank.Web.Helper.EndPoints;

public class BaseEndPoint
{
    protected readonly ApiHelper _apiHelper;

    public BaseEndPoint(ApiHelper apiHelper)
    {
        _apiHelper = apiHelper;
    }

    protected delegate Task<HttpResponseMessage> MakeFunc();

    protected async Task<ErrorOr<T>> MakeRequest<T>(MakeFunc t)
    {
        HttpResponseMessage httpResponseMessage = await t.Invoke();

        if (httpResponseMessage.StatusCode != HttpStatusCode.OK)
        {
            return Errors.Errors.Account.AccountNotFound;
        }

        string result = await httpResponseMessage.Content.ReadAsStringAsync();

        T? accountsResult = JsonSerializer.Deserialize<T>(result);

        if (accountsResult is null)
        {
            return Errors.Errors.Auth.RequestFailed;
        }

        return accountsResult;
    }

}