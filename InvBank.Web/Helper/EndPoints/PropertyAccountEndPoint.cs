using System.Text.Json;
using ErrorOr;
using InvBank.Web.Contracts;
using InvBank.Web.Contracts.PropertyAccount;

namespace InvBank.Web.Helper.EndPoints;

public class PropertyAccountEndPoint : BaseEndPoint
{
    public PropertyAccountEndPoint(ApiHelper apiHelper) : base(apiHelper)
    {
    }

    public async Task<ErrorOr<SimpleResponse>> CreatePropertyAccount(CreatePropertyAccountRequest request)
    {
        return await MakeRequest<SimpleResponse>
        (
            () => _apiHelper.DoPost("/properties/create", JsonSerializer.Serialize(request), "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI")
        );
    }

    public async Task<ErrorOr<PropertyAccountResponse>> GetPropertyAccount(Guid id)
    {
        return await MakeRequest<PropertyAccountResponse>
        (
            () => _apiHelper.DoGet($"/properties?id={id}", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI")
        );
    }

    public async Task<ErrorOr<IEnumerable<PropertyAccountResponse>>> GetAllPropertyAccount(string accountIban)
    {
        return await MakeRequest<IEnumerable<PropertyAccountResponse>>
        (
            () => _apiHelper.DoGet($"/properties/all?iban={accountIban}", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI")
        );
    }

    public async Task<ErrorOr<IEnumerable<PropertyAccountResponse>>> UpdatePropertyAccount(Guid id, UpdatePropertyAccountRequest request)
    {
        return await MakeRequest<IEnumerable<PropertyAccountResponse>>
        (
            () => _apiHelper.DoUpdate($"/properties/update?id={id}", JsonSerializer.Serialize(request), "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI")
        );
    }

    public async Task<ErrorOr<SimpleResponse>> DeletePropertyAccount(Guid id)
    {
        return await MakeRequest<SimpleResponse>
        (
            () => _apiHelper.DoDelete($"/properties/delete?id={id}", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InplQGdtYWlsLmNvbSIsInJvbGUiOiIwIiwidXNlcklkIjoiODAwNWU1MGQtNDE2OS00ZjQwLTlmYzMtZjk2YTY5YjgwNmI5IiwiZXhwIjoxNjg3MDkwMTM4LCJpc3MiOiJJbnZlc3RtZW50QmFuayIsImF1ZCI6IkludmVzdG1lbnRCYW5rIn0.4aHK7sC1RjGfeXWUmLOy1Bi22GXJqDqZ30nJD6uGcgI")
        );
    }

}