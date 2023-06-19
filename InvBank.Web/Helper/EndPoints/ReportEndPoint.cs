using System.Text.Json;
using ErrorOr;
using InvBank.Web.Contracts.Report;

namespace InvBank.Web.Helper.EndPoints;

public class ReportEndPoint : BaseEndPoint
{
    public ReportEndPoint(ApiHelper apiHelper) : base(apiHelper)
    {
    }

    public async Task<ErrorOr<ProfitReportResponse>> GenerateReportProfit(GenerateProfitReportRequest request)
    {
        return await MakeRequest<ProfitReportResponse>
        (
            () => _apiHelper.DoPost("/report/profit", JsonSerializer.Serialize(request), "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI")
        );
    }

    public async Task<ErrorOr<PayReportResponse>> GenerateReportPay(string accountIban, GeneratePayReportRequest request)
    {
        return await MakeRequest<PayReportResponse>
        (
            () => _apiHelper.DoPost($"/report/pay?iban={accountIban}", JsonSerializer.Serialize(request), "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI")
        );
    }

}