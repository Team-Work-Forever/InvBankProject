using System.Text.Json;
using ErrorOr;
using InvBank.Web.Contracts;
using InvBank.Web.Contracts.Account;

namespace InvBank.Web.Helper.EndPoints;

public class AccountEndPoint : BaseEndPoint
{
    public AccountEndPoint(ApiHelper apiHelper) : base(apiHelper)
    {
    }

    public async Task<ErrorOr<AccountResponse>> CreateAccount(CreateAccountRequest request)
    {
        return await MakeRequest<AccountResponse>(() => _apiHelper.DoPost($"/accounts/create", JsonSerializer.Serialize(request),"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI"));
    }

    public async Task<ErrorOr<AccountResponse>> GetAccount(string iban)
    {
        return await MakeRequest<AccountResponse>(() => _apiHelper.DoGet($"/accounts?iban={iban}", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI"));
    }

    public async Task<ErrorOr<IEnumerable<AccountResponse>>> GetAllAccount()
    {
        return await MakeRequest<IEnumerable<AccountResponse>>(() => _apiHelper.DoGet($"/accounts/all", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI"));
    }

    public async Task<ErrorOr<SimpleResponse>> DeleteAccount(string iban)
    {
        return await MakeRequest<SimpleResponse>(
            () => _apiHelper.DoDelete($"/accounts/delete?iban={iban}",
            "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MTAyMTUwLCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.jc1Wmn_2wcbiQY_-kMY3HJmcHorF9PlGNoKQte4bu4Q"));
    }

}