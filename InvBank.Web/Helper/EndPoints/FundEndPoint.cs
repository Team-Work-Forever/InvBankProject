using System.Text.Json;
using ErrorOr;
using InvBank.Web.Contracts;
using InvBank.Web.Contracts.Fund;

namespace InvBank.Web.Helper.EndPoints;

public class FundEndPoint : BaseEndPoint
{
    public FundEndPoint(ApiHelper apiHelper) : base(apiHelper)
    {
    }

    public async Task<ErrorOr<SimpleResponse>> CreateFund(CreateFundRequest request)
    {
        return await MakeRequest<SimpleResponse>(
            () => _apiHelper.DoPost($"/funds/create", JsonSerializer.Serialize(request), "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI")
        );
    }

    public async Task<ErrorOr<IEnumerable<FundResponse>>> GetInvestFundOfAccount(string accountIban)
    {
        return await MakeRequest<IEnumerable<FundResponse>>(
            () => _apiHelper.DoGet($"/funds?iban={accountIban}", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI")
        );
    }

}