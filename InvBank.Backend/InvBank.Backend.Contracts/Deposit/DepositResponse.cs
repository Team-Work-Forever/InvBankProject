namespace InvBank.Backend.Contracts.Deposit;

public record DepositResponse
(
    Guid Id,
    string DepositName,
    string InitialDate,
    int Duration,
    decimal Value,
    decimal TaxPercent,
    decimal YearlyTax,
    string Account
);