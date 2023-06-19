using System.Text.Json;
using ErrorOr;
using InvBank.Web.Contracts;
using InvBank.Web.Contracts.Bank;

namespace InvBank.Web.Helper.EndPoints;

public class BankEndPoint : BaseEndPoint
{
    public BankEndPoint(ApiHelper apiHelper) : base(apiHelper)
    {
    }

    public async Task<ErrorOr<IEnumerable<BankResponse>>> GetAllBanks()
    {
        return await MakeRequest<IEnumerable<BankResponse>>
        (
            () => _apiHelper.DoGet("/banks", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI")
        );
    }

    public async Task<ErrorOr<SimpleResponse>> CreateBank(RegisterBankRequest request)
    {
        return await MakeRequest<SimpleResponse>
        (
            () => _apiHelper.DoPost("/banks/create", JsonSerializer.Serialize(request), "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI")
        );
    }

}